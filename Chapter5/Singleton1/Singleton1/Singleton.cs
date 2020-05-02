using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton1
{
    public class Singleton
    {
        private static Singleton uniqueInstance;

        private Singleton()
        {

        }

        public static Singleton getInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new Singleton();
            }
            return uniqueInstance;
        }
    }
}
