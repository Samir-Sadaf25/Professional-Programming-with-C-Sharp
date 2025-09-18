
using System.Runtime.InteropServices.JavaScript;
using System.Text;

string a = "Helllo";
a = a + " World";
a = "hello" + "world" + "from" + "dhaka";

string b = string.Empty;
for (int i = 0; i < a.Length; i++)
{
    b += char.ToUpper(a[i]);
}

string html = "<html>" +
                    "<body>" +
                        "<h1>" + a + "</h1>" +
                    "</body>" +
               "</html>";


StringBuilder stringBuilder = new StringBuilder(a);

for (int i = 0; i < stringBuilder.Length; i++)
{
    stringBuilder[i] = Char.ToUpper(stringBuilder[i]);
}


StringBuilder htmlStringBuilder = new StringBuilder();
htmlStringBuilder.Append("<html>")
                    .Append("<body>")
                        .Append("<h1>")
                            .Append(a)
                        .Append("</h1>")
                    .Append("</body>")
                .Append("</html>");

string result = htmlStringBuilder.ToString();

Console.WriteLine(htmlStringBuilder);