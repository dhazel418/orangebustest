using System.Linq;

namespace SkeletonCode.ReversingString
{
	public class StringUtilities
	{
		public string Reverse(string input)
		{
			string output = string.Empty;

		  if (!string.IsNullOrEmpty(input))
		  {
        output = new string(input.Reverse().ToArray());
      }

			return output;
		}
	}
}
