namespace TelegramPAI
{
	class CommandHandler // класc для ответа на полученную команду от клиента
	{
		private CommandFactory _commandFactory;
		private CommandRepository<ICommand> _commandRepository;
		public CommandHandler()
		{
			_commandFactory = new CommandFactory();
			_commandRepository = new CommandRepository<ICommand>();
		}

		public void Execute(IBot bot, string newMessage)
		{

			if(newMessage == null)
				return;

			if(_commandRepository.HasActiveCommand()) // проверяется есть ли сейчас активная команда и выполняет её
			{
				var actCommand = _commandRepository.GetCommand(bot.Id);
				_commandRepository.Delete(bot.Id);
				bot.ResponseToChat(actCommand.Execute(newMessage));
				bot.IsResponseSent = false;
			}
			else
			{
				string commandName = RecognizeCommand(newMessage); // узнать что за команда сейчас пришла

				if(commandName == null)
					return;

				ICommand? command = _commandFactory.CreateCommand(commandName); // если команда в строке есть, то создается новая команда

				_commandRepository.Create(command, bot.Id);

				if(command == null)
					return;

				string commandResult = command.Execute(newMessage);

				bot.ResponseToChat(commandResult);
				bot.IsResponseSent = false;
			}
		}

		private string RecognizeCommand(string commandToRecognize) //метод для распознания команды из аргумениа
		{
			if(commandToRecognize.Contains("/store-link"))
				return "/store-link";
			if(commandToRecognize.Contains("/get-links"))
				return "/get-links";
			return "";
		}
	}
}
