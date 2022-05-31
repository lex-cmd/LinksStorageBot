namespace TelegramPAI
{
	internal class CommandRepository<ICommand> : IRepository<ICommand> //Класс для сохранения и хранения списка команд
	where ICommand : class
	{
		ICommand _command;
		private bool isActive;

		public CommandRepository()
		{
			isActive = false;
		}

		public void Create(ICommand item) // создание объекта
		{
			_command = item;

		}

		public void Delete(ICommand item)// удаление объекта
		{
			throw new NotImplementedException();
		}

		public List<ICommand> GetCommandList()
		{
			throw new NotImplementedException();
		}
		public bool HasActiveCommand() // метод для проверки, если есть активная команда возращает true, иначе false
		{
			return (isActive);
		}

		public void SetInactive()
		{
			isActive = false;
		}

		public void Update(ICommand item) // метод для обновления объекта, для работы с бд
		{
			throw new NotImplementedException();
		}

		internal void SetActive()
		{
			isActive = true;
		}

		public void Save() // метод для сохранения объекта, для работы с бд
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public ICommand GetItem(int id)
		{
			return _command;
		}
		public ICommand GetItem()
		{
			return _command;
		}
	}
}