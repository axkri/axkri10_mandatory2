using Axkri10_Draw.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Axkri10_Draw
{

    public static class XmlSerialization
    {

        public static void WriteToXmlFile(SubFormModel subform, string path, Boolean append)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SubFormModel));
            using (TextWriter writer = new StreamWriter(path, append))
            {
                serializer.Serialize(writer, subform);
            }
        }


        public static void ReadFromXmlFile(SubFormModel subform, string path)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(SubFormModel));
            TextReader reader = new StreamReader(path);
            object obj = deserializer.Deserialize(reader);
            SubFormModel subformXmlData = (SubFormModel)obj;

            reader.Close();

        }
    }
}