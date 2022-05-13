namespace TelegramPAI
{
	internal class CommandRepository<ICommand> : IRepository<ICommand> //Класс для сохранения и хранения списка команд
	where ICommand : class
	{
		Dictionary<long?, ICommand> _commands;
		private long? _id;

		public CommandRepository()
		{
			_id = 0;
			_commands = new Dictionary<long?, ICommand>();
		}

		public void Create(ICommand item) // создание объекта
		{
			_commands.Add(_id, item);
			_id++;
		}

		public void Create(ICommand item, long? id) // создание объекта с ID бота пользователя
		{
			_commands.Add(id, item);
		}

		public void Delete(long? id)// удаление объекта по id
		{
			_commands.Remove(_id);
		}
		public void Delete(int id)
		{
			_commands.Remove(_id);
		}

		public IEnumerable<ICommand> GetCommandList() // получение всех объектов в список
		{
			List<ICommand> commandList = new List<ICommand>();

			for(int i = 0; i < _commands.Count; i++)
			{
				commandList.Add(_commands[i]);
			}
			return commandList;
		}

		public ICommand GetCommand(long? id)  // получение одного объекта по id
		{
			return _commands[id];
		}

		public ICommand GetCommand(int id)
		{
			return _commands[id];
		}
		public bool HasActiveCommand(long? id) // метод для проверки, если есть активная команда возращает true, иначе false
		{
			if (_commands.ContainsKey(id))
			{
				return true;
			}
			return false;
		}

		public void Update(ICommand item) // метод для обновления объекта, для работы с бд
		{
			throw new NotImplementedException();
		}

		public void Save() // метод для сохранения объекта, для работы с бд
		{
			throw new NotImplementedException();
		}
	}
}
