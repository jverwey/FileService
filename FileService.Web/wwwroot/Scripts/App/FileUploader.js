$(document).ready(function () {
    $("#btnUploadFiles").click(function () {
        var fileUpload = $("#files").get(0);
        var files = fileUpload.files;
        var data = new FormData();
        for (var count = 0; count < files.length; count++) {
            data.append(files[count].name, files[count]);
        }

        $.ajax({
            url: 'http://localhost:5187/FileUpload/UploadFiles',
            type: 'POST',
            data: data,
            contentType: false,
            processData: false,
            success: function (result) {
                $.fn.GetAllFiles();
                $("#files").val(null); 
                $("#uploadSuccess").css("display", "block");
                setTimeout(function () {
                    $("#uploadSuccess").css("display", "none");
                }, 5000);
            },
            error: function (err) {
                alert(err.statusText);
            }  
        });
    });
});