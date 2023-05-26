using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace URALSIB.Models
{
    public class GitHubService
    {
        private readonly HttpClient _httpClient;

        public GitHubService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Commit>> GetCommits(string owner, string repo, string token)
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

            var apiUrl = $"https://api.github.com/repos/{owner}/{repo}/commits";
            var response = await _httpClient.GetStringAsync(apiUrl);
            var commits = JsonConvert.DeserializeObject<List<Commit>>(response);

            return commits;
        }
    }
}
