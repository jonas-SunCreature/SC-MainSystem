using System.ComponentModel.DataAnnotations;

namespace Entities.AssetManagerSystem
{
    public class AssetDetails
    {
        public int Id { get; set; }

        [Key]
        [Required]
        [StringLength(255)]
        [Display(Name = "Asset Type")]
        public AssetType AssetType { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Asset Details")]
        public string AssetDetail { get; set; }
    }
}