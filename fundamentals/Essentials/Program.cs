// Source:https://www.youtube.com/watch?v=yjUCKSKCQxg

// LastStop:https://youtu.be/yjUCKSKCQxg?si=Ddhr4YBxOT6uG124&t=544

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

		//ServiceCollection services = [];

		//services.AddTransient<NumbersService>();

		//var ServiceProvider = services.BuildServiceProvider();

		//var controller = ServiceProvider.GetRequiredService<NumbersService>();

		//controller.GetNumber().Dump();
	}
}
