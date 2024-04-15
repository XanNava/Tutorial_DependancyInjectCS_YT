using Dumpify;

using Microsoft.Extensions.DependencyInjection;

namespace fundamentals;

internal class Program {
	static void Main(string[] args) {
		var SC = new ServiceCollection();

		SC.AddTransient<IGithubClient, GithubClient>();
		SC.AddTransient<GithubService>();

		var SP = SC.BuildServiceProvider();

		var githubService = SP.GetRequiredService<GithubService>();

		githubService.GetStars("throw").Dump("throw has this many stars");
	}
}
