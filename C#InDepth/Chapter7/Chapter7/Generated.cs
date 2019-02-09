using System;
namespace Chapter7
{
    partial class PartialMethodDemo
    {
        public PartialMethodDemo()
        {
            OnConstructorStart();
            Console.WriteLine("Generated constructor");
            /*
            OnConstructorEnd();
            */           
        }

        void OnConstructorStart()
        {
        }

        partial void OnConsructorEnd();

    }
}
