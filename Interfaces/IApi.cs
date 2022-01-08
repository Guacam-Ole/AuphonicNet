using AuphonicApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AuphonicApi
{
    public interface IApi
    {
        Task<Response<T>> GetRequest<T>(string path);

        Task<Response<T>> PostRequest<T>(string path, Dictionary<string, object> parameters);

        Task UploadMultipartFile(string path, string fileName, byte[] data);
    }
}