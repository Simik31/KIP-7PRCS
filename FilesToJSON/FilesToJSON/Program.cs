using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;

namespace FilesToJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cesta ke slozce\n -> ");
            string folderPath = Console.ReadLine();
            Console.Write("Cesta a nazev vystupniho souboru\n -> ");
            string exportFilePath = Console.ReadLine();

            if (!Directory.Exists(folderPath)) ExitWithMessage("Zadana slozka neexistuje", ConsoleColor.Red);
            else if (File.Exists(exportFilePath)) ExitWithMessage("Zadany soubor jiz existuje", ConsoleColor.Red);
            else
            {
                FileStream exportFile = null;
                StreamWriter writer = null;
                try
                {
                    exportFile = File.Create(exportFilePath);
                    writer = new StreamWriter(exportFile);
                    writer.AutoFlush = true;
                    writer.Write("[");

                    List<FileInfo> files = Directory.GetFiles(folderPath).Select(q => new FileInfo(q)).ToList();

                    for (int i = 0; i < files.Count; i++)
                    {
                        FileInfo file = files[i];

                        writer.WriteLine("{");
                        writer.WriteLine("\t\"Name\":\"" + file.Name + "\",");
                        writer.WriteLine("\t\"lastWriteTime\":\"" + file.LastWriteTimeUtc + "\",");
                        writer.WriteLine("\t\"size\":\"" + (file.Length / 1024.0 / 1024) + "\"");
                        writer.WriteLine("}" + ((i < files.Count - 1) ? "," : "\n]"));
                    }

                    ExitWithMessage("Úspěšně dokončeno", ConsoleColor.Green);
                }
                catch
                {
                    ExitWithMessage("Nelze vytvořit / zapisovat do vystupniho souboru", ConsoleColor.Red);
                }
                finally
                {
                    if (writer != null) writer.Close();
                    if (exportFile != null) exportFile.Close();
                }
            }
        }

        private static void ExitWithMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("\n" + message);
            Console.ResetColor();
            Console.Write("\nPress any key to close this window . . .");
            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
