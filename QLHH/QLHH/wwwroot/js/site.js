
var helper = {};

//statis value
(function (helper) {
   

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
                        $.notify({message: 'Thành công'}, {type: 'success'});
                    } else {
                        $.notify({ message: 'Lỗi' }, { type: 'danger' });
                    }
                });
            }
            // Do something
        });
    };

})(helper || {});



//init select2 function
helper.InitSelect2();