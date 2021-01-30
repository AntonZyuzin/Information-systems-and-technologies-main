using System;
using System.Linq;
using System.Text;

namespace Implementation2
{
    public class StringUtils
    {
        public static string Merge(string text1, string text2) {
            var leftNumbers = text1.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var rightNumbers = text2.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int linesCount = Math.Min(leftNumbers.Count, rightNumbers.Count);

            var sb = new StringBuilder();

            for (int i = 0; i < linesCount; i++) {
                string line = "|" + leftNumbers[i] + string.Join("", Enumerable.Repeat(".", 30 - 1 - leftNumbers[i].Length))
                       + string.Join("", Enumerable.Repeat(",", 30 - 1 - rightNumbers[i].Length)) + rightNumbers[i] + "|";
                sb.AppendLine(line);
            }

            return sb.ToString();
        }
    }
}
