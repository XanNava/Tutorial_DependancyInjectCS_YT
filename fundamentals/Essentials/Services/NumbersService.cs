namespace Essentials.Services;

public class NumbersService : INumbersService {
	public int GetNumber() {
		return 5;
	}
}

public interface INumbersService {
	int GetNumber();
}
