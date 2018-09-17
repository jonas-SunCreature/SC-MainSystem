using Entities.AssetManagerSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sun_Creature_AMS.ViewModels
{
    public class AssetsViewModel
    {
        public IEnumerable<Asset> Assets { get; set; }
        public NewAssetViewModel NewAssetViewModel { get; set; }
    }
}