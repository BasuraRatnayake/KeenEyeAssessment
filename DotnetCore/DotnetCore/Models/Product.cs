using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetCore.Models;

public class Product {
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public required int Id { get; set; }
	public required string Name { get; set; }
}
