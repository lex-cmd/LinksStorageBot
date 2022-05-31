namespace TelegramPAI
{
	class LinksStorage : IStorage
	{
		private List<CategoryLink> categoryLink;
		public void GetEntity(string args) //Получить категорию ссылок
		{
			categoryLink = new List<CategoryLink>();
		}

		public void GetEntityList() //Получить список категорий ссылок
		{
		}

		public List<CategoryLink> GetCategoryList() //Получить список категорий ссылок
		{
			return categoryLink;
		}
		public void StoreEntity(string args) //Сохранить ссылку в категорию
		{
			var splitList = args.Split(' ').ToList();
		}

	}
}
