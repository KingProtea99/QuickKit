using System.Collections.Generic;
using UnityEngine;

namespace KP.QuickKit.Command
{
    public class CommandManager : MonoBehaviour
    {
        [SerializeField] private List<Command> _commands = new();
        [SerializeField] private int _index = -1;

        public void ExecuteCommand(Command command)
        {
            command.Execute();

            if (_index < _commands.Count - 1)
            {
                int removeCount = _commands.Count - (_index + 1);
                _commands.RemoveRange(_index + 1, removeCount);
            }

            _commands.Add(command);
            _index++;
        }

        public void UndoCommand()
        {
            if (_index < 0) return;

            _commands[_index].Undo();
            _index--;
        }

        public void RedoCommand()
        {
            if (_index >= _commands.Count - 1) return;

            _index++;
            _commands[_index].Execute();
        }
    }
}