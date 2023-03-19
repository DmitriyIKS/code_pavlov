using System;
using System.IO;

namespace Stroki
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello");
            foreach (var drive in DriveInfo.GetDrives())
            {
                try
                {
                    Console.WriteLine("Имя диска: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(drive.Name + "\n");
                    Console.ResetColor();

                    Console.WriteLine("Файловая система: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(drive.DriveFormat + "\n");
                    Console.ResetColor();

                    Console.WriteLine("Тип диска: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(drive.DriveType + "\n" );
                    Console.ResetColor();

                    Console.WriteLine("Обьем свободного доступного места в мб: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write((drive.AvailableFreeSpace/1024) + "\n");
                    Console.ResetColor();

                    Console.WriteLine("Готов ли диск: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(drive.IsReady + "\n");
                    Console.ResetColor();

                    Console.WriteLine("Корневой католог: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(drive.RootDirectory + "\n");
                    Console.ResetColor();

                    Console.WriteLine("Общий обьем свободного места в мб: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write((drive.TotalFreeSpace/1024) + "\n");
                    Console.ResetColor();

                    Console.WriteLine("Размер диска в мб: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write((drive.TotalSize/1024) + "\n");
                    Console.ResetColor();

                    Console.WriteLine("Метка тома диска: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(drive.VolumeLabel + "\n");
                    Console.ResetColor();
                }
                catch { }
                Console.WriteLine();
            }
        }
    }
}