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

		public int Execute(IBot bot, string newMessage, long? userId)
		{
			CommandResultDto _result = null;

			if(newMessage == null)
				return -1;
			if(_commandRepository.HasActiveCommand(userId)) // проверяется есть ли сейчас активная команда у пользователя и выполняет её
			{
				var actCommand = _commandRepository.GetCommand(userId);
				_result = actCommand.Execute(newMessage);
			}
			else
			{
				var commandName = RecognizeCommand(newMessage); // узнать что за команда сейчас 
				if(commandName == null)
				{
					Console.WriteLine("Error commandName");
					return -1;
				}

				ICommand? command = _commandFactory.CreateCommand(commandName); // если команда в строке есть, то создается новая команда
				if(command == null)
				{
					Console.WriteLine("Error command");
					return -1;
				}
				_result = command.Execute(newMessage);
				_commandRepository.Create(command, userId); // добавление в репозиторий новой команды и id пользователя
			}
			if(_result == null)
			{
				return -1;
			}
			bot.ResponseToChat(_result);
			bot.Start(); // запуск бота
			return 0;
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
