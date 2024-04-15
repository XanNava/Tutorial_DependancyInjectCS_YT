

namespace fundamentals;

internal class GithubService {
	private IGithubClient _client;
	public GithubService() {
	}

	internal object GetStars(string repoName) {
		return new GithubClient().GetRepo(repoName).Stars;
	}
}

internal class GithubClient : IGithubClient {

	public (string repoName, int Stars) GetRepo(string repoName) {
		return (repoName, repoName.Length);
	}
}

public interface IGithubClient {
	(string repoName, int Stars) GetRepo(string repoName);
}