using System.ComponentModel.DataAnnotations;

namespace Entities.AssetManagerSystem
{
    public class AssetType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Type { get; set; }
    }
}