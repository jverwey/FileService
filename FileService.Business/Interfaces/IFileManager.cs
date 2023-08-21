using Microsoft.AspNetCore.Http;

namespace FileService.Business.Interfaces
{
    public interface IFileManager
    {
        Task UploadFiles(IFormFileCollection uploadedFiles, string uploadedFilePath, string[] contentTypes);

        IQueryable<Models.FileInfo> GetAllFiles();

        Models.FileInfo GetFile(int id);
    }
}
