using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    internal interface I1
    {
        void Fly();
        int a { get;  }
        int this [int i] { get; set; }
    }
}
