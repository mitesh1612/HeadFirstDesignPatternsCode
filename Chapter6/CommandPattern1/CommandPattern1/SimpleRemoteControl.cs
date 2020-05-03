using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern1
{
    public class SimpleRemoteControl
    {
        Command slot;
        public SimpleRemoteControl() { }
        public void setCommand(Command command)
        {
            slot = command;
        }
        public void buttonWasPressed()
        {
            slot.execute();
        }
    }
}
