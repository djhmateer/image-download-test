using System.IO.Compression;
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


    // Sample code  (Db not implemented here)
    // get bytes out of a db
    // create a zip file
    // delete source files
    // return to browser as a zip then delete zip afterwards
    //public async Task<IActionResult> OnGetAsync()
    //{
    //    // streaming available if ever get issues with large files.
    //    // https://swimburger.net/blog/dotnet/create-zip-files-on-http-request-without-intermediate-files-using-aspdotnet-mvc-razor-pages-and-endpoints?utm_source=twitter&utm_medium=social

    //    DateTime foo = DateTime.Now;
    //    // create a unique folder using milliseconds
    //    long unixTime = ((DateTimeOffset)foo).ToUnixTimeMilliseconds();

    //    // create a directory eg C:\devDave\onlineportal\Portal.Web\wwwroot\generated-images\compliance\1646320579
    //    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\generated-images\\compliance\\" + unixTime + "\\");
    //    var di = Directory.CreateDirectory(path);

    //    var result = await Db.GetComplianceDocumentForApplicantIdAndAttributeType(proNetConn, applicantId, "Identification");
    //    if (result != null)
    //    {
    //        var filename = result.PersonName + result.Surname + "-Identification" + result.DocumentFileExt;
    //        await System.IO.File.WriteAllBytesAsync(path + filename, result.Document);
    //    }

    //    var result2 = await Db.GetComplianceDocumentForApplicantIdAndAttributeType(proNetConn, applicantId, "RightToWork");
    //    if (result2 != null)
    //    {
    //        var filename2 = result2.PersonName + result2.Surname + "-RightToWork" + result2.DocumentFileExt;
    //        await System.IO.File.WriteAllBytesAsync(path + filename2, result2.Document);
    //    }

    //    var result3 = await Db.GetComplianceDocumentForApplicantIdAndAttributeType(proNetConn, applicantId, "SkillsCard");
    //    if (result3 != null)
    //    {
    //        var filename3 = result3.PersonName + result3.Surname + "-SkillsCard" + result3.DocumentFileExt;
    //        await System.IO.File.WriteAllBytesAsync(path + filename3, result3.Document);
    //    }

    //    // create a zip file eg: C:\devDave\onlineportal\Portal.Web\wwwroot\generated-images\compliance\1646320579.zip
    //    // contains the 1 to 3 files above
    //    var compliancePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\generated-images\\compliance\\");
    //    var zipFileName = unixTime + ".zip";
    //    var zipFilePathAndName = compliancePath + zipFileName;
    //    ZipFile.CreateFromDirectory(path, zipFilePathAndName);

    //    // Delete source files
    //    Directory.Delete(path, true);

    //    // Download the zip file and delete afterwards
    //    // https://stackoverflow.com/a/43981710
    //    var fs = new FileStream(zipFilePathAndName, FileMode.Open, FileAccess.Read, FileShare.None, 4096, FileOptions.DeleteOnClose);
    //    return File(fileStream: fs, contentType: MediaTypeNames.Application.Zip, fileDownloadName: zipFileName);
    //}
}