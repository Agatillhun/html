using System;
using System.Diagnostics;
using System.IO;

internal static class QuizLauncher
{
    private static void Main()
    {
        string quizPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "index.html");

        if (!File.Exists(quizPath))
        {
            Console.Error.WriteLine("Az index.html nem található az EXE mellett.");
            return;
        }

        Process.Start(new ProcessStartInfo
        {
            FileName = quizPath,
            UseShellExecute = true
        });
    }
}