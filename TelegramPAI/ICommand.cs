namespace TelegramPAI
{
	interface ICommand // интерфейс для всех команд бота
	{
		public CommandResultDto Execute(string input, LinksStorage _linksStorage); ///Метод для выполнения команды
	}
}
