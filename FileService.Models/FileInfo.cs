namespace FileService.Models
{
    public class FileInfo
    {
        public int Id { get; set; }
        public string FileLocation { get; set; } = string.Empty;
        public string FileName { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public long FileSize { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
