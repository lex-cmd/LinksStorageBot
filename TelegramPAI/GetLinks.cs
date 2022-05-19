namespace TelegramPAI
{
	internal class GetLinks : ICommand // класс для команды get-links
	{
		public CommandResultDto Execute(string input) // метод для выполнения команды
		{
			return new CommandResultDto("Сейчас выполняется get-links, input: " + input);
		}

	}
}
