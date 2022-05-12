using Telegram.Bot.Types;

namespace TelegramPAI
{
	internal class PaiBot : IBot //основной класс программы для работы с любым чатом
	{
		private string _responseString;
		public long? Id { get; set; }
		public bool IsResponseSent { get; set; }

		public PaiBot()
		{
			IsResponseSent = false;
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
			if(!IsResponseSent)
			{
				Console.WriteLine(_responseString);
			}
			IsResponseSent = true;
		}
		public void Start(string[] args) //запуск основной программы
		{

		}

		public void Stop() //остановка основной программы
		{

		}

		public void ResponseToChat(string responseString) //метод для отправки сообщения
		{
			this._responseString = responseString;
		}

	}
}
