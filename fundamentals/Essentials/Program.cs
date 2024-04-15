// Source:https://www.youtube.com/watch?v=yjUCKSKCQxg

// LastStop:https://youtu.be/yjUCKSKCQxg?si=UfpJ6TFZnMHKs6RH&t=791

using Essentials.Services;

namespace Essentials;

public class Program {
	public static void Main(string[] args) {
		var builder = WebApplication.CreateBuilder(args);
		{
			builder.Services.AddTransient<INumbersService, NumbersService>();

			// Scan project for all controllers and register them(plus some other stuff).
			builder.Services.AddControllers();
		}


		var app = builder.Build();
		{
			app.MapControllers();

			app.Run();
		}

		// When sending request, look at route and invoke appropreate endpoint.


		//ServiceCollection services = [];

		//services.AddTransient<NumbersService>();

		//var ServiceProvider = services.BuildServiceProvider();

		//var controller = ServiceProvider.GetRequiredService<NumbersService>();

		//controller.GetNumber().Dump();
	}
}
