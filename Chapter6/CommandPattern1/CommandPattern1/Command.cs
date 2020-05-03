using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern1
{
    public interface Command
    {
        public void execute();
    }

    public class LightOnCommand : Command
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.on();
        }
    }

    public class Light
    {
        public void on()
        {
            Console.WriteLine("Light turned on");
        }

        public void off()
        {
            Console.WriteLine("Light turned off");
        }
    }
}
