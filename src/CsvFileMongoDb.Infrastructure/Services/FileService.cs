using CsvFileMongoDb.Infrastructure.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using FileEntity = CsvFileMongoDb.Core.Domains.Files.Entities.File;

namespace CsvFileMongoDb.Infrastructure.Services;

public class FileService : IFileService
{
    private readonly IConfiguration _configuration;

    public FileService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public Task<FileEntity> GetFileAsync()
    {
        throw new NotImplementedException();
    }

    public Task SaveFileAsync(IFormFile file)
    {
        throw new NotImplementedException();
    }

    private string GetFileFormat(string fullFileName)
    {
        string format = fullFileName.Split('.').Last();
        return '.' + format;
    }

    private string GenerateNewFileName(string fileName)
    {
        string newFileName = (Guid.NewGuid().ToString() + '_' + fileName).ToLower();
        return newFileName.Replace("-", "");
    }

    private string CreateFilePath(string fileName)
        => Path.Combine(Directory.GetCurrentDirectory(), _configuration["Directories:Files"]!, fileName);

    private string GetFileUrl(string fileName)
    {
        string baseUrl = _configuration["Directories:BaseUrl"]!;
        string filePath = _configuration["Directories:Files"]!;

        return $"{baseUrl}/{filePath}/{fileName}";
    }

    private byte[] ConverFileInByteArray(IFormFile file)
    {
        using (MemoryStream memoryStream = new())
        {
            file.CopyTo(memoryStream);
            return memoryStream.ToArray();
        }
    }
}
