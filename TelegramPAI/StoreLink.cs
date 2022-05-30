namespace TelegramPAI
{
	internal class StoreLink : ICommand // класс для команды store-link
	{
		public CommandResultDto Execute(string input) // метод для выполнения команды
		{
			return new CommandResultDto("Сейчас выполняется storelink, input: " + input);
		}
	}
}
