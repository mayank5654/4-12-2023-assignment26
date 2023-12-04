using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace assignment26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 2: Binary Serialization and Deserialization
            Employee emp = new Employee
            {
                Id = 1,
                FirstName = "MAYANK",
                LastName = "KAUSHAL",
                Salary = 16691.0
            };

            BinarySerialization(emp);
            BinaryDeserialization();

            // Step 3: XML Serialization and Deserialization
            XmlSerialization(emp);
            XmlDeserialization();
        }

        // Step 2: Binary Serialization
        static void BinarySerialization(Employee employee)
        {
            // Serialize the Employee object to binary format and save to a file
            using (FileStream fileStream = new FileStream("employee.bin", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, employee);
            }
            Console.WriteLine("Binary Serialization Successful");
        }

        // Step 2: Binary Deserialization
        static void BinaryDeserialization()
        {
            // Deserialize the binary data from the file to an Employee object
            using (FileStream fileStream = new FileStream("employee.bin", FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Employee emp = (Employee)formatter.Deserialize(fileStream);

                // Display deserialized employee properties
                Console.WriteLine("\nBinary Deserialization Result:");
                DisplayEmployeeDetails(emp);
            }
        }

        // Step 3: XML Serialization
        static void XmlSerialization(Employee employee)
        {
            // Serialize the Employee object to XML format and save to a file
            using (FileStream fileStream = new FileStream("employee.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Employee));
                serializer.Serialize(fileStream, employee);
            }
            Console.WriteLine("XML Serialization Successful");
        }

        // Step 3: XML Deserialization
        static void XmlDeserialization()
        {
            // Deserialize the XML data from the file to an Employee object
            using (FileStream fileStream = new FileStream("employee.xml", FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Employee));
                Employee emp = (Employee)serializer.Deserialize(fileStream);

                // Display deserialized employee properties
                Console.WriteLine("\nXML Deserialization Result:");
                DisplayEmployeeDetails(emp);
            }
        }

        // Display Employee details
        static void DisplayEmployeeDetails(Employee emp)
        {
            Console.WriteLine($"ID: {emp.Id}");
            Console.WriteLine($"First Name: {emp.FirstName}");
            Console.WriteLine($"Last Name: {emp.LastName}");
            Console.WriteLine($"Salary: {emp.Salary}\n");
        }
    }
    
}
