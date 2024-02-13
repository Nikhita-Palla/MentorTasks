using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialisation_Deserialisation
{
    public class Class1
    {
        public static void Serialize<T>(string dirPath, T objName)
        {
            Directory.CreateDirectory(dirPath);
            string typeName=typeof(T).Name;
  
            string filePath = Path.Combine(dirPath, typeName);

            using (FileStream fileStream = new FileStream(filePath, FileMode.Append))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, objName);
            }
        }

        public static T Deserialize<T>(string dirPath)
        {
            string typeName = typeof(T).Name;

            string filePath = Path.Combine(dirPath, typeName);

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (T)formatter.Deserialize(fileStream);
            }
        }

    }
}
