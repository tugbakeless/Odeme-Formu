using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etut_form
{
    abstract class Banka
    {
        public int para{get; set;}
        abstract public void ode();
    }

    class Banka1 : Banka
    {
        public override void ode()
        {
          MessageBox.Show(para.ToString()+" lira ödeme alındı."); 
        }
    }
    class Banka2 : Banka
    {
        public override void ode()
        {
            MessageBox.Show(para.ToString()+" lira ödeme alındı.");
        }
    }
}
