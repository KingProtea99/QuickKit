using UnityEngine;

namespace KP.QuickKit.Command
{
    public abstract class Command : ScriptableObject, ICommand
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}