using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.View
{
    internal interface IView
    {
        public void SetDataToText(Object item);
        public void GetDataFromText();
    }
}
