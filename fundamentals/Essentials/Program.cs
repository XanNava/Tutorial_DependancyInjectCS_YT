// Source:https://www.youtube.com/watch?v=yjUCKSKCQxg

// LastStop:https://youtu.be/yjUCKSKCQxg?si=PfCLWFjVlsl2I-MR&t=1116

using Essentials.Client;
using Essentials.Services;

namespace Essentials;

public class Program {
	public static void Main(string[] args) {
		var builder = WebApplication.CreateBuilder(args);
		{
			builder.Services.AddSingleton<INumbersService, NumbersService>();
			builder.Services.AddSingleton<NumbersClient>();

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
