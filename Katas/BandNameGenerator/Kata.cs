using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.BandNameGenerator
{
	public class Kata
	{
		public string BandNameGenerator(string name)
		{
			if (name.ToLower().First() != name.ToLower().Last())
				return GetPrefixName(name);

			return GetRepeatName(name);
		}

		private string GetPrefixName(string name)
		{
			return string.Format("The {0}", GetSingleName(name, true));
		}

		private string GetRepeatName(string name)
		{
			return GetSingleName(name, true) + GetSingleName(name, false);
		}

		private string GetSingleName(string name, bool isNeedFirstChar)
		{
			var firstChar = name.First().ToString().ToUpper();
			var theRestPart = name.Substring(1).ToLower();

			return isNeedFirstChar ? string.Format("{0}{1}", firstChar, theRestPart) : theRestPart;
		}
	}
}
