namespace TelegramPAI
{
	internal class StoreLink : ICommand // класс для команды store-link
	{
		public string Execute(string input) // метод для выполнения команды
		{
			return "Сейчас выполняется store-link:" + input;
		}
	}
}
