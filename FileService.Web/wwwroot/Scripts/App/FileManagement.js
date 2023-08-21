$(document).ready(function () {
    $.fn.GetAllFiles();
});

$.fn.GetAllFiles = (function () {
    $.ajax({
        url: 'http://localhost:5187/FileManagement/GetAllFiles',
        type: 'GET',
        success: function (result) {
            var tbody = $('#tblFileManagement tbody')
            tbody.empty();
            result.forEach(function (file, index) {
                var tr = $('<tr>');
                $('<td>').html("<a href='javascript: DownloadFile(" + file.id + ")'>" + file.fileName + "</a>").appendTo(tr);
                $('<td>').html((file.fileSize / 1024).toLocaleString('en-US', { maximumFractionDigits: 2 }) + ' KB').appendTo(tr);
                $('<td>').html(file.createdDate).appendTo(tr);
                $('<td>').html("<a href='javascript: DeleteFile(" + file.id + ")'>Delete</a>").appendTo(tr);
                tbody.append(tr);
            });
        },
        error: function (err) {
            alert(err.statusText);
        }
    });
});

function DownloadFile(id) {
    var url = 'http://localhost:5187/FileManagement/DownloadFile?id=' + id;
    window.open(url, 'Download');
}

function DeleteFile(id) {
    console.log(id);
    $.ajax({
        url: 'http://localhost:5187/FileManagement/DeleteFile/' + id,
        type: 'DELETE',
        success: function (result) {
            $("#deleteSuccess").css("display", "block");
            setTimeout(function () {
                $("#deleteSuccess").css("display", "none");
            }, 5000);
            $.fn.GetAllFiles();
        },
        error: function (err) {
            alert(err.statusText);
        }
    });
}