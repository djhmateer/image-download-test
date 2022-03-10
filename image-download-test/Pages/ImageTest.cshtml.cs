using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImageDownloadTest.Pages;

public class ImageModel : PageModel
{
    // jpg
    public IActionResult OnGet()
    {
        var fileName = @"C:\dev\test\image-download-test\image-download-test\secret\image.jpg";

        // 3. opens chrome image viewer 
        FileStream stream = new FileStream(fileName, FileMode.Open);
        return new FileStreamResult(stream, MediaTypeNames.Image.Jpeg);
        //return new FileStreamResult(stream, "image/jpeg");
    }

    // png
    //public IActionResult OnGet()
    //{
    //    var fileName = @"C:\dev\test\image-download-test\image-download-test\secret\image.png";

    //    // 3. opens chrome image viewer 
    //    FileStream stream = new FileStream(fileName, FileMode.Open);
    //    return new FileStreamResult(stream, "image/png");
    //}

    // tif - not supported anymore to view https://stackoverflow.com/a/2177012/26086
    //public IActionResult OnGet()
    //{
    //    var fileName = @"C:\dev\test\image-download-test\image-download-test\secret\image.tiff";

    //    // 3. opens chrome image viewer 
    //    FileStream stream = new FileStream(fileName, FileMode.Open);
    //    return new FileStreamResult(stream, MediaTypeNames.Image.Tiff);
    //    //return new FileStreamResult(stream, "image/png");
    //}
}