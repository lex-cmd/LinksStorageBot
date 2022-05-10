namespace TelegramPAI
{
	internal class CommandRepository<T> : IRepository<T> //Класс для сохранения и хранения списка команд
	where T : class, ICommand
	{
		public void Create(T item)
		{

		}

		public void Delete(int id)
		{

		}

		public IEnumerable<T> GetCommandList()
		{
			return null;
		}

		public T GetCommand(int id)
		{
			return null;
		}

		public void Save()
		{

		}

		public void Update(T item)
		{

		}

		public bool HasActiveCommand() // метод для проверки, если есть активная команда возращает true, иначе false
		{
			return false;
		}
	}
}
