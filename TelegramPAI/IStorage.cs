namespace TelegramPAI
{
	interface IStorage // интерфейс для хранения
	{
		void GetEntity();
		void StoreEntity(string args);
		void GetEntityList();
	}
}
