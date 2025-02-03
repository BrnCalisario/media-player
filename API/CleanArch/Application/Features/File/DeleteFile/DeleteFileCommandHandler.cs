using CleanArch.Domain;
using MediatR;

namespace CleanArch.Application.Features.File;

public sealed record DeleteFileCommandHandler : IRequestHandler<DeleteFileCommand, BlobFile>
{
    private readonly IBlobFileRepository repository;
    
    public DeleteFileCommandHandler(IBlobFileRepository repository)
    {
        this.repository = repository;
    }

    public async Task<BlobFile> Handle(DeleteFileCommand request, CancellationToken cancellationToken)
    {
        var deleted = await repository.DeleteAsync(request.Id);
        
        await repository.SaveChangesAsync();

        return deleted;
    }
}