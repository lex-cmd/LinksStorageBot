namespace TelegramPAI
{
	interface IRepository<T>
									where T : class
	{
		public T GetItem(int id); // получение одного объекта по id
		public void Create(T item, int id); // создание объекта
		public void Update(T item); // обновление объекта
		public bool Delete(int id); // удаление объекта по id
		public void Save();  // сохранение изменений
	}
}
