namespace TelegramPAI
{
	internal class StoreLink : ICommand // класс для команды store-link
	{
		private bool isSecond = false;
		public CommandResult Execute(string input, LinksStorage linksStorage) // метод для выполнения команды
		{
			if(isSecond)
			{
				if(!linksStorage.StoreEntity(input))
					return new CommandResult("Error argument! Tips: Category Link");
				//	Console.WriteLine("level two");
				isSecond = false;
				return new CommandResult("Link saved");
			}
			isSecond = true;

			return new CommandResult("Type: Category Link");
		}

	}
}
