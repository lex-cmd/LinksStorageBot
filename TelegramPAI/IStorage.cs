namespace TelegramPAI
{
	interface IStorage // интерфейс для хранения объектов
	{
		public void GetEntity(); //метод для получения объекта
		public bool StoreEntity(string args); //метод для сохранения объекта
		public void GetEntityList(); //метод для получения списка объектов
	}
}
