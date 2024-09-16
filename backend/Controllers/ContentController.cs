using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace Backend.Controllers;

using Model;

[ApiController]
[Route("content")]
[EnableCors("main")]
public class ContentController(StreamingDBContext ctx) : ControllerBase
{
    [HttpPost("upload")]
    public async Task<IActionResult> Upload(List<IFormFile> files)
    {
        var file = files[0];
        if (file == null || file.Length == 0)
            return BadRequest("Nenhum arquivo enviado.");

        var crrdir = Directory.GetCurrentDirectory();
        var path = Path.Combine(crrdir, "Uploads", file.FileName);
        var name = Path.GetDirectoryName(path)!;
        Directory.CreateDirectory(name);

        using var stream = new FileStream(path, FileMode.Create);
        await file.CopyToAsync(stream);

        return Ok(new { FilePath = path });
    }


    [HttpGet("content/{id}")]
    public async Task<IActionResult> getContent(Guid id)
    {
        var content = await ctx.Contents.FindAsync(id);

        if (content == null)
            return NotFound();
        
        return File(content.Bytes, "application/octet-stream");
    }
}