namespace TelegramPAI
{
	internal class Category// для хранения списка ссылок и имени категории, вызывается в мапе класса категорий
	{
		public string Name { get; set; } //имя категории
		public List<string> Links { get; set; }//для хранения списка ссылок

		public Category(string name)
		{
			this.Name = name;
		}

		public string ToString()
		{
			//метод добавляет все ссылки строку и возвращает её
		}

		public void AddLink()
		{
			//добавление новой ссылки в список
		}
	}
}
