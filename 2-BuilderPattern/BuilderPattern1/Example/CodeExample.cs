using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace BuilderPattern.Example
{
    public class CodeExample
    {
        public class ClassElementGenerator
        {
            public string Type;
            public string Name;
            public List<ClassElementGenerator> Elements = new List<ClassElementGenerator>();
            private const int indentSize = 2;

            public ClassElementGenerator(string type, string name)
            {
                Type = type ?? throw new ArgumentNullException(paramName: nameof(type));
                Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            }

            public ClassElementGenerator()
            {
            }

            private string ToStringImpl(int indent)
            {
                var sb = new StringBuilder();
                var i = new string(' ', indentSize * indent);

                if (!string.IsNullOrWhiteSpace(Type))
                {
                    sb.AppendLine($"{new string(' ', indentSize * (indent + 1))} public {Type} {Name};");
                }
                else
                {
                    sb.AppendLine($"public class {i}{Name}  ");
                    sb.AppendLine("{");
                }

                foreach (var e in Elements)
                {
                    sb.Append(e.ToStringImpl(indent + 1));
                    if (Elements.IndexOf(e) == Elements.Count - 1)
                    {
                        sb.AppendLine("}");
                    }
                }

                return sb.ToString();
            }

            public override string ToString()
            {
                return ToStringImpl(0);
            }
        }

        public class CodeBuilder
        {
            private readonly string className;
            private ClassElementGenerator root = new ClassElementGenerator();

            public CodeBuilder(string className)
            {
                root.Name = className;
            }

            public CodeBuilder AddField(string type, string name)
            {
                var e = new ClassElementGenerator(type, name);
                root.Elements.Add(e);
                return this;
            }

            public override string ToString()
            {
                return root.ToString();
            }
        }

        internal class Builder
        {
            private static void Main(string[] args)
            {
                var builder = new CodeBuilder("Person");
                builder.AddField("string", "Name")
                    .AddField("int", "Age");
                WriteLine(builder.ToString());
            }
        }
    }
}