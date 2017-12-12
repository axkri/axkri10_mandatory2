using Axkri10_Draw.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace Axkri10_Draw
{
    
    public class XmlSerialization
    {
        
        private string XmlFileSubmissions = "~/App_Data/submissions.xml";
        private string XmlSerials = "~/App_Data/serials.xml";
        
        private XmlSerializer serializer;

        public void Serialize<T>(List<T> list, String fileName)
        {
            if (list == null) { return; }

            try
            {
                XmlDocument xmldoc = new XmlDocument();

                serializer = new XmlSerializer(list.GetType());

                using (FileStream stream = new FileStream(fileName, FileMode.Create))
                {
                    serializer.Serialize(stream, list);
                    stream.Position = 0;
                    xmldoc.Load(stream);
                    xmldoc.Save(fileName);
                    stream.Close();
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);

            }
        }

        public List<T> Deserialize<T>(String fileName)
        {
            var itemList = new List<T>();
            serializer = new XmlSerializer(typeof(List<T>));
            if (!File.Exists(fileName))
            {
                return itemList;
            }
            try
            {
                using (FileStream stream = new FileStream(fileName, FileMode.Open))
                {
                    itemList = (List<T>)serializer.Deserialize(stream);

                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.StackTrace);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return itemList;
        }

        public string GetSubmissionXML()
        {
            return XmlFileSubmissions;
        }

        public string GetSerialXML()
        {
            return XmlSerials;
        }
    }
}