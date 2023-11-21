using NewsApp.Models;
namespace NewsApp.Pages;
using NewsApp.Services;

public partial class NewsListPage : ContentPage
{
	public List<Article> ArticleList;
	public NewsListPage(string categoryName)
	{
		InitializeComponent();
		Title = categoryName;
		GetNews(categoryName);
		ArticleList = new List<Article>();
	}

	private async void GetNews(string categoryName)
	{
        var apiService = new ApiService();
        var articles = await apiService.GetNews(categoryName);
        foreach (var article in articles.Articles)
		{
            ArticleList.Add(article);
        }
        CvNews.ItemsSource = ArticleList;
    }
}