using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OOP3
{
    class JSONSerializer 
    {
        const String path = "Employee.json";
        public String Serialized;
        JsonSerializer serializer = new JsonSerializer();

        public void Serialize(List<Employee> employees)
        {           
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            StreamWriter sw = new StreamWriter(path, false);
            Serialized = JsonConvert.SerializeObject(employees, settings);
            sw.WriteLine(Serialized);
            sw.Close();
        }

        public List<Employee> Deserialize()
        {
            using (StreamReader r = new StreamReader(path))
            {
                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                string json = r.ReadToEnd();
                List<Employee> empl = JsonConvert.DeserializeObject<List<Employee>>(json, settings);
                return empl;
            }
        }
    }
}
