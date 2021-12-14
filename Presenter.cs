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


        private readonly Model model;//переменная нашей модели поведения
        private readonly MainWindow viev;//переменная текущего окна
        WriteToFile writeToFile = new WriteToFile();



        public Presenter(MainWindow mainWindow)//конструктор
        {
            model = new Model();//создание экземпляра модели
            viev = mainWindow;//захват экземпляра окна
            viev.StartE += Viev_Start;//подписка на событие при кнопке старт                    
            viev.ResetE += Viev_ResetE;//
            viev.dispatcherTimer.Interval = new TimeSpan(0, 0, 1);// параметры таимера 1сек
            viev.dispatcherTimer.Tick += Timer1_Tick;//что делать на каждый тик
            viev.dispatcherTimer.Start();//запуск таимера
            viev.dispatcherTimer.IsEnabled = false;

        }


        private void Timer1_Tick(object sender, EventArgs e)
        {

            viev.TimeBox.Text = model.Tick2();//закинуть в текстбокс то что прописанно в model.Tick

        }

        private void Viev_ResetE(object sender, EventArgs e)
        {

            if (Model.stopWatch.IsRunning)
            {
                viev.EndTime.Content += model.InToCollection().ToString(@"HH\:mm\:ss") + "\n";

            }

            model.RsetlistOfDataNow();

            viev.Otmetka.Content = "";
            TimeSpan temporaryItem = new TimeSpan();


            foreach (var item in Model.timeSpanList)
            {
                temporaryItem += item;//сложение показвний

                viev.Otmetka.Content += item.ToString(@"hh\:mm\:ss") + " \n";
            }


            viev.Summ.Content = model.GetTimeSpan();

            model.StopWatchReset();//остановка таимера и обнуление

            string jsonString = JsonSerializer.Serialize(model.Tick2());//серилизация
            writeToFile.Write(jsonString);//запись в фаил

        }


        private void Viev_Start(object sender, EventArgs e)
        {
            DateTime dateTimeNow = DateTime.Now;
            viev.dispatcherTimer.IsEnabled = true;

            if (!Model.stopWatch.IsRunning)
            {
                viev.BeginTime.Content += dateTimeNow.ToString(@"HH\:mm\:ss") + "\n";

            }
            model.StartTimer();

        }




    }




}
