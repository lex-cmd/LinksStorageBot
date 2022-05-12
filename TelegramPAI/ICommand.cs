namespace TelegramPAI
{
	interface ICommand // интерфейс для всех команд бота
	{
		public string Execute(string input); ///Метод для выполнения команды
	}
}
