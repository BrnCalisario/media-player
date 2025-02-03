using CleanArch.Domain;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infrastructure;

public class BlobFileRepository : IBlobFileRepository
{
    private readonly DotnetTubeDbContext dbContext;
    private DbSet<BlobFile> Set => dbContext.Set<BlobFile>();

    public BlobFileRepository(DotnetTubeDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<BlobFile> CreateAsync(BlobFile file)
    {
        await Set.AddAsync(file);
        return file;
    }

    public async Task<BlobFile> DeleteAsync(Guid id)
    {   
        var obj = await GetById(id).FirstOrDefaultAsync() ?? throw new Exception("Entity not found");
        Set.Remove(obj);
        return obj;
    }

    public IQueryable<BlobFile> GetAllNoTracking()
    {
        return Set.AsNoTracking();
    }

    public IQueryable<BlobFile?> GetById(Guid id)
    {    
        return dbContext.Set<BlobFile>().Where(e => e.Id == id);
    }

    public async Task SaveChangesAsync()
    {
        await dbContext.SaveChangesAsync();
    }
}