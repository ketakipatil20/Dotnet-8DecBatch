using System;
using System.Reflection;
using System.Text;




namespace Assignment_8_B
{
    class Test
    {
        public void ReadAttributes()
        {
            Attribute[] attr_1 = Attribute.GetCustomAttributes(typeof(HDFC));
            Attribute[] attri_2 = Attribute.GetCustomAttributes(typeof(ICICI));
            Console.WriteLine("For Hdfc Account.....");
            foreach (Attribute attri in attr_1)
            {
                Type t = attri.GetType();
                MethodInfo[] methods = t.GetMethods();
                PropertyInfo[] property = t.GetProperties();
                Console.WriteLine("Method info......");
                foreach (MethodInfo m in methods)
                {
                    Console.WriteLine(m.ReturnType.Name + " " + m.Name);
                }
                Console.WriteLine("Property info.....");
                foreach (PropertyInfo p in property)
                {
                    Console.WriteLine(p.PropertyType.Name + " " + p.Name);
                }
            }
            Console.WriteLine("For icici Account.....");
            foreach (Attribute attri in attri_2)
            {
                Type t = attri.GetType();
                MethodInfo[] method = t.GetMethods();
                PropertyInfo[] prop = t.GetProperties();
                Console.WriteLine("Method info......");
                foreach (MethodInfo m in method)
                {
                    Console.WriteLine(m.ReturnType.Name + " " + m.Name);
                }
                Console.WriteLine("Property info.....");
                foreach (PropertyInfo p in prop)
                {
                    Console.WriteLine(p.PropertyType.Name + " " + p.Name);
                }
            }
        }
    }
}