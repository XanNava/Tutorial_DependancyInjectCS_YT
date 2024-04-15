using Essentials.Services;

using Microsoft.AspNetCore.Mvc;

namespace Essentials.Controller;

[ApiController]
[Route("[controller]")]
public class NumbersController : ControllerBase {
	private INumbersService _numbers;

	public NumbersController(INumbersService numbers) {
		_numbers = numbers;
	}

	[HttpGet]
	public IActionResult GetNumber() {
		return Ok(_numbers.GetNumber());
	}
}
