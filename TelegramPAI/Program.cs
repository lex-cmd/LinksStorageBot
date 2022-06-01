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
		commandHandler.HandleCommand(ref commandResult, telegramApi.GetMessage(), telegramApi.GetUserId());
		if(commandResult != null)
			await telegramApi.SendMessage(commandResult.Result());
		else
		{
			await telegramApi.SendMessage("Type /storelink or /getlinks");
		}
	}
	Thread.Sleep(1000);
}	