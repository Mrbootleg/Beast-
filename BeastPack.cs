using Terraria.ModLoader;

namespace BeastPack
{
	class BeastPack : Mod
	{
		public BeastPack()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
