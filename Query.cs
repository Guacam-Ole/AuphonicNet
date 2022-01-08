using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AuphonicApi
{
    public class Query : IQuery
    {
        private readonly IApi _api=new Api();

        

        public async Task<Models.Response<Models.User>> GetUserAsync()
        {
            return await _api.GetRequest<Models.User>("user.json");
        }

        public async Task<Models.Response<Models.Preset>> GetPresetAsync(string uuid)
        {
            return await _api.GetRequest<Models.Preset>( $"preset/{uuid}.json");
        }

        public async Task<Models.Response<List<Models.Preset>>> GetPresetsAsync()
        {
            return await _api.GetRequest<List<Models.Preset>>($"presets.json");
        }

        public async Task<Models.Response<Models.Production>> GetProductionAsync(string uuid)
        {
            return await _api.GetRequest<Models.Production>( $"production/{uuid}.json");
        }

        public async Task<Models.Response<List<Models.Production>>> GetProductionsAsync()
        {
            return await _api.GetRequest<List<Models.Production>>( $"productions.json");
        }

     

     
    }
}