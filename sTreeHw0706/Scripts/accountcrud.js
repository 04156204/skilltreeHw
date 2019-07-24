$(function () {

    $(document).on("click", '#accinput',function (e) {
        $.ajax({
            url: '/Account/_AccountInput',
            method: 'POST',
            data: $("#insert-account-form").serialize(),
            success: function (reJson) {
                if (reJson.Code == '0001') {
                    alert(reJson.Message);
                }
                else {
                    alert("新增成功");
                    location.reload();
                    
                }
            },
        })
    });
})