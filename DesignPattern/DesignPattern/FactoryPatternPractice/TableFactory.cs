using System;
namespace DesignPattern.FactoryPatternPractice
{
    public class TableFactory
    {
        public Table table;
        public TableFactory(string Type)
        {
            if(Type == null)
            {
                table = new Table();
            } else if (Type.Equals("side"))
            {
                table = new SideTable();
            } else if (Type.Equals("bunching"))
            {
                table = new BunchingTable();
            }
            else
            {
                table = new Table();
            }
        }

        public void Design()
        {
            Console.WriteLine("Design " + table.Name);
        }

        public void CreateTopAndApron()
        {
            Console.WriteLine("Create top and apron for " + table.Name);
        }

        public void AttachLegs()
        {
            Console.WriteLine("Attach legs for " + table.Name);
        }

        public void SandAndStain()
        {
            Console.WriteLine("Sand and stain " + table.Name);
        }

        public void Box()
        {
            Console.WriteLine("Box " + table.Name);
        }
    }
}
