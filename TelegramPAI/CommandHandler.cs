namespace TelegramPAI
{
	class CommandHandler // класc для ответа на полученную команду от клиента
	{
		private CommandFactory _commandFactory;
		private CommandRepository<ICommand> _commandRepository;
		private Dictionary<long, LinksStorage> _userStorage;
		public CommandHandler()
		{
			_commandFactory = new CommandFactory();
			_commandRepository = new CommandRepository<ICommand>();
			_userStorage = new Dictionary<long, LinksStorage>();
		}

		public bool HandleCommand(ref CommandResult commandResult, string newMessage, long userid)
		{
			Console.WriteLine(userid);
			var argsList = newMessage.Split(" ", StringSplitOptions.RemoveEmptyEntries);
			if(_commandRepository.HasActiveCommand(userid))
			{
				var command = _commandRepository.GetItem(userid);
				if(command == null)
					return false;
				commandResult = command.Execute(newMessage, _userStorage[userid]);
				return true;
			}
			var newCommand = _commandFactory.CreateCommand(RecognizeCommand(argsList[0]));
			if(newCommand == null)
				return false;

			if (!_userStorage.ContainsKey(userid))
				_userStorage.Add(userid, new LinksStorage());
			_commandRepository.Create(newCommand, userid);
			commandResult = newCommand.Execute(newMessage, _userStorage[userid]);
			return true;
		}

		private string RecognizeCommand(string commandToRecognize) //метод для распознания команды из аргумениа
		{
			if(commandToRecognize.Contains("/storelink"))
				return "/storelink";
			if(commandToRecognize.Contains("/getlinks"))
				return "/getlinks";
			return "";
		}
	}


}
