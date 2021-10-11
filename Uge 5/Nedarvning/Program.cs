using System;
using Nedarvning.Models;

namespace Nedarvning
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();

            parent.Display();
            child.Display();
        }
    }
}
