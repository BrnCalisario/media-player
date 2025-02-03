using CleanArch.Domain;
using MediatR;

namespace CleanArch.Application.Features.File;

public class CreateFileCommandHandler : IRequestHandler<CreateFileCommand, BlobFile>
{
    private readonly IBlobFileRepository blobFileRepository;

    public CreateFileCommandHandler(IBlobFileRepository blobFileRepository)
    {
        this.blobFileRepository = blobFileRepository;
    }

    public async Task<BlobFile> Handle(CreateFileCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        var blobFile = new BlobFile
        {
            Name = request.Name,
            ContentType = request.ContentType,
        };

        await blobFileRepository.CreateAsync(blobFile);
        await blobFileRepository.SaveChangesAsync();

        return blobFile;
    }
}