using ConsoleApp.AsyncSample;
using System;
using System.Threading.Tasks;

namespace Asynchronous_Multithreading
{
    internal class Program
    {
        static async Task Main(string[] args) {
            AsyncFunctions asyncFunctions = new AsyncFunctions();
            await asyncFunctions.ExecuteAsyncFunctions();

            Console.WriteLine();

            Multithreading multithreading = new Multithreading();
            multithreading.ExecuteMultithreading();
        }
    }
}
