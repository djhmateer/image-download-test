using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImageDownloadTest.Pages;

public class ImageModel : PageModel
{
    // jpg
    //public IActionResult OnGet()
    //{
    //    var fileName = @"C:\dev\test\image-download-test\image-download-test\secret\image.jpg";

    //    // 3. opens chrome image viewer 
    //    FileStream stream = new FileStream(fileName, FileMode.Open);
    //    return new FileStreamResult(stream, MediaTypeNames.Image.Jpeg);
    //    //return new FileStreamResult(stream, "image/jpeg");
    //}

    // png
    public IActionResult OnGet()
    {
        var fileName = @"C:\dev\test\image-download-test\image-download-test\secret\image.png";

        // 3. opens chrome image viewer 
        FileStream stream = new FileStream(fileName, FileMode.Open);
        return new FileStreamResult(stream, "image/png");
    }
}