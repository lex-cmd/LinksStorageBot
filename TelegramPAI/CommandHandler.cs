namespace TelegramPAI
{
	class CommandHandler // класc для ответа на полученную команду от клиента
	{
		private CommandFactory _commandFactory;
		private CommandRepository<ICommand> _commandRepository;
		private LinksStorage _linksStorage;
		public CommandHandler()
		{
			_commandFactory = new CommandFactory();
			_commandRepository = new CommandRepository<ICommand>();
			_linksStorage = new LinksStorage();
		}

		public void HandleCommand(ref CommandResult commandResult, string newMessage)
		{
			var argsList = newMessage.Split(" ", StringSplitOptions.RemoveEmptyEntries);

			if (_commandRepository.HasActiveCommand())
			{
				commandResult = _commandRepository.GetItem().Execute(newMessage, _linksStorage);
				_commandRepository.SetInactive();
				return;
			}
				var newCommand = _commandFactory.CreateCommand(RecognizeCommand(argsList[0]));
				if(newCommand == null)
					return;
				_commandRepository.Create(newCommand);
				commandResult = newCommand.Execute(newMessage, _linksStorage);
				_commandRepository.SetActive();
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
