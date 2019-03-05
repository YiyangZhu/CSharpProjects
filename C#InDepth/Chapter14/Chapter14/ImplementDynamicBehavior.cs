using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Xml.Linq;

namespace Chapter14
{
    public class ImplementDynamicBehavior
    {
        public ImplementDynamicBehavior()
        {
        }

        public static void Demo()
        {
            dynamic expando = new ExpandoObject();
            IDictionary<string, object> dictionary = expando;
            expando.First = "value set dynamically";
            Console.WriteLine(dictionary["First"]);
            dictionary["Second"] = "value set with dictionary";
            Console.WriteLine(expando.Second);
        }

        public static void Demo2()
        {
            dynamic expando = new ExpandoObject();
            expando.AddOne = (Func<int, int>)(x => x + 1);
            Console.WriteLine(expando.AddOne(10));
        }

        public static dynamic CreateDynamicXml(XElement element)
        {
            dynamic expando = new ExpandoObject();
            expando.XElement = element;
            expando.ToXml = (Func<string>)element.ToString;
            IDictionary<string, object> dictionary = expando;
            foreach (XElement subElement in element.Elements())
            {
                dynamic subNode = CreateDynamicXml(subElement);
                string name = subElement.Name.LocalName;
                string listName = name + "List";
                if (dictionary.ContainsKey(name))
                {
                    ((List<dynamic>)dictionary[listName]).Add(subNode);
                }
                else
                {
                    dictionary[name] = subNode;
                    dictionary[listName] = new List<dynamic> { subNode };
                }
            }
            return expando;
        }

        public static void Demo3()
        {
            XElement xmlTree1 = new XElement("Root",
                new XElement("Child1", 1),
                new XElement("Child2", 2),
                new XElement("Child3", 3),
                new XElement("Child4", 4),
                new XElement("Child5", 5),
                new XElement("Child6", 6)
            );
            Console.WriteLine(xmlTree1);

            XElement xmlTree2 = new XElement("Root",
                from el in xmlTree1.Elements()
                where ((int)el >= 3 && (int)el <= 5)
                select el
            );
            Console.WriteLine(xmlTree2);
        }
    }
}
