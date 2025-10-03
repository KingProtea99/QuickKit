namespace KP.QuickKit.Command
{
    public interface ICommand
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}