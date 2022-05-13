using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramPAI
{
	abstract class CommandResultDtoFactory // класс для создания результата
	{
		public static CommandResultDto CreateResult(string newMessage)
		{
			var dto = new CommandResultDto();
			dto.result = newMessage;
			return dto;
		}
	}
}
