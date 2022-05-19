namespace TelegramPAI
{
	interface IBot //интерфейс для работы бота
	{
		public void NewMessageReceived(); //метод для получения новой строки для обработки
		public void ResponseToChat(CommandResultDto response); //метод для отправки сообщения
		public void Start(string[] args); //запуск бота
		public void Start();
		public void Stop(); //остановка бота
	}
}
