using System.Text;
using static System.Console;

namespace BuilderPattern
{
    public class Basic
    {
        private static void Main(string[] args)
        {
            var hello = "hello";

            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");

            WriteLine(sb);

            var words = new[] { "hello", "world" };
            sb.Clear();
            sb.Append("<ul>");
            foreach (var word in words)
                sb.AppendFormat("<li>{0}</li>", word);
            sb.Append("</ul>");
            WriteLine(sb);
        }
    }
}