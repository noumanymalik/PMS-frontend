using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using PMS.UI.Models.ViewModels.Authentication;
using System.Security.Claims;

namespace PMS.UI.Pages.Authentication
{
    public class LoginModel : PageModel
    {
        private readonly HttpClient _httpClient;
        public LoginModel(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("pms.api");
        }

        [BindProperty(SupportsGet = true)]
        public LoginViewModel login { get; set; } = default!;

        public async Task<IActionResult> OnPostLoginAsync()
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync<LoginViewModel>($"Users/Login", login);

            if (!response.IsSuccessStatusCode)
            {
                ModelState.AddModelError(string.Empty, "Invalid User Name or Password");
                return Page();
            }

            var Contents = await response.Content.ReadAsStringAsync();
            var jsonApiResponse = JsonConvert.DeserializeObject<LoginResponse>(Contents);

            if (jsonApiResponse != null && jsonApiResponse.AuthenticationToken.ToString() != "")
            {
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);

                identity.AddClaim(new Claim(ClaimTypes.PrimarySid, jsonApiResponse.LoginId.ToString()));
                identity.AddClaim(new Claim(ClaimTypes.Email, jsonApiResponse.Email));
                identity.AddClaim(new Claim(ClaimTypes.Name, jsonApiResponse.UserName));
                identity.AddClaim(new Claim(ClaimTypes.Role, jsonApiResponse.Role));
                identity.AddClaim(new Claim(ClaimTypes.Actor, jsonApiResponse.EmployeeId.ToString()));

                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                HttpContext.Session.SetString("API_Token", jsonApiResponse.AuthenticationToken);

                foreach (var permission in jsonApiResponse.Permissions)
                {
                    HttpContext.Session.SetString(permission.PermissionName, "true");
                }
            }

            return Redirect("/Dashboard");
        }
    }
}
