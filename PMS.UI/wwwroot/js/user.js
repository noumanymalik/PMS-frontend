function loadUserRoles() {
	$.ajax({
		type: 'GET',
		url: apiEndpoint + 'Users/GetRoles',
		contentType: 'application/json; charset=utf-8',
		dataType: 'json',
		headers: {
			'Authorization': 'Bearer ' + $('input:hidden[name="__RequestVerificationToken"]').val(),
		},
		success: function (response) {
			var data = response.data;
			var $select = $('.user-roles');

			$.each(data, function (key, item) {
				$select.append('<option value=' + item.id + '>' + item.name + '</option>');
			});
		}
	})
}
function loadEmployees() {
    $.ajax({
        type: 'GET',
        url: apiEndpoint + 'Employee/GetAll',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        headers: {
            'Authorization': 'Bearer ' + $('input:hidden[name="_RequestVerificationToken"]').val(),
        },
        success: function (response) {
            var data = response.data;
            var $select = $('.ddl-Employees');

            $.each(data, function (key, item) {
                $select.append('<option value=' + item.id + '>' + item.name + '</option>');
            });
        }
    })
}

$(function () {
	var modelPlaceholder = $('#modal-placeholder');
	$('a[data-toggle="ajax-modal-role"]').on('click', function (event) {

		var url = $(this).data('url');
		$.get(url).done(function (data) {

			modelPlaceholder.html(data);
			modelPlaceholder.find('.modal').modal('show');

			let $form = $(modelPlaceholder).find('#frmCreate');
			resetUnobtrusiveValidation($form);
		});
	});

	$('a[data-toggle="ajax-modal-user"]').on('click', function (event) {

		var url = $(this).data('url');
		$.get(url).done(function (data) {

			modelPlaceholder.html(data);
			modelPlaceholder.find('.modal').modal('show');

			let $form = $(modelPlaceholder).find('#frmCreate');
			resetUnobtrusiveValidation($form);
		});
	});

	modelPlaceholder.on('click', '.create-user', function (event) {
		event.preventDefault();
		let $form = $(this).parents('.modal').find('form');

		var formData = {
			email: $('.user-email').val(),
			employeeId: $("#employeeId option:selected").val(),
			roleId: $("#userRole option:selected").val(),
			firstName: $('.user-fname').val(),
			lastName: $('.user-lname').val(),
			password: $('.user-conPws').val(),

		};
		if ($form.validate().form()) {
			$.blockUI({ baseZ: 1055, message: '<h1>Processing...</h1>' });

			$.ajax({
				type: 'POST',
				url: apiEndpoint + 'Users/CreateUser',
				contentType: 'application/json; charset=utf-8',
				dataType: 'json',
				data: JSON.stringify(formData),
				headers: {
					'Authorization': 'Bearer ' + $('input:hidden[name="__RequestVerificationToken"]').val(),
				},
				success: function (data) {
					$.unblockUI();
					if (data.succeeded) {
						toastr.success(data.messages[0]);
						window.setInterval(goBack, 1000);
					}
					else {
						toastr.error(data.message);
					}
				},
				error: function (jqXHR, textStatus, errorThrown) {
					$.unblockUI();
					var errors = JSON.parse(jqXHR.responseText).errors;
					$.each(jqXHR.responseJSON.errors, function (field, message) {
						toastr.error(message);
					});
				}
			}).done(function (result) {
				//console.log(result);
			});
		}
	});

	modelPlaceholder.on('click', '.create-userRole', function (event) {
		event.preventDefault();
		let $form = $(this).parents('.modal').find('form');
		debugger
		var formData = {
			name: $('.role-name').val(),
		};

		if ($form.validate().form()) {
			$.blockUI({ baseZ: 1055, message: '<h1>Processing...</h1>' });

			$.ajax({
				type: 'POST',
				url: apiEndpoint + 'Users/CreateUserRole',
				contentType: 'application/json; charset=utf-8',
				dataType: 'json',
				data: JSON.stringify(formData),
				headers: {
					'Authorization': 'Bearer ' + $('input:hidden[name="__RequestVerificationToken"]').val(),
				},
				success: function (data) {
					$.unblockUI();
					if (data.succeeded) {
						toastr.success(data.messages[0]);
						window.setInterval(goBack, 1000);
					}
					else {
						toastr.error(data.message);
					}
				},
				error: function (jqXHR, textStatus, errorThrown) {
					$.unblockUI();
					var errors = JSON.parse(jqXHR.responseText).errors;
					$.each(jqXHR.responseJSON.errors, function (field, message) {
						toastr.error(message);
					});
				}
			}).done(function (result) {
				//console.log(result);
			});
		}
	});

	modelPlaceholder.on('shown.bs.modal', function (e) {
		$('input:text:visible:first', this).focus();
	});
});

$('#frmChangePassword').on('submit', function (e) {
	e.preventDefault();

	if (!$('#frmChangePassword').valid()) {
		return;
	}

	var formData = {
		email: $('.user-email').val(),
		password: $('.user-pws').val(),
		newPassword: $('.user-newPws').val(),
	};

	$.blockUI({ baseZ: 1001, message: '<h1>Processing...</h1>' });
	$.ajax({
		type: 'PUT',
		url: apiEndpoint + 'Users/ChangePassword',
		contentType: 'application/json; charset=utf-8',
		dataType: 'json',
		data: JSON.stringify(formData),
		headers: {
			'Authorization': 'Bearer ' + $('input:hidden[name="__RequestVerificationToken"]').val(),
		},
		success: function (data) {
			$.unblockUI();
			if (data.succeeded) {
				toastr.success(data.messages[0]);
				window.setInterval(goBack, 1000);
			}
			else {
				toastr.error(data.message);
			}
		},
		error: function (jqXHR, textStatus, errorThrown) {
			$.unblockUI();
			debugger
			var errors = JSON.parse(jqXHR.responseText).errors;
			$.each(jqXHR.responseJSON.errors, function (field, message) {
				toastr.error(message);
			});
		}
	}).done(function (result) {
		//console.log(result);
	});
});


function goBack() {
	window.location.href = $('#redirectToListing').val();
}

var resetUnobtrusiveValidation = (form) => {
	form.removeData('validator');
	form.removeData('unobtrusiveValidation');
	$.validator.unobtrusive.parse(form);
}
