using System;

using Junior.Common;

namespace TextAdventure.Engine.Objects
{
	public class Actor : IActor
	{
		private readonly Guid _id;
		private Character _character;

		public Actor(
			Guid id,
			Character character)
		{
			character.ThrowIfNull("character");

			_id = id;
			Character = character;
		}

		public Character Character
		{
			get
			{
				return _character;
			}
			set
			{
				value.ThrowIfNull("value");

				_character = value;
			}
		}

		public Guid Id
		{
			get
			{
				return _id;
			}
		}
	}
}