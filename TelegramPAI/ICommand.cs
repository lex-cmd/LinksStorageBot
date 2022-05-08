namespace TelegramPAI
{
	interface ICommand // интерфейс для всех команд бота
	{
		public void Execute(string input); ///Метод для выполнения команды
	}
}
