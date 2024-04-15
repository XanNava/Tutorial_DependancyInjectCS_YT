using Essentials.Client;

namespace Essentials.Services;

public class NumbersService : INumbersService {

	public NumbersService(NumbersClient numbersClient) {
		_numbersClient = numbersClient;
	}

	private readonly NumbersClient _numbersClient;
	public int GetNumber() {
		return _numbersClient.GetNumber();
	}
}

public interface INumbersService {
	int GetNumber();
}
