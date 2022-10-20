using System;

namespace FolderDir
{
    public class GetFolderDirectory
    {
        public static void Main()
        {
            Console.WriteLine("The folder directory is as below: ");
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));

        }
    }
}