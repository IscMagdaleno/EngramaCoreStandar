﻿using System.Linq;

namespace EngramaCoreStandar.Extensions
{
	public static class CharExt
	{
		public static bool MoreThanOneCharacter(this char[] self)
		{
			var withoutSpaces = self.Where(x => x.IsWhiteSpace().False());

			return withoutSpaces.Count(x => x.IsUpper()) > 1;
		}

		public static bool IsAny(this char value, params char[] values)
		{
			return values.Count(val => val == value) > 0;
		}

		public static bool IsLetter(this char value)
		{
			return char.IsLetter(value);
		}

		public static bool IsNumber(this char value)
		{
			return char.IsNumber(value);
		}

		public static bool IsDigit(this char value)
		{
			return char.IsDigit(value);
		}

		public static bool IsWhiteSpace(this char value)
		{
			return char.IsWhiteSpace(value);
		}

		public static bool IsUpper(this char value)
		{
			return char.IsUpper(value);
		}
	}
}
