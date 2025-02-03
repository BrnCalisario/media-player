namespace CleanArch.Application.Features.File;

using CleanArch.Domain;
using MediatR;

public sealed record CreateFileCommand(
    string Name,
    string ContentType
) : IRequest<BlobFile>;