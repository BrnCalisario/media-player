using CleanArch.Domain;
using MediatR;

namespace CleanArch.Application.Features.File;

public sealed record DeleteFileCommand(Guid Id) : IRequest<BlobFile>;