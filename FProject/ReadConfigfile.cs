using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using FProject;

namespace FProject
{
     public class ReadConfigfile
    {
        public static string url;
        public static string name;
        public static string password;
   
        public static void ReadFile()
        {

            XmlTextReader reader = new XmlTextReader("C:\\Users\\elizabeth.perez\\source\\repos\\FProject\\FProject\\Credentials.xml");
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {

                    switch (reader.Name.ToString())
                    {
                        case "baseurl":
                            url = reader.ReadString();
                            break;
                        case "name":
                            name = reader.ReadString();
                            break;
                        case "password":
                            password = reader.ReadString();
                            break;
                    }
                }

            }
        }
    }
}
