using System;

namespace TemplatePattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea t = new Tea();
            Coffee c = new Coffee();
            t.prepareRecipe();
            c.prepareRecipe();
        }
    }
}
