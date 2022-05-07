namespace TelegramPAI
{
	interface ICommand
	{
		void Execute(); ///Метод для выполнения команды
		void ExecuteNext(string commandToExec); // метод для следущего выполнения команды
	}
}
