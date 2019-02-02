using System;

namespace Chapter1
{
    public class ComAndDT
    {
        public ComAndDT()
        {
        }

        public static void Demo()
        {
            /*
            var app = new Application { Visible = false };
            Workbook workbook = app.Workbooks.Add();
            Worksheet worksheet = app.ActiveSheet;
            int row = 1;
            foreach (var product in Product.GetSampleProducts().Where(p => p.Price != null))
            {
                worksheet.Cells[row, 1].Value = product.Name;
                worksheet.Cells[row, 2].Value = product.Price;
                row++;
            }
            workbook.SaveAs(Filename: "demo.xls",
                            FileFormat: XlFileFormat.xlWorkbookNormal);
            app.Application.Quit();
            */
            //version problem
        }

        public static void DemoTwo()
        {
            /*
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.ExecuteFile("FindProducts.py"); dynamic products = scope.GetVariable("products");
            foreach (dynamic product in products)
            {
                Console.WriteLine("{0}: {1}", product.ProductName, product.Price);
            }
            */
            //version problem

        }
    }
}
