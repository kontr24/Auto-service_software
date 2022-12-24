using AutoService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Class
{
    class GeneralClass
    {
        public enum Status { Admin = 1, User = 2} 
        public static int mode { get; set; } //Режим доступа
        public static string nickname { get; set; }//ник

    }
}
