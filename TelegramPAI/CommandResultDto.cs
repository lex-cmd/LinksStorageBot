namespace TelegramPAI
{
	internal class CommandResultDto // класс для форматирования и хранения результата
	{
		public string result;

		public CommandResultDto(string format)
		{
			result = format;
		}
		public string Format()
		{
			return result.ToString();
		}
	}
}
