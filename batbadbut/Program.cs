// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

Console.WriteLine("Hello!");
const string cmdArgsToRun = "/C echo \"\\\"&calc.exe\"";
Console.WriteLine("I am going to run following command. Guess what will happen ;-)");
Console.WriteLine("");
Console.WriteLine($"cmd {cmdArgsToRun}");


// There are different ways how to start process in C#

// #1 - directly via static `Process.Start` method
Process.Start("cmd", cmdArgsToRun);

/*
// #2 - via static `Process.Start` method with `ProcessStartInfo` as input
var startInfo = new ProcessStartInfo("cmd", cmdArgsToRun);
Process.Start(startInfo);
*/

/*
// #3 - via custom instance of `Process` class 
var myProcess = new Process();
myProcess.StartInfo.FileName = "cmd";
myProcess.StartInfo.Arguments = cmdArgsToRun;
myProcess.Start();
*/


Console.WriteLine("");
Console.WriteLine("See? The calc.exe was started on your computer");
Console.WriteLine("Bye!");

Console.WriteLine("");
Console.WriteLine("Press any key to stop this console program ...");
Console.ReadKey();

