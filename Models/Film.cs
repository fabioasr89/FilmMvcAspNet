using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoAppMVC.Models
{
	public class Film
	{
		public int Id{ get; set; }
		public string? Titolo { get; set; }

		public int Anno { get; set; }
		[Column(TypeName ="decimal(18,2)")]
		public decimal Prezzo { get; set; } 

		public string? Genere { get; set; }

		public string? Regia { get; set; }

	}
}
