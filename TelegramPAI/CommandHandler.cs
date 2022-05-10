namespace TelegramPAI
{
	class CommandHandler // класc для ответа на полученную команду от клиента
	{
		private CommandFactory _commandFactory;
		public CommandHandler(IBot bot, string newMessage)
		{
			_commandFactory = new CommandFactory();

			if(newMessage == null)
				return;
			string commandName = RecognizeCommand(newMessage); // узнать что за команда сейчас пришла

			if(commandName == null)
				return;

			ICommand? command = _commandFactory.CreateCommand(commandName); // если команда в строке есть, то создается новая команда

			if(command == null)
				return;

			command.Execute(newMessage); // исполнение новой команды
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
