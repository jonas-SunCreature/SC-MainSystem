using Entities.AssetManagerSystem;
using Sun_Creature_AMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sun_Creature_AMS.ViewModels
{
    public class NewAssetViewModel
    {
        public IEnumerable<AssetDetails> AssetDetails { get; set; }
        public Asset Asset { get; set; }
    }
}