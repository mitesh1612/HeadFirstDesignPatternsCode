using System;

namespace CommandPattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            remote.setCommand(new LightOnCommand(new Light()));
            remote.buttonWasPressed();
        }
    }
}
