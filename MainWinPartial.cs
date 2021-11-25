using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TimerNote
{
    public partial class MainWindow : Window
    {


        #region делигаты
        private EventHandler start;
        // private EventHandler stop;
        private EventHandler reset;

        #endregion

        //события
        public event EventHandler StartE
        {
            add { start += value; }
            remove { start -= value; }
        }
        /*  public event EventHandler StopE
          {
              add { stop += value; }
              remove { stop -= value; }
          }*/
        public event EventHandler ResetE
        {
            add { reset += value; }
            remove { reset -= value; }

        }







    }
}
