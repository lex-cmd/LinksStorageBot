using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramPAI
{
	internal class Commands
	{
	public Commands()
	{
	}
	public void GetLinks(Dictionary<string, Category> Categories, string option)
	{
		//вывод всех ссылок из Categories
		//option - название категории, если в option будет значение all, то вывести все ссылки
	}
	public Dictionary<string, Category> StoreLink(Dictionary<string, Category> Categories, string name, string link)
	{
		//сохранение новой ссылки в категорию с названием из name или ввод новой категории с сохранением ссылки в новую категорию
		//возвращение измененной категории
		}
	}
}
