using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Entities.AssetManagerSystem
{
    public class Asset
    {
        public int Id { get; set; }

        public AssetDetails Details { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public bool Available { get; set; }

    }
}