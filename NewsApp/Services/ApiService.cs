using Newtonsoft.Json;
using NewsApp.Models;

namespace NewsApp.Services;

public class ApiService
{
	public async Task<Root> GetNews(string categoryName)
	{
		var httpClient = new HttpClient();
		var response = await httpClient.GetStringAsync($"https://gnews.io/api/v4/top-headlines?category={categoryName.ToLower()}&apikey=9a9dc93fc3eea05693f3582846aaa68c=zh");
		return JsonConvert.DeserializeObject<Root>(response);
	}
}