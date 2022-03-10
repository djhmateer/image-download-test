using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImageDownloadTest.Pages;

public class PdfModel : PageModel
{

    public IActionResult OnGet()
    {
        // virtual path (our file is outside of the virtual path so can't use this)
        //return File("/secret/sample.pdf", "application/pdf", "foo.pdf");

        var fileName = @"C:\dev\test\image-download-test\image-download-test\secret\sample.pdf";

        // 1. filestream - works as a download
        //FileStream stream = new FileStream(fileName, FileMode.Open);
        //return File(stream, "application/pdf", "foo.pdf");

        // 2. bytearray - works as a download
        //var bytes = System.IO.File.ReadAllBytes(fileName);
        //return File(bytes, "application/pdf", "foo.pdf");
        // notice constant for application types
        //return File(bytes, MediaTypeNames.Application.Pdf, "foo.pdf");

        // 3. opens pdf view 
        FileStream stream = new FileStream(fileName, FileMode.Open);
        return new FileStreamResult(stream, "application/pdf");
    }
}