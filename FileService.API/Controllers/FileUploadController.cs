using FileService.Business;
using Microsoft.AspNetCore.Mvc;

namespace FileService.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileUploadController : ControllerBase
    {
        private readonly ILogger<FileUploadController> _logger;
        private readonly FileManager _fileManager = new FileManager();
        private readonly IConfiguration _configuration;

        public FileUploadController(ILogger<FileUploadController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("UploadFiles")]
        [DisableRequestSizeLimit]
        public async Task UploadFiles()
        {
            //TODO: Make use of S3 or Azure Blob storage.
            var uploadedFilePath = _configuration["UploadFileLocation"] ?? "C:\\Uploads";
            var section = _configuration.GetSection("FileTypesAllowed");
            var contentTypes = section.Get<string[]>();

            var uploadedFiles = Request.Form.Files;

            //TODO: Implement Error handling and user friendly messages
            if (uploadedFiles == null || contentTypes == null)
            {
                throw new NullReferenceException();
            }

            await _fileManager.UploadFiles(uploadedFiles, uploadedFilePath, contentTypes);
        }
    }
}
