namespace TelegramPAI
{
	interface IRepository<T>
									where T : class
	{
		IEnumerable<T> GetCommandList(); // получение всех объектов
		T GetCommand(int id); // получение одного объекта по id
		void Create(T item); // создание объекта
		void Update(T item); // обновление объекта
		void Delete(int id); // удаление объекта по id
		void Save();  // сохранение изменений
	}
}
