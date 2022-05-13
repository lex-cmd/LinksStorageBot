namespace TelegramPAI
{
	internal class CommandResultDto // класс для форматирования и хранения результата
	{
		public string result;

		public CommandResultDto()
		{
			result = null;
		}
		public string Format()
		{
			return result.ToString();
		}
	}
}
