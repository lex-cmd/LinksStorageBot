namespace TelegramPAI
{
	internal class Category
	{
		private List<string> links;

		public Category(string name)
		{
			Name = name;
			links = new List<string>();
		}
		public string Name { get; set; }
		public void StoreEntity(string item)
		{
			links.Add(item);
		}

		public bool RemoveEnity(string item)
		{
			return links.Remove(item);
		}

		public string GetLinksToString()
		{
			string finalString = null;

			foreach(string link in links)
			{
				finalString += link + "\n";
			}
			return finalString;
		}
	}
}
