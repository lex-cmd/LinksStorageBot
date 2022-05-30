namespace TelegramPAI
{
	internal class GetLinks : ICommand // класс для команды get-links
	{
		public CommandResultDto Execute(string input, LinksStorage _linksStorage) // метод для выполнения команды
		{
			return new CommandResultDto("Сейчас выполняется getlinks, input: " + input);
		}

	}
}
