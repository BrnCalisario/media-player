using CleanArch.Domain;
using MediatR;

namespace CleanArch.Application.Features.File;

public sealed record GetFileByIdQuery(Guid Id) : IRequest<BlobFile?>;
