using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_StructuresAndClasses
{
    public class Website
    {
        private string _name;
        private string _url;
        private string _description;
        private string _ip;

        public Website()
        {
        }


        public Website(string name, string url, string description, string ip)
        {
            this._name = name;
            this._url = url;
            this._description = description;
            this._ip = ip;
        }

        public void EnterInfo()
        {
            Website site = new Website();
            site._name = EnterString("Name-> ");
            site._url = EnterString("URL-> ");
            site._description = EnterString("Description-> ");
            site._ip = EnterString("IP-> ");
        }

        public void ExitInfo()
        {
            Console.WriteLine($"Info: \n " +
                $"Name-> {_name}\n" +
                $"URL-> {_url}\n" + 
                $"Description-> {_description}\n" +
                $"IP-> {_ip}");
        }
        public static string EnterString(string prompt)
        {
            Console.Write($"\t{prompt}: ");
            string str = Console.ReadLine();
            str = str.Trim();
            return str;
        }

    }
}
