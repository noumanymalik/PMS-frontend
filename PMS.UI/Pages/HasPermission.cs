namespace PMS.UI.Pages
{
    public static class HasPermission
    {
        public static bool Get(string permission, HttpContext context)
        {
            if (!string.IsNullOrEmpty(context.Session.GetString(permission)))
                return true;
            else
                return false;
        }

    }
}
