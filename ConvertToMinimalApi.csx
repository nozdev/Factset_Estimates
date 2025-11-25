#r "nuget: Microsoft.CodeAnalysis.CSharp, 4.12.0"
using System.IO;
using System.Text.RegularExpressions;
string FirstCharToUpper(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        return input[0].ToString().ToUpper() + input.Substring(1);
    }

var inputDir = "";       // NSwag output folder
var outputFile = Path.Combine(inputDir, "Program.cs");

var sb = new System.Text.StringBuilder();

// --- Minimal API boilerplate ---
sb.AppendLine("using Microsoft.AspNetCore.Builder;");
sb.AppendLine("using Microsoft.Extensions.DependencyInjection;");
sb.AppendLine("using System.Threading;");
sb.AppendLine("var builder = WebApplication.CreateBuilder(args);");
sb.AppendLine("var app = builder.Build();");
sb.AppendLine();

// --- Loop over all controller files ---
foreach (var file in Directory.GetFiles(inputDir, "*.cs"))
{
    var text = File.ReadAllText(file);

    // Match HTTP methods in controllers
    var regex = new Regex(@"\[Http(Get|Post|Put|Delete|Patch)\(\""(.*?)\""\)\]\s*public\s+async\s+Task<.*?>\s+(\w+)\s*\((.*?)\)\s*\{", RegexOptions.Singleline);

    foreach (Match m in regex.Matches(text))
    {
        var method = m.Groups[1].Value.ToLower();   // get, post, etc.
        var route = m.Groups[2].Value;              // "/path"
        var actionName = m.Groups[3].Value;         // method name
        var parameters = m.Groups[4].Value;         // method parameters

        // Remove CancellationToken from parameters if present
        parameters = Regex.Replace(parameters, @"CancellationToken\s+\w+,?", "");

        // Map to Minimal API endpoint
        sb.AppendLine($"app.Map{FirstCharToUpper(method)}(\"{route}\", async ({parameters}) =>");
        sb.AppendLine("{");
        sb.AppendLine($"    // TODO: implement {actionName} logic");
        sb.AppendLine("});");
        sb.AppendLine();
    }
}

sb.AppendLine("app.Run();");

// Save Program.cs
File.WriteAllText(outputFile, sb.ToString());
Console.WriteLine($"Minimal API Program.cs generated at: {outputFile}");

// --- Top-level static extension class ---


    

