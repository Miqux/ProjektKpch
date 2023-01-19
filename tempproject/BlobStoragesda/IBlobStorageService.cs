using tempproject.Models;

namespace tempproject.BlobStoragesda
{
    public interface IBlobStorageService
    {
        Task<List<BlobStorage>> GetAllBlobFiles();
        Task UploadBlobFileAsync(IFormFile files);
        Task DeleteDocumentAsync(string blobName);
    }
}
