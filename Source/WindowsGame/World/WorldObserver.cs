﻿using Junior.Common;

using TextAdventure.Engine.Game.Commands;
using TextAdventure.Engine.Game.Events;
using TextAdventure.Engine.Game.World;
using TextAdventure.WindowsGame.RendererStates;

namespace TextAdventure.WindowsGame.World
{
	public class WorldObserver : IWorldObserver
	{
		private readonly LogRendererState _logRendererState;
		private readonly WorldTime _worldTime;

		public WorldObserver(WorldTime worldTime, LogRendererState logRendererState)
		{
			worldTime.ThrowIfNull("worldTime");
			logRendererState.ThrowIfNull("logRendererState");

			_worldTime = worldTime;
			_logRendererState = logRendererState;
		}

		public void CommandExecuting(Command command)
		{
			command.ThrowIfNull("command");
		}

		public void CommandExecuted(Command command, CommandResult result)
		{
			command.ThrowIfNull("command");

			_logRendererState.EnqueueCommandExecutedLogEntry(_worldTime.Total, command, result);
		}

		public void EventRaising(Event @event)
		{
			@event.ThrowIfNull("event");

			_logRendererState.EnqueueEventRaisingLogEntry(_worldTime.Total, @event);
		}

		public void EventRaised(Event @event, EventResult result)
		{
			@event.ThrowIfNull("event");

			_logRendererState.EnqueueEventRaisedLogEntry(_worldTime.Total, @event, result);
		}
	}
}