using System.Collections.Generic;
using System.Threading.Tasks;

namespace AuphonicApi
{
    public class Production : IProduction
    {
        private readonly IApi _api = new Api();

        public async Task<Models.Response<Models.Production>> CreateFromPreset(string preset, string title)
        {
            return await CreateFromPreset(preset, new Models.Metadata { Title = title }, null);
        }

        public async Task<Models.Response<Models.Production>> CreateFromPreset(string preset, Models.Metadata metadata, List<Models.Chapter> chapters = null)
        {
            var parameters = new Dictionary<string, object>
            {
                { "preset", preset },
                { "metadata", metadata }
            };
            if (chapters != null)
            {
                parameters.Add("chapters", chapters);
            }

            return await _api.PostRequest<Models.Production>("productions.json", parameters);
        }

        public async Task AddFileToProduction(string production, string filename, byte[] filecontent)
        {
            await _api.UploadMultipartFile($"production/{production}/upload.json", filename, filecontent);
        }

        public async Task<Models.Response<Models.Production>> StartProduction(string production)
        {
            return await _api.PostRequest<Models.Production>($"production/{production}/start.json", null);
        }
    }
}