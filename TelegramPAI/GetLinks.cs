namespace TelegramPAI
{
	internal class GetLinks : ICommand // класс для команды get-links
	{
		private bool isSecond = false;
		public CommandResult Execute(string input, LinksStorage linksStorage) // метод для выполнения команды
		{
			if(isSecond)
			{
				if(input.ToLower() == "all")
				{
					return new CommandResult(linksStorage.GetEntityListToString());
				}
				var found = linksStorage.FindNameCategory(input);
				if(found != null)
					return new CommandResult(found.GetLinksToString());
			}
			isSecond = true;

			return new CommandResult("Category name - links in category\nAll - all links");
		}
	}
}
