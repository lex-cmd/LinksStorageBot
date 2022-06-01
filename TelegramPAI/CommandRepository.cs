namespace TelegramPAI
{
	internal class CommandRepository<ICommand> : IRepository<ICommand> //Класс для сохранения и хранения списка команд
	where ICommand : class
	{
		Dictionary<long?, ICommand> _commands;

		public CommandRepository()
		{
			_commands = new Dictionary<long?, ICommand>();
		}

		public void Create(ICommand item, int id) // создание объекта
		{
			_commands.Add(id, item);
			id++;
		}

		public void Create(ICommand item, long? id) // создание объекта с ID бота пользователя
		{
			_commands.Add(id, item);
		}

		public bool Delete(long? id)// удаление объекта по id
		{
			return _commands.Remove(id);
		}
		public bool Delete(int id)
		{
			return _commands.Remove(id);
		}

		public ICommand GetItem(long? id)  // получение одного объекта по id
		{
			return _commands[id];
		}

		public bool HasActiveCommand(long? id) // метод для проверки, если есть активная команда возращает true, иначе false
		{
			return _commands.ContainsKey(id);
		}

		public void Update(ICommand item) // метод для обновления объекта, для работы с бд
		{
			throw new NotImplementedException();
		}

		public void Save() // метод для сохранения объекта, для работы с бд
		{
			throw new NotImplementedException();
		}

		public ICommand GetItem(int id)
		{
			return _commands[id];
		}

	}
}