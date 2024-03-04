using DotnetCore.Interfaces;
using DotnetCore.Models;
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
	public List<Product> Get() {
		return service.GetAll().ToList();
	}

	[HttpGet("{id}")]
	public async Task<Product> Get(int id) {
		return await service.GetOne(id);
	}
}
