using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sayısal_Loto
{
    class hata:Exception
    {
        public hata(string message):base(message)
        {

        }
    }
}
