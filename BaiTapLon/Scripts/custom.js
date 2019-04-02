$(document).ready(function () {

    $('.btn_like').click(function () {
        var id = $(this).data('id');
        $.ajax({
            url: "/Home/UpLike",
            type: "POST",
            data: { id: id },
            success: function () {
                var idBaiHat = '#b' + id;
                var luotThich = $(idBaiHat).data('luotthich') + 1;
                $(idBaiHat).data('luotthich', luotThich);
                $(idBaiHat).text(luotThich);
            }
        });
        //data: Dữ liệu được gửi lên server khi thực thi một request Ajax.
        //success: Một hàm được gọi khi request thành công.
        //type: Kiểu request muốn thực hiện, có thể là POST hay GET …
        //url: Chuỗi chứa URL mà request được gửi đến.
    });

});