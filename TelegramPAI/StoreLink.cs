namespace TelegramPAI
{
	internal class StoreLink : ICommand // класс для команды store-link
	{
		public void Execute(string input) // метод для выполнения команды
		{
			Console.WriteLine("Сейчас выполняется store-link:" + input);
		}
	}
}
