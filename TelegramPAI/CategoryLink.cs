namespace TelegramPAI
{
	internal class CategoryLink
	{
		private List<string> _links;
		private string _name;
		public CategoryLink(string name)
		{
			_links = new List<string>();
			_name = name;
		}

		public void AddNewLink(string newString)
		{
			_links.Add(newString);
		}

		public List<string> GetLinkList()
		{
			return (_links);
		}

		public string GetName()
		{
			return (_name);
		}
	}
}
