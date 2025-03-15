namespace CsvFileMongoDb.Core.Domains.Files.Entities;

public class File
{
    public Guid Id { get; private set; }
    public string Url { get; private set; }
    public string Format { get; private set; }

    public File(string url, string format)
    {
        Id = Guid.NewGuid();
        Url = url;
        Format = format;
    }
}
