
var helper = {};

//statis value
(function (helper) {
    helper.MessageType = {
        Success: 'alert alert-success',
        Info: 'alert alert-info',
        Warning: 'alert alert-warning',
        Danger: 'alert alert-danger'
    }
})(helper || {});

(function (helper) {
    helper.InitSelect2 = function () {
        //for select2
        $('.select2').select2({
            minimumInputLength: 1
        });
        //for ajax select 2
        $('select').on('select2:select', function (evt) {
            var currentValue = $(this).val();
            var data = $(this).data();
            if (data.submitUrl) {
                $.post(data.submitUrl, { key: data.pk, value: currentValue }, function (result) {
                    if (result.results === true) {
                        helper.showAlertMessageBox("Success", "Thành công");
                    } else {
                        helper.showAlertMessageBox("Danger", "Lỗi");
                    }
                });
            }
            // Do something
        });
    };

})(helper || {});


(function (helper) {

    helper.showAlertMessageBox = function (messageType, content) {
        $('#messages').removeClass('hide').addClass(`${helper.MessageType[messageType]} alert-dismissible`).slideDown().show();
        $('#messages_content').html(`<h4>${content}</h4>`);
        $('#modal').modal('show');
    }
})(helper || {});

//init function
helper.InitSelect2();