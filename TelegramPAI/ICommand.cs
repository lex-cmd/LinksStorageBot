namespace TelegramPAI
{
	interface ICommand // интерфейс для всех команд бота
	{
		public CommandResultDto Execute(string input); ///Метод для выполнения команды
	}
}
