using PRN292_SE1403_NXP.Controller;
using PRN292_SE1403_NXP.Model;
using System;

namespace PRN292_SE1403_NXP
{
    class Program
    {
        static void Main(string[] args)
        {
            GVManager gv = new GVManager();
            gv.menu();
        }
    }
}
