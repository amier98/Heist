using System;
namespace Heist
{
    public class Locksmith
    {
        public void OpenSafe(Safe safe,SafeOwner safeOwner)
        {
            safe.PickLock(this);
            string safeContents = safe.Open(Combination);
            ReturnContents(safeContents, safeOwner);

        }

        public string Combination { private get; set; }

        protected virtual void ReturnContents(string safeContents, SafeOwner owner)
        {
            owner.RecieveContents(safeContents);
        }
    }
}
