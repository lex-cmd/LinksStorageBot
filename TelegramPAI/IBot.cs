namespace TelegramPAI
{
	interface IBot //интерфейс для работы бота
	{
		public long? Id { get; set; }
		public bool IsResponseSent { get; set; }


		public void NewMessageReceived(); //метод для получения новой строки для обработки
		public void ResponseToChat(string responseString); //метод для отправки сообщения
		public void Start(string[] args); //запуск бота
		public void Stop(); //остановка бота
	}
}
