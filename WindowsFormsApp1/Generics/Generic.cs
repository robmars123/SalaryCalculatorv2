using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator
{
    public class Generic<T> : Form
    {
        public T Text { get;set; }
    }
}
