using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    class Class1
    {
        public double Balance { get; set; }
        public string Name { get; set; }

        public void ChangeBalance(double money)
        {

            Balance = Balance + money;
        }
    }
}
