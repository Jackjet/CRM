
using CRM_Handler.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool result = false;
            //DateTime dt = default(DateTime);
            //while (result == false)
            //{
            //    dt = NetTime.GetBeijingTime(ref result);
            //}


            //UpdateTime.SetDate(dt); 

            string x = "40.4855016";
            string y = "115.9572488";
            var model = PositionHelper.GeoCoder(x, y); //model拿到的就是详细物理地址


            var min = (DateTime.Now - Convert.ToDateTime("2017-10-10 21:17")).Minutes;
        }
    }
}
