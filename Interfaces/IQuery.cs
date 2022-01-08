using System.Collections.Generic;
using System.Threading.Tasks;

namespace AuphonicApi
{
    public interface IQuery
    {
        Task<Models.Response<Models.Preset>> GetPresetAsync(string uuid);
        Task<Models.Response<List<Models.Preset>>> GetPresetsAsync();
        Task<Models.Response<Models.Production>> GetProductionAsync(string uuid);
        Task<Models.Response<List<Models.Production>>> GetProductionsAsync();
        Task<Models.Response<Models.User>> GetUserAsync();
    }
}