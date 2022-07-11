using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_StructuresAndClasses
{
    public class Journal
    {

        private string _name;
        private string _year;
        private string _description;
        private string _phoneNumber;
        private string _email;

        public Journal()
        {
            _name = "TopGear";
            _year = "2008.05.17";
            _description = "Car info";
            _phoneNumber = "+14848646462";
            _email = "topgear@mail.com";
        }

        public Journal(string name, string year, string description, string phoneNumber, string email)
        {
            this._name = name;
            this._year = year;
            this._description = description;
            this._phoneNumber = phoneNumber;
            this._email = email;
        }


        public void PrintInfo()
        {
            Console.WriteLine($"Info:\n" +
                $" Name -> {_name},\n" +
                $" Year -> {_year},\n" +
                $" Description -> {_description},\n " +
                $"Phone number -> {_phoneNumber}, \n" +
                $"Email -> {_email}.");
        }

    }

        
}
