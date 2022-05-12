namespace TelegramPAI
{
	internal class GetLinks : ICommand // класс для команды get-links
	{
		public string Execute(string input) // метод для выполнения команды
		{
			return "Сейчас выполняется get-links:" + input;
		}
	}
}
