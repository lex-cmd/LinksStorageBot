namespace TelegramPAI
{
	internal class GetLinks : ICommand // класс для команды get-links
	{
		public CommandResultDto Execute(string input) // метод для выполнения команды
		{
			return CommandResultDtoFactory.CreateResult("Сейчас выполняется get-links, input: " + input);
		}

	}
}
