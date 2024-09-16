using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

using Model;

[ApiController]
[Route("content")]
public class ContentController(StreamingDBContext ctx) : ControllerBase
{
    [HttpGet("content/{id}")]
    public async Task<IActionResult> getContent(Guid id)
    {
        var content = await ctx.Contents.FindAsync(id);

        if (content == null)
            return NotFound();
        
        return File(content.Bytes, "application/octet-stream");
    }
}