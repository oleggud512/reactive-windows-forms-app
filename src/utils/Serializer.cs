using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PrOOPz3.src.utils
{
    public class Serializer
    {
        public static void SerializeToJSON<T>(ref T inObject, string inFileName)
        {
            FileStream stream1 = new FileStream(inFileName, FileMode.Create);
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            ser.WriteObject(stream1, inObject);
            stream1.Close();
        }

        public static T? DeserializeFromJSON<T> (string inFileName)
        {
            if (System.IO.File.Exists(inFileName))
            {
                FileStream stream1 = new FileStream(inFileName, FileMode.Open);
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                T obj = (T)ser.ReadObject(stream1)!;
                stream1.Close();
                return obj;
            }
            return default;
        }
    }
}
