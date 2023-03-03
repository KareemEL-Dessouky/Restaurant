namespace Restaurant.Helper;

public class FileUploader
{
    private readonly IWebHostEnvironment _environment;

    public FileUploader(IWebHostEnvironment webHostEnvironment)
    {
        //_fileDestinationPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", pathFromUser);
        _environment = webHostEnvironment;
    }

    public string Upload(IFormFile file)
    {
        if (file == null || file.Length == 0)
            throw new ArgumentException("Please select a file", nameof(file));
        string uploadDirectory = Path.Combine(_environment.WebRootPath, "Images");

        // create the Images dir if not existed
        if (!Directory.Exists(uploadDirectory))
            Directory.CreateDirectory(uploadDirectory);

        string fileName = $"{Guid.NewGuid().ToString()}-{file.FileName}";
        string filePath = Path.Combine(uploadDirectory, fileName);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            file.CopyTo(stream);
        }

        return fileName;
    }
}
