namespace Essentials.Client;


public class NumbersClient {
	public int GetNumber() {
		return new Random().Next(0, 100);
	}
}