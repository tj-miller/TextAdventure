using System.Configuration;

namespace TextAdventure.WindowsGame.Configuration
{
	public class WorldTimeConfigurationSection : ConfigurationSection, IWorldTimeConfiguration
	{
		[ConfigurationProperty("visible", IsRequired = false, DefaultValue = false)]
		public bool Visible
		{
			get
			{
				return (bool)this["visible"];
			}
			set
			{
				this["visible"] = value;
			}
		}

		public override bool IsReadOnly()
		{
			return false;
		}
	}
}