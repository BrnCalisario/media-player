using CleanArch.Application.Features.File;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Presentation;

[Route("api/[controller]")]
public class FileController : ControllerBase
{
    private readonly ISender sender;

    public FileController(ISender sender)
    {
        this.sender = sender;
    }

    [HttpPost]
    public async Task<ActionResult> CreateFile(IFormFile file)
    {
        var command = new CreateFileCommand(file.FileName, file.ContentType);

        var resultFile = await sender.Send(command);

        return Ok(resultFile);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult> GetFile(Guid id)
    {
        var file = await sender.Send(new GetFileByIdQuery(id));

        if (file == null) 
        {
            return NotFound();
        }

        return Ok(file);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteFile(Guid id)
    {
        var deleted = await sender.Send(new DeleteFileCommand(id));
        return Ok(deleted);
    }

}