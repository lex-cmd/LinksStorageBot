namespace TelegramPAI
{
	internal class PaiBot
	{
		public PaiBot()
		{
		}

		private Dictionary<string, Category> Categories { get; set; }; // мапа для хранения категорий и ссылок

		private Commands commands; //класс для исполнения команд

		private static ITelegramBotClient bot = new TelegramBotClient("TOKEN"); //сохранения токена бота

		public static void Start()
		{
			//запуск бота, получение обновлений
		}
		public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
		{
			//для ошибок
		}

		public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
		{
			//обработка новых входящих сообщений от пользователя
			//выполнение основного кода программы, все команды, сохранение и вывод категорий происходит тут
		}
	}
}
