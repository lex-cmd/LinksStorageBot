namespace TelegramPAI
{
	internal class GetLinks : ICommand // класс для команды get-links
	{
		private bool isSecond = false;
		public CommandResult Execute(string input, LinksStorage linksStorage) // метод для выполнения команды
		{
			if(isSecond)
			{
				if(input.ToLower() == "/all")
				{
					var result = linksStorage.GetEntityListToString();
					if (result == null)
						return new CommandResult("You have zero links");
					return new CommandResult(result);
				}
				var found = linksStorage.FindNameCategory(input);
				if(found != null)
					return new CommandResult(found.GetLinksToString());
			}
			isSecond = true;

			return new CommandResult("Category name - links in category\n/All - all links");
		}
	}
}
