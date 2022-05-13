namespace TelegramPAI
{
	class CommandHandler // класc для ответа на полученную команду от клиента
	{
		private CommandFactory _commandFactory;
		private CommandRepository<ICommand> _commandRepository;
		private CommandResultDto _result;
		private CommandResultDtoFactory _resultFactory;
		public CommandHandler()
		{
			_commandFactory = new CommandFactory();
			_commandRepository = new CommandRepository<ICommand>();
			_result = new CommandResultDto();
		}

		public int Execute(IBot bot, string newMessage)
		{
			if(newMessage == null)
				return -1;
			Console.WriteLine("user id: " + bot.UserId);
			if(_commandRepository.HasActiveCommand(bot.UserId)) // проверяется есть ли сейчас активная команда у пользователя и выполняет её
			{
				var actCommand = _commandRepository.GetCommand(bot.UserId);
				_result = actCommand.Execute(newMessage);
				_commandRepository.Delete(bot.UserId);
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

				_commandRepository.Create(command, bot.UserId); // добавление в репозиторий новой команды и id пользователя
				_result = command.Execute(newMessage);
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
