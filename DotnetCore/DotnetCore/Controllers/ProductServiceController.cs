using DotnetCore.Interfaces;
using DotnetCore.Models;
using DotnetCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCore.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductServiceController : ControllerBase {
	private readonly ILogger<ProductServiceController> _logger;
	private readonly IProductService service;

	public ProductServiceController(ILogger<ProductServiceController> logger, IProductService service) {
		_logger = logger;
		this.service = service;
	}

	[HttpGet]
	public async Task<List<Product>> Get() {
		return service.GetAll().ToList();
	}
}
