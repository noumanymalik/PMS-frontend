var userRoleId;

$(document).ready(function () {
    userRoleId = 0;
    loadUserRoles();
});

$(function () {
    $('#btnSearchData').on('click', function (e) {
        userRoleId = $("#searchboxInput option:selected").val();
        e.preventDefault();
        if (userRoleId > 0) {
            loadData(userRoleId);
        }
    });
});

function loadUserRoles() {
    $.ajax({
        type: 'GET',
        url: apiEndpoint + 'Users/GetRoles',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        headers: {
            'Authorization': 'Bearer ' + $('input:hidden[name="_RequestVerificationToken"]').val(),
        },
        success: function (response) {
            var data = response.data;
            var $select = $('.userRoles');

            $.each(data, function (key, item) {
                $select.append('<option value=' + item.id + '>' + item.name + '</option>');
            });
        }
    })
}

function loadData(userRoleId) {
    $.blockUI({ baseZ: 1055, message: '<h1>Processing...</h1>' });

    $.ajax({
        type: 'GET',
        url: apiEndpoint + 'Users/GetPermissionsByRoleId/' + userRoleId,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        headers: {
            'Authorization': 'Bearer ' + $('input:hidden[name="_RequestVerificationToken"]').val(),
        },

        success: function (response) {
            $('.permission-table tbody tr:not(:first)').remove();
            var counter = 1;

            $.each(response.data, function (i, item) {

                const $prototypeRow = $('.prototype-row');
                const $newRow = $prototypeRow.clone();
                $newRow.removeClass('prototype-row d-none').addClass('row-' + counter).addClass('data-row item');

                $newRow.find('.pId').val(item.id);
                $newRow.find('.pId').attr('disabled', '');

                $newRow.find('.name').val(item.name);
                $newRow.find('.name').attr('disabled', '');

                $newRow.find('.access').attr('id', 'chkAccess' + counter);
                $newRow.find('.access').attr('name', 'accessid[' + counter + ']');

                if (item.access === true) {
                    $newRow.find('.access').prop("checked", 'true');
                }

                $('.permission-table').append($newRow);

                $newRow.find('input:first').focus();

                counter++;

            });

            $.unblockUI();

        },
        error: function (jqXHR, textStatus, errorThrown) {
            $.unblockUI();
            toastr.error('user role not found');
        }
    }).done(function (result) {
        //console.log(result);
    });

}

$(document).ready(function () {
    $('#frmPermissions').on('submit', function (event) {
        if ($('#frmPermissions').validate().form()) {

            event.preventDefault();

            var formData = {
                roleId: userRoleId,

                permissionlines: []
            };

            var $tableElements = $('.permission-table tr.data-row');

            $.each($tableElements, function (i, elem) {
                //debugger
                //attr("checked") ? 1 : 0;
                var permissionAccess = $(elem).find('td:eq(2)').find('.access').is(':checked');

                //var permissionAccess = parseInt($(elem).find('td:eq(2)').find('.access').val());
                var line = {
                    id: parseInt($(elem).find('td:eq(0)').find('.pId').val()),
                    access: permissionAccess,
                };

                formData.permissionlines.push(line);
            });

            if (formData.permissionlines.length > 0) {
                $.blockUI({ baseZ: 1001, message: '<h1>Saving Permissions</h1>' });
                $.ajax({
                    type: 'POST',
                    url: apiEndpoint + 'Users/CreateRolePermissions',
                    data: JSON.stringify(formData),
                    headers: {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json',
                        'Authorization': 'Bearer ' + $('input:hidden[name="_RequestVerificationToken"]').val(),
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
                });
            }
            else {
                toastr.error('check permissions!');
            }

        } else {
            alert("does not validate");
        }
    });
    $('#frmPermissions').validate();
});

$(document).ready(function () {
    $('.submit-btn').on('click', function () {
        if (!$('#frmPermissions').valid()) {
            return false;
        }
    });
});

function goBack() {
    //history.go(-1);
    window.location.href = $('#redirectToListing').val();
}



