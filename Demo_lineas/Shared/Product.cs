using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_lineas.Shared
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Brand { get; set; } = string.Empty;
        [StringLength(50)]
        public string Description { get; set; } = string.Empty;
        [StringLength(50)]
        public string Variety { get; set; } = string.Empty;
        [StringLength(250)]
        public string ImageUrl { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Weight { get; set; }

    }

}
