using FileService.Business;
using Microsoft.AspNetCore.Mvc;

namespace FileService.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class FileManagementController : ControllerBase
    {
        private readonly ILogger<FileUploadController> _logger;
        private readonly FileManager _fileManager = new FileManager();

        [HttpGet]
        [Route("GetAllFiles")]
        public ActionResult<IEnumerable<Models.FileInfo>> GetAllFiles()
        {
            return _fileManager.GetAllFiles().ToList();
        }

        [HttpGet]
        [Route("GetFile")]
        public ActionResult<Models.FileInfo> GetFile(int id)
        {
            return _fileManager.GetFile(id);
        }

        [HttpGet]
        [Route("DownloadFile")]
        public FileResult DownloadFile(int id)
        {
            var file = _fileManager.GetFile(id);

            if (file.Id == 0)
            {
                throw new NullReferenceException(nameof(file));
            }

            return new PhysicalFileResult(file.FileLocation + "\\" + file.FileName, file.ContentType);
        }

        [HttpDelete]
        [Route("DeleteFile/{id:long}")]
        public void DeleteFile(int id)
        {
            _fileManager.DeleteFile(id);
        }
    }
}
