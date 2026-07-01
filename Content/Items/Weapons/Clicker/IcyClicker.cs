using System.Collections.Generic;
using Microsoft.Xna.Framework;
using SOTS.Dusts;
using SOTSClickers.Content.Items.Weapons.Clicker;
using Terraria.ID;
using Terraria.ModLoader;

namespace SOTSClickers.COntent.Items.Weapons.Clicker
{
    public class IcyClicker : SOTSClicker
    {
        public override float RadiusWidth => 1f;
        public override Color RadiusColor => new(187, 199, 225);
        public override int DustType => ModContent.DustType<CopyIceDust>();
        public override List<string>? Effects => ["SOTSClickers:IcyEffect"];
        public override void SafeSetDefaults()
        {
            Item.damage = 1;
            Item.width = 16;
            Item.height = 22;
            Item.rare = ItemRarityID.Green;
        }
    }
}