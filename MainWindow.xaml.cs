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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();//иниц всех компонетов формы
            new Presenter(this);//создание экзкмпляра
            new TimeProcessing(SystemClockLable);
        }
       
        public DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();//создание экземпляра таимера

        /*     #region делигаты
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
           *//*  public event EventHandler StopE
             {34
                 remove { stop -= value; }3336722
             }*//*
             public event EventHandler ResetE
             {
                 add { reset += value; }
                 remove { reset -= value; }

             }*/


        //вызов события при нажате на кнопку
        private void Button_Start(object sender, RoutedEventArgs e)
        {
            start.Invoke(sender, e);
        }

        private void Button_Stop(object sender, RoutedEventArgs e)
        {

            //stop.Invoke(sender, e);
            reset.Invoke(sender, e);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
    }
}
