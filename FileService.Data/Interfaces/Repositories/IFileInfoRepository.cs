namespace FileService.Data.Interfaces.Repositories
{
    public interface IFileInfoRepository
    {
        void AddUploadedFile(Models.FileInfo uploadFile);
        Task AddUploadedFileAsync(Models.FileInfo file);
        void AddUploadedFiles(List<Models.FileInfo> uploadFiles);
        Task AddUploadedFilesAsync(List<Models.FileInfo> files);
        void DeleteUploadedFile(Models.FileInfo uploadFile);
    }
}
