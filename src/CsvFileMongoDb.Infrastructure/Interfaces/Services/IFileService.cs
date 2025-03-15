using Microsoft.AspNetCore.Http;
using FileEntity = CsvFileMongoDb.Core.Domains.Files.Entities.File;

namespace CsvFileMongoDb.Infrastructure.Interfaces.Services;

public interface IFileService
{
    Task SaveFileAsync(IFormFile file);
    Task<FileEntity> GetFileAsync();
}
