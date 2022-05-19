namespace TelegramPAI
{
	internal class Application
	{
		public void Start()
		{
			PaiBot paiBot = new PaiBot();
			TelegramApi telegramApi = new TelegramApi();

			telegramApi.Listening(); // запуск прослушивания новых обновлений от сервера

			var commandHandler = new CommandHandler();
			while(true)
			{
				if (telegramApi.IsMessageReceived())
				{
					long? userId = telegramApi.GetUserId();
					commandHandler.Execute(paiBot, telegramApi.GetMessage(), userId); // запуск основной работы команд
				}
				Thread.Sleep(1000); //задержка 1 сек
			}
		}
	}
}
