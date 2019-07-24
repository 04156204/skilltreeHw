$(function () {

    $(document).on("click", '#accinput',function (e) {
        alert("click");
        $.ajax({
            url: '/Account/_AccountInput',
            method: 'POST',
            data: $("#insert-account-form").serialize(),
            success: function (reJson) {
                if (reJson.Code == '0001') {
                    alert(reJson.Message);
                }
                else {
                    location.reload();
                    
                }
            },
        })
    });
})