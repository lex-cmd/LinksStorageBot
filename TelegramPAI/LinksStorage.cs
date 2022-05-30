namespace TelegramPAI
{
	class LinksStorage : IStorage
	{
		private Dictionary<string, List<string>> _links = new Dictionary<string, List<string>>();
		public void GetEntity(string args) //Получить категорию ссылок
		{
			
		}

		public void GetEntityList() //Получить список категорий ссылок
		{
		
			foreach(var link in _links)
			{
				Console.Write("Category: " + link.Key + "\t");
				Console.WriteLine("Link: " + link.Value.ToString());
			}
		}

		public void StoreEntity(string args) //Сохранить ссылку в категорию
		{
			_links.Add(args.Split(' ')[0], args.Split(' ')[1]);
		}

	}
}
