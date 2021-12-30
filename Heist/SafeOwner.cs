using System;
namespace Heist
{
    public class SafeOwner
    {
        private string valuables = "";
        public void RecieveContents(string safeContents)
        {
            valuables = safeContents;
            Console.WriteLine($"Thank you for returning my {valuables}!");
        }
    }
}
