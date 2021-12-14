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

      


        //вызов события при нажате на кнопку
        private void Button_Start(object sender, RoutedEventArgs e)
        {
            start.Invoke(sender, e);
        }

        private void Button_Stop(object sender, RoutedEventArgs e)
        {

         
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
