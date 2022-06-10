using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class Action
    {
        public static int Insert()
        {
            return 1;
        }
        public static int Update()
        {
            return 4;
        }
        public static int Delete()
        {
            return 2;
        }
        public static int UpdateDelete()
        {
            return 3;
        }

    }
}
