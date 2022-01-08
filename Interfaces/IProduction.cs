using AuphonicApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AuphonicApi
{
    public interface IProduction
    {
        Task AddFileToProduction(string production, string filename, byte[] filecontent);
        Task<Response<Models.Production>> CreateFromPreset(string preset, Metadata metadata, List<Chapter> chapters = null);
        Task<Response<Models.Production>> CreateFromPreset(string preset, string title);
        Task<Response<Models.Production>> StartProduction(string production);
    }
}