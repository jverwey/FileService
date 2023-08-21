using FileService.Data.Interfaces.Repositories;

namespace FileService.Data.Repositories
{
    public class FileInfoRepository : IFileInfoRepository
    {
        private readonly FileServiceContext _context;

        public FileInfoRepository()
        {
            _context = new FileServiceContext();
        }

        public FileInfoRepository(FileServiceContext context)
        {
            _context = context;
        }

        #region "Query Methods"
        public IQueryable<Models.FileInfo> GetUploadedFiles()
        {
            return _context.FileInfos;
        }

        public Models.FileInfo GetUploadedFile(int uploadedFileId)
        {
            return _context.FileInfos.SingleOrDefault(u => u.Id == uploadedFileId) ?? new Models.FileInfo();
        }
        #endregion

        #region "Insert/Delete Methods"
        public void AddUploadedFile(Models.FileInfo file)
        {
            _context.FileInfos.Add(file);
            _context.SaveChanges();
        }

        public async Task AddUploadedFileAsync(Models.FileInfo file)
        {
            await _context.FileInfos.AddAsync(file);
            await _context.SaveChangesAsync();
        }

        public void AddUploadedFiles(List<Models.FileInfo> files)
        {
            foreach (var file in files)
            {
                AddUploadedFile(file);
            }
        }

        public async Task AddUploadedFilesAsync(List<Models.FileInfo> files)
        {
            foreach (var file in files)
            {
                await AddUploadedFileAsync(file);
            }
        }

        public void DeleteUploadedFile(Models.FileInfo file)
        {
            _context.FileInfos.Remove(file);
            _context.SaveChanges();
        }
        #endregion

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
