using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileHandlingConcepts
{
    [Serializable]
    class Employee
    {
        public int code;
        public string name;
        public Employee(int code, string name)
        {
            this.code = code;
            this.name = name;
        }
    }

    class SerializationDeserialization
    {
        public void Serialize()
        {
            Employee employee1 = new Employee(1001, "Bhawna Gunwani");

            FileStream fs = new FileStream("E:\\MCIT-DotNet-Phase-One-Projects\\Files\\employee.txt",
                FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, employee1);
            fs.Close();

        }
        public void Deserialize()
        {
            FileStream fs = new FileStream("E:\\MCIT-DotNet-Phase-One-Projects\\Files\\employee.txt",
                FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Employee emp = (Employee)formatter.Deserialize(fs);
            Console.WriteLine("Code : {0}, Name : {1}", emp.code, emp.name);
            fs.Close();
        }
    }
    class SerializationDeserializationExample
    {
        static void Main(string[] args)
        {
            SerializationDeserialization obj = new SerializationDeserialization();
            // obj.Serialize();
            obj.Deserialize();
            Console.ReadKey();

            
        }
    }
}
