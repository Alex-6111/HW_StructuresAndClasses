using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_StructuresAndClasses
{
    public class Shop
    {
        private string _name;
        private string _year;
        private string _description;
        private string _phoneNumber;
        private string _email;

        public Shop()
        {
            _name = "Apple";
            _year = "1990.01.11";
            _description = "Electronic shop";
            _phoneNumber = "+111111111111111";
            _email = "appleshop@apple.com";
        }

        public Shop(string name, string year, string description, string phoneNumber, string email)
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
