// Source: https://www.youtube.com/watch?v=yjUCKSKCQxg

// LastStop : https://youtu.be/yjUCKSKCQxg?si=3STicj5vr1UFFycC&t=439

using Essentials.Services;

namespace Essentials;

public class Program {
	public static void Main(string[] args) {
		var builder = WebApplication.CreateBuilder(args);

		builder.Services.AddTransient<INumbersService, NumbersService>();

		// Scan project for all controllers and register them(plus some other stuff).
		builder.Services.AddControllers();

		var app = builder.Build();

		// When sending request, look at route and invoke appropreate endpoint.
		app.MapControllers();

		app.Run();
	}
}
