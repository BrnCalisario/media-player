namespace CleanArch.Domain;

public interface IBlobFileRepository 
{
    Task<BlobFile> CreateAsync(BlobFile file);
    Task<BlobFile> DeleteAsync(Guid id);
    IQueryable<BlobFile?> GetById(Guid id);
    IQueryable<BlobFile> GetAllNoTracking();
    Task SaveChangesAsync();
}
