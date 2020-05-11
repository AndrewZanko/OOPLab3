using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Text.Json;
using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;

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
            JsonWriter jsonWriter = new JsonTextWriter(sw);
            
            serializer.Serialize(jsonWriter, employees);
            Serialized = JsonConvert.SerializeObject(employees, settings);
            /* using (StreamWriter sc = new StreamWriter(path, false))
             {
                 sc.WriteLine(Serialized);
             }*/
            sw.WriteLine(Serialized);
            jsonWriter.Close();
            sw.Close();

            /*
             * 
             * using (StreamWriter sw = new StreamWriter(path,false))
                {
                    sw.WriteLine(Serialized);
                }
             */
        }

        /* public  List<Employee> Deserialize()
         {

             JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
 string Serialized = JsonConvert.SerializeObject(inheritanceList, settings);


             using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
             {
                 //List<Employee> employees = JsonConvert.DeserializeObject<List<Employee>>(Serialized, settings);
                 return employees;
             }
         }*/
        public List<Employee> Deserialize()
        {
            /*List<Employee> obj = null;
            JsonSerializer serializer = new JsonSerializer();
            StreamReader sr = new StreamReader(path);
            JsonReader jsonReader = new JsonTextReader(sr);
            obj = serializer.Deserialize(jsonReader) as List<Employee>;
            jsonReader.Close();
            sr.Close();
            return obj;
            
             
             JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string Serialized = JsonConvert.SerializeObject(inheritanceList, settings);
            List<Base> deserializedList = JsonConvert.DeserializeObject<List<Base>>(Serialized, settings);
             
             */
            /*  JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
              string Serialized = JsonConvert.SerializeObject(employees, settings);*/

            using (StreamReader r = new StreamReader(path))
            {
                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                //string json = r.ReadToEnd();
                string json = r.ReadToEnd();
                List<Employee> empl = JsonConvert.DeserializeObject<List<Employee>>(json, settings);
                return empl;
            }
        }
    }
}
