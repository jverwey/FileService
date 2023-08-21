using Microsoft.EntityFrameworkCore;

namespace FileService.Data
{
    public class FileServiceContext : DbContext
    {
        public DbSet<Models.FileInfo> FileInfos => base.Set<Models.FileInfo>();

        // TODO: Make the connection string configurable for code first migrations
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=D:\\Repos\\FileService\\FileService.Data\\Database\\FileSystem.db");
    }
}
