using System;
namespace Heist
{
    public class Safe
    {
        private string contents = "precious jewels";
        private string safeCombination = "1234";

        public string Open(string combination)
        {
            if (combination == safeCombination) return contents;
            return "";
        }

        public void PickLock(Locksmith locksmith)
        {
            locksmith.Combination = safeCombination;
        }
    }
}
