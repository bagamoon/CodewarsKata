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
			if (IsFirstAndLastCharAreDifferent(name))
				return string.Format("The {0}", FormatName(name, true));

			return string.Format("{0}{1}", FormatName(name, true), FormatName(name, false));
		}

		private bool IsFirstAndLastCharAreDifferent(string name)
		{
			return name.Length == 1 ||
			       name.First() != name.Last();
		}

		private string FormatName(string name, bool isNeedFirstChar)
		{
			var firstChar = name.First().ToString().ToUpper();
			var theRestPart = name.Substring(1).ToLower();

			return isNeedFirstChar ? string.Format("{0}{1}", firstChar, theRestPart) : theRestPart;
		}
	}
}
