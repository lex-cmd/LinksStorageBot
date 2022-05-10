namespace TelegramPAI
{
	internal class GetLinks : ICommand // класс для команды get-links
	{
		public void Execute(string input) // метод для выполнения команды
		{
			Console.WriteLine("Сейчас выполняется get-links:" + input);
		}
	}
}
