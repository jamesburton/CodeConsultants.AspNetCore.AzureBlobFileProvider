using Microsoft.Azure.Storage.Blob;

namespace CodeConsultants.AspNetCore.AzureBlobFileProvider
{
    public interface IBlobContainerFactory
    {
        CloudBlobContainer GetContainer(string subpath);
        string TransformPath(string subpath);
    }
}
