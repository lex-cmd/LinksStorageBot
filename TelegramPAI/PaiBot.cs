using Telegram.Bot.Types;

namespace TelegramPAI
{
	internal class PaiBot : IBot //основной класс программы для работы с любым чатом
	{
		private string _responseString;
		public long? UserId { get; set; }

		public PaiBot()
		{
		}

		public void NewMessageReceived() //метод для получения новой строки для обработки
		{

		}

		public void Start(Message newMessage) //запуск ответа бота
		{
			if(newMessage == null)
				return;
		}

		public void Start() //запуск ответа бота
		{
				Console.WriteLine(_responseString);
		}
		public void Start(string[] args) //запуск основной программы
		{

		}

		public void Stop() //остановка основной программы
		{

		}

		public void ResponseToChat(CommandResultDto response) //метод для форматирования и отправки сообщения
		{
			this._responseString = response.Format();
		}

	}
}
