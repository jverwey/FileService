using FileService.Business.Interfaces;
using FileService.Data.Repositories;
using Microsoft.AspNetCore.Http;

namespace FileService.Business
{
    public class FileManager : IFileManager
    {
        private FileInfoRepository _fileInfoRepository = new FileInfoRepository();

        public FileManager() { }

        #region Business Functions
        public async Task UploadFiles(IFormFileCollection uploadedFiles, string uploadedFilePath, string[] contentTypes)
        {
            var guidLocation = Guid.NewGuid();

            var files = new List<Models.FileInfo>();
            var fileLocation = uploadedFilePath + "\\" + guidLocation;
            foreach (var uploadedFile in uploadedFiles)
            {
                //Prevent front-end manipulation to thwart contentTypes allowed.
                if (contentTypes.Contains(uploadedFile.ContentType))
                {
                    //Multi-Threading of the upload to continue processing quickly.
                    UploadFile(uploadedFile, fileLocation);

                    var fileInfo = new Models.FileInfo
                    {
                        FileSize = uploadedFile.Length,
                        ContentType = uploadedFile.ContentType,
                        FileLocation = fileLocation,
                        FileName = uploadedFile.FileName
                    };

                    files.Add(fileInfo);
                }
            }

            await _fileInfoRepository.AddUploadedFilesAsync(files);
        }

        private async Task UploadFile(IFormFile uploadedFile, string uploadedFilePath)
        {
            var fullFilePath = uploadedFilePath + "\\" + uploadedFile.FileName;

            if (!Directory.Exists(uploadedFilePath))
            {
                Directory.CreateDirectory(uploadedFilePath);
            }

            using (FileStream stream = new FileStream(fullFilePath, FileMode.Create))
            {
                await uploadedFile.CopyToAsync(stream);
            }
        }

        public void DeleteFile(int id)
        {
            var file = GetFile(id);

            File.Delete(file.FileLocation + "\\" + file.FileName);

            _fileInfoRepository.DeleteUploadedFile(file);
        }
        #endregion

        #region Repository Functions
        public IQueryable<Models.FileInfo> GetAllFiles()
        {
            return _fileInfoRepository.GetUploadedFiles();
        }

        public Models.FileInfo GetFile(int id)
        {
            return _fileInfoRepository.GetUploadedFile(id);
        }
        #endregion


    }
}
