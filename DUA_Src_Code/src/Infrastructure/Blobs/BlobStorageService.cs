namespace DUAStreamliner.Infrastructure.Blobs;

public sealed class BlobStorageService
{
    public Task RegisterUploadMetadataAsync(string logicalPath, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> OpenReadAsync(string logicalPath, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
