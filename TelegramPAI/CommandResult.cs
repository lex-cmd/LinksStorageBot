namespace TelegramPAI
{
	internal class CommandResult
	{
		private string _result;

		public CommandResult(string result)
		{
			_result = result;
		}
		public void BuildResultFromList(List<string> result)
		{
			string finalRes = null;

			foreach(string resultItem in result)
			{
				finalRes += resultItem;
			}
		}

		public string Result()
		{
			return _result;
		}
	}
}
