namespace TelegramPAI
{
	interface IBot //интерфейс для работы бота
	{

		void NewMessageReceived(); //метод для получения новой строки для обработки
		void ResponseToChat(); //метод для отправки сообщения
		void Start(string[] args); //запуск бота
		void Stop(); //остановка бота
	}
}
