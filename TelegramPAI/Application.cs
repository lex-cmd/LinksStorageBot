namespace TelegramPAI
{
	internal class Application
	{
		public void Start()
		{
			PaiBot paiBot = new PaiBot();
			TelegramApi telegramApi = new TelegramApi();
			paiBot.Id = telegramApi.GetId();

			telegramApi.Listening(); // запуск прослушивания новых обновлений от сервера

			var commandHandler = new CommandHandler();
			while(true)
			{
				commandHandler.Execute(paiBot, telegramApi.GetMessage());
				paiBot.Start(); // получение сообщения если оно есть и запуск бота

				Thread.Sleep(1000); //задержка 1 сек
			}
		}
	}
}
