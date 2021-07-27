using Image_Compression.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Image_Compression.Models;

namespace Image_Compression.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : Controller
    {
       [HttpPost]
        //  public async Task<IActionResult> ImageCompress([FromQuery] string path)
        public async Task<IActionResult> ImageCompress([FromBody] ImageModel imageobj)
        {
            foreach (string path in imageobj.images)
            {
                ImageCompresser imageCompresser = new ImageCompresser();
                byte[] compressedBytes = await imageCompresser.compress(path);
            }
            //return Ok(await imageCompresser.compress(path));
            return Ok("images compressed");
            
        }
    }
}
