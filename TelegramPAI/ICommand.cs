namespace TelegramPAI
{
	interface ICommand // интерфейс для всех команд бота
	{
		public CommandResult Execute(string input, LinksStorage linksStorage);
	}
}
