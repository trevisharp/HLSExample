using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace Backend.Controllers;

using Model;

[ApiController]
[Route("content")]
[EnableCors("main")]
public class ContentController : ControllerBase
{
    StreamingDBContext ctx;
    public ContentController(StreamingDBContext ctx)
        => this.ctx = ctx;

    [HttpGet("{id}")]
    public async Task<IActionResult> getContent(Guid id)
    {
        var content = await ctx.Contents.FindAsync(id);

        if (content == null)
            return NotFound();
        
        return File(content.Bytes, "application/octet-stream");
    }
}