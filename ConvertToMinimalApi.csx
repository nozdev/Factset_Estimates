#r "nuget: Microsoft.CodeAnalysis.CSharp, 4.12.0"

using System.IO;
using System.Text.RegularExpressions;

var inputDir = "generated-minimal-api";  // NSwag output folder
var outputFile = "generated-minimal-api/Program.cs";

var sb = new System.Text.StringBuilder();

// Write minimal API boilerplate
sb.AppendLine("using Microsoft.AspNetCore.Builder;");
sb.AppendLine("using Microsoft.Extensions.DependencyInjection;");
sb.AppendLine("using System.Threading;");
sb.AppendLine("var builder = WebApplication.CreateBuilder(args);");
sb.AppendLine("var app = builder.Build();");
sb.AppendLine();

// Loop through all controller files
foreach (var file in Directory.GetFiles(inputDir, "*.cs"))
{
    var text = File.ReadAllText(file);

    // Regex to match HTTP methods in controllers
    var regex = new Regex(@"\[Http(Get|Post|Put|Delete|Patch)\(\""(.*?)\""\)\]\s*public\s+async\s+Task<.*?>\s+(\w+)\s*\((.*?)\)\s*\{", RegexOptions.Singleline);

    foreach (Match m in regex.Matches(text))
    {
        var method = m.Groups[1].Value.ToLower();       // get, post, etc.
        var route = m.Groups[2].Value;                  // "/path"
        var actionName = m.Groups[3].Value;             // method name
        var parameters = m.Groups[4].Value;             // method parameters

        // Remove CancellationToken from parameters if present
        parameters = Regex.Replace(parameters, @"CancellationToken\s+\w+,?", "");

        // Map controller action to Minimal API endpoint
        sb.AppendLine($"app.Map{method.ToTitileCase()}(\"{route}\", async ({parameters}) =>");
        sb.AppendLine("{");
        sb.AppendLine($"    // TODO: implement {actionName} logic");
        sb.AppendLine("});");
        sb.AppendLine();
    }
}

sb.AppendLine("app.Run();");

// Save output Program.cs
File.WriteAllText(outputFile, sb.ToString());
Console.WriteLine($"Minimal API Program.cs generated at: {outputFile}");

// Extension to capitalize HTTP method
static class Ext
{
    public static string FirstCharToUpper(this string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        return input[0].ToString().ToUpper() + input.Substring(1);
    }
}
