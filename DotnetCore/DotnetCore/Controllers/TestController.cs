using Microsoft.AspNetCore.Mvc;

namespace DotnetCore.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase {
	private readonly ILogger<TestController> _logger;

	public TestController(ILogger<TestController> logger) {
		_logger = logger;
	}
}
