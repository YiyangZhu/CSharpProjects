using System;
namespace DesignPattern.FactoryPatternPractice
{
    public class TableStore
    {
        public Table table;
        public TableStore()
        {
        }

        public void CreateTable(string Type)
        {
            TableFactory tableFactory = new TableFactory(Type);
            table = tableFactory.table;
            tableFactory.Design();
            tableFactory.CreateTopAndApron();
            tableFactory.AttachLegs();
            tableFactory.SandAndStain();
            tableFactory.Box();
        }

        public void OrderTable()
        {
            Console.WriteLine(table + " has been ordered.");
        }
    }
}
