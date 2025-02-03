using CleanArch.Domain;
using MediatR;

namespace CleanArch.Application.Features.File;

public class GetFileByIdQueryHandler : IRequestHandler<GetFileByIdQuery, BlobFile?>
{
    private readonly IBlobFileRepository blobFileRepository;

    public GetFileByIdQueryHandler(IBlobFileRepository blobFileRepository)
    {
        this.blobFileRepository = blobFileRepository;
    }

    public async Task<BlobFile?> Handle(GetFileByIdQuery request, CancellationToken cancellationToken)
    {
        var obj = await Task.Run(() => {
            return blobFileRepository.GetById(request.Id).FirstOrDefault();
        });

        return obj;
    }
}