using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Text.Json;
using System.Diagnostics;

namespace TimerNote
{
    class Presenter
    {
        // var ser = new DataContractJsonSerializer(typeof(Person));

        private readonly Model model;//переменная нашей модели поведения
        private readonly MainWindow viev;//перевеная текущего окна
        WriteToFile writeToFile = new WriteToFile();
        //  DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        /*dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
                dispatcherTimer.Interval = new TimeSpan(0,0,1);
                dispatcherTimer.Start();*/

        public Presenter(MainWindow mainWindow)//конструктор
        {
            model = new Model();//создание экземпляра модели
            viev = mainWindow;//захват экземпляра окна
            viev.StartE += Viev_Start;//подписка на событие при кнопке старт
                                      //  viev.StopE += Viev_Stop;//подписка на событие при кнопке стоп
            viev.ResetE += Viev_ResetE;//
            //  viev.ResetE += Viev_ResetE;
            //  .dispatcherTimer.Interval(1000);

            viev.dispatcherTimer.Interval = new TimeSpan(0, 0, 1);// параметры таимера 1сек

            viev.dispatcherTimer.Tick += Timer1_Tick;//что делать на каждый тик

            viev.dispatcherTimer.Start();//запуск таимера
            viev.dispatcherTimer.IsEnabled = false;//??



            /* 
             * viev.timer1.Tick += Timer1_Tick;

              viev.timer2.Tick += Timer2_Tick;
              viev.timer1.Start();
              viev.timer1.Enabled = false;*/


        }





        /*  private void Timer2_Tick(object sender, EventArgs e)
          {


              if (viev.panel1.BackColor == System.Drawing.Color.Transparent)
                  viev.panel1.BackColor = System.Drawing.Color.Red;
              else
              {
                  viev.panel1.BackColor = System.Drawing.Color.Transparent;
              }

          }*/

        private void Timer1_Tick(object sender, EventArgs e)
        {

            viev.TimeBox.Text = model.Tick2();//закинуть в текстбокс то что прописанно в model.Tick



        }

        private void Viev_ResetE(object sender, EventArgs e)
        {
            //  viev.dispatcherTimer.Stop();//оствноывка таимера
            //viev.TimeBox.Clear();//отчитвка формы
            //TimeSpan s1 = TimeSpan.Parse(model.Tick());
            // viev.Otmetka.Content = s1;
            if (Model.stopWatch.IsRunning)
            {
                viev.EndTime.Content += model.InToCollection().ToString(@"HH\:mm\:ss") + "\n";

            }

            model.RsetlistOfDataNow();
            //  viev.Otmetka.Content = model.Tick2();//переброска значения в другую форму


            viev.Otmetka.Content = "";
            TimeSpan temp2 = new TimeSpan();

            // viev.Otmetka.Content = dt1.ToString(@"hh\:mm\:ss") + "  ";
            foreach (var item in Model.Mlist)
            {
                temp2 += item;//сложение показвний

                viev.Otmetka.Content += item.ToString(@"hh\:mm\:ss") + " \n";
            }

            /*  foreach (var item in Model.DataTi)
              {
                  viev.Otmetka2.Content += item.ToString(@"hh\:mm\:ss") + " \n";
              }*/



            //  viev.Otmetka.Content +=  model.GetTimeSpan();

            // viev.Summ.Content = temp2.ToString(@"hh\:mm\:ss");
            viev.Summ.Content = model.GetTimeSpan();

            // viev.Otmetka.Content = model.OutCilection();

            model.Reset2();//остановка таимера и обнуление





            string jsonString = JsonSerializer.Serialize(model.Tick2());//серилизация
            writeToFile.Write(jsonString);//запись в фаил

            //  viev.TimeBox.Text = "0 sec 0 min";//начальные значение по умолчанию





            //  writeToFile.Write(model.Tick());//запись в фаил 



            /*  viev.TimeBox textBox = (viev.TimeBox)sender;
                      MessageBox.Show(textBox.Text);*/
            //  viev.timer2.Stop();
            //  viev.panel1.BackColor = System.Drawing.Color.Transparent;
            // throw new NotImplementedException();
        }

        /*   private void Viev_Stop(object sender, EventArgs e)// что делать на стопе
           {
               viev.dispatcherTimer.IsEnabled = false; //?? остановка таимера или показать таимер?
               //  viev.timer2.Enabled = false;
               // viev.panel1.BackColor = System.Drawing.Color.Transparent;
           }*/

        private void Viev_Start(object sender, EventArgs e)
        {
            DateTime dateTimeNow = DateTime.Now;
            viev.dispatcherTimer.IsEnabled = true;

            if (!Model.stopWatch.IsRunning)
            {
                viev.BeginTime.Content += dateTimeNow.ToString(@"HH\:mm\:ss") + "\n";

            }
            model.Start2();

            // viev.BeginTime.Content += dateTimeNow.ToString(@"hh\:mm\:ss") + "\n";
            // viev.timer2.Enabled = true;
        }




    }




}
