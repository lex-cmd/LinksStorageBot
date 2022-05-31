using TelegramPAI;

TelegramApi telegramApi = new TelegramApi();
PaiBot bot = new PaiBot();
CommandHandler commandHandler = new CommandHandler();

telegramApi.Listening();

while(true)
{
	if(telegramApi.IsMessageReceived())
	{
		CommandResult commandResult = null;
		commandHandler.HandleCommand(ref commandResult, telegramApi.GetMessage());
		if(commandResult != null)
			telegramApi.SendMessage(commandResult.Result());
		else
		{
			telegramApi.SendMessage("Type /storelink or /getlinks");
		}
	}
	Thread.Sleep(1000);
}