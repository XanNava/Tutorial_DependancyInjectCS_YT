namespace Essentials.Services;

public class NumbersService : INumbersService {
	private readonly int _number = new Random().Next(0, 100);
	public int GetNumber() {
		return _number;
	}
}

public interface INumbersService {
	int GetNumber();
}
