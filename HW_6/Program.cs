using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    class UserUI
    {
        public string userName { get; set; }
        public string userPass { get; set; }

        public void PrintValues()
        {
            Console.WriteLine("userName = " + userName);
            Console.WriteLine("userPass = " + userPass);
        }

    }

    [MapAttribute(mappingClassName = "UserUI")]
    class UserDB
    {
        [MapAttribute(mappingFiledName = "userName")]
        public string name { get; set; }
        [MapAttribute(mappingFiledName = "userPass")]
        public string pass { get; set; }

        public void PrintValues()
        {
            Console.WriteLine("name = "+name);
            Console.WriteLine("pass = " + pass);
        }

    }
    

    class Program
    {
        static void Main(string[] args)
        {
            UserUI UIman = new UserUI() { userName = "dude", userPass = "qweryou" };
            MappingManager<UserUI, UserDB> mapper = new MappingManager<UserUI, UserDB>();
            UserDB DBman = mapper.mapObject(UIman);
            UIman.PrintValues();
            Console.WriteLine("\r\n");
            DBman.PrintValues();
            Console.ReadLine();
        }
    }
}
