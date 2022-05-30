namespace TelegramPAI
{
	internal class CommandFactory //класс для создания новых команд
	{
		public CommandFactory()
		{

		}

		public ICommand CreateCommand(string commandName)
		{
			//метод для создания новой команды, возвращает новый объект команды
			switch(commandName)
			{
				case "/getlinks":
					return new GetLinks();
				case "/storelink":
					return new StoreLink();
			}
			return null;
		}
	}
}
