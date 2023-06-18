using Terraria;
using Terraria.ModLoader;

namespace TheConfectionRebirth.ModSupport.Thorium.Buffs.NeapoliniteBuffs {
	public class YumdropKissIV : ModBuff {
		public Mod thorium;
		public override bool IsLoadingEnabled(Mod mod) {
			return ModLoader.TryGetMod("ThoriumMod", out thorium);
		}
		public override void SetStaticDefaults() {
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		[JITWhenModsEnabled("ThoriumMod")]
		public override void Update(Player player, ref int buffIndex) {
			if (ModLoader.TryGetMod("ThoriumMod", out Mod source) && source.TryFind("HealerDamage", out DamageClass damageClass)) {
				ThoriumMod.ThoriumPlayer thoriumPlayer = player.GetModPlayer<ThoriumMod.ThoriumPlayer>();
				player.GetDamage(damageClass) += 0.04f;
				player.GetCritChance(DamageClass.Generic) += 8f;
				thoriumPlayer.healBonus += 4;
			}
		}
	}
}
