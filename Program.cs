using System;
using System.IO;

namespace C_Todo
{
    class Program
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string projectDir = Directory.GetCurrentDirectory();
            string storage = projectDir + "/SavedTodos.txt"; // gets created if doesn't exist.

            string newTodo = string.Join(" ", args);

            
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@storage, true))
            {
                file.WriteLine($"{newTodo}");
            }
        }
    }
}
