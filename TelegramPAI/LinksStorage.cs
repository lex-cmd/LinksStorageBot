namespace TelegramPAI
{
	class LinksStorage : IStorage
	{
		private List<Category> _categories = new List<Category>();
		public void GetEntity() //Получить категорию ссылок
		{

		}

		public void GetEntityList() //Получить список категорий ссылок
		{

		}

		public string GetEntityListToString() //Получить строку категорий ссылок
		{
			string finalString = null;

			if(_categories.Count == 0)
				return null;
			foreach(Category category in _categories)
			{
				finalString += category.Name + "\n";
				finalString += category.GetLinksToString() + "\n";
			}
			return finalString;
		}

		public Category FindNameCategory(string name)
		{
			foreach(var category in _categories)
			{
				if(category.Name == name)
				{
					return category;
				}
			}
			return null;
		}

		public bool StoreEntity(string args) //Сохранить ссылку в категорию
		{
			var argsArr = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			if(argsArr.Length != 2)
				return false;

			var found = FindNameCategory(argsArr[0]);
			Console.WriteLine(argsArr[1]);
			if(found == null)
			{
				var newCategory = new Category(argsArr[0]);
				newCategory.StoreEntity(argsArr[1]);
				_categories.Add(newCategory);
				Console.WriteLine("Save done");
				return (true);
			}
			found.StoreEntity(argsArr[1]);
			return (true);
		}
	}
}
