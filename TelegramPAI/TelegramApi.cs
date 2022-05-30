using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;


namespace TelegramPAI
{

	internal class TelegramApi // подключение API Telegram
	{
		private const string _TOKEN = "5397291530:AAEUVbGJymnyBsaoLuS4aDRzueXWB69e2xE"; //токен телеграм бота

		private static readonly ITelegramBotClient _bot = new TelegramBotClient(_TOKEN);
		private static CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
		private static CancellationToken _cancellationToken = _cancellationTokenSource.Token;
		private static Message _messageSaver = new Message();
		private static User _user;
		private static bool _isMessage { get; set; }

		public TelegramApi()
		{
			_isMessage = false;
		}

		// метод для прослушивания сообщений клиента
		public void Listening()
		{
			var receiverOptions = new ReceiverOptions
			{
				AllowedUpdates = { }, // receive all update types
			};
			_bot.StartReceiving(UpdateHandlerAsync, ErrorHandlerAsync, receiverOptions, _cancellationToken);
		}

		// получение новых сообщений от клиента
		public static async Task UpdateHandlerAsync(ITelegramBotClient bot, Update update, CancellationToken cancellationToken)
		{
			//Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
			if(update.Type == UpdateType.Message)
			{
				_messageSaver = update.Message;
				_user = _messageSaver.From;
				_isMessage = true;
			}
		}

		// вывод ошибок в консоль
		public static async Task ErrorHandlerAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
		{
			Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
		}

		public bool IsMessageReceived()
		{
			return _isMessage;
		}
		public long? GetUserId() //получение списка пользователей
		{
			if(!_isMessage)
				return null;
			return _user.Id;
		}

		public string GetMessage()
		{
			if(!_isMessage)
				return null;
			_isMessage = false;
			return _messageSaver.Text;
		}
	}
}
