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

namespace Quiz_Game_WPF_MOO_ICT
{

    public partial class MainWindow : Window
    {
        List<int> questionNumbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int qNum = 0;
        int i;
        int score;


        public MainWindow()
        {
            InitializeComponent();

            
            StartGame();
            NextQuestion();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            
            Button senderButton = sender as Button; 

            
            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }


            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {

                qNum++;
            }
            scoreText.Content = "Правильных ответов " + score + "/" + questionNumbers.Count;
            NextQuestion();

        }

        private void RestartGame()
        {
            
            score = 0; 
            qNum = -1; 
            i = 0; 
            StartGame(); 
        }

        private void NextQuestion()
        {
            
            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                RestartGame();
            }

           foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkSalmon;
            }

            switch (i)
            {
                case 1:

                    txtQuestion.Text = "Что такое информационные технологии (ИТ)? \nа) Процессы, методы поиска, сбережения и распространения информации, а также способы осуществления этих процессов. \nб) Технологии для получения генной информации. \nв) Носители информации. \nг) Технологии для создания искусственного интеллекта."; 

                    ans1.Content = "а)"; 
                    ans2.Content = "б)";
                    ans3.Content = "в)";
                    ans4.Content = "г)";

                    ans1.Tag = "1"; 

                  

                    break; 

                case 2:

                    txtQuestion.Text = "Кто такие IT-специалисты? \nа) Специалисты в области информационных систем. \nб) Знатоки высоких технологий. \nв) Работники ремонтных бригад. \nг) Специалисты по продажам компьютерной техники.";

                    ans1.Content = "а)";
                    ans2.Content = "б)";
                    ans3.Content = "в)";
                    ans4.Content = "г)";

                    ans1.Tag = "1";

           

                    break;

                case 3:

                    txtQuestion.Text = "Когда появился термин «информационные технологии» в современном значении? \nа) В 1893 году. \nб) В 1990 году. \nв) В 1958 году. \nг) В 2000 году.";

                    ans1.Content = "а)";
                    ans2.Content = "б)";
                    ans3.Content = "в)";
                    ans4.Content = "г)";

                    ans3.Tag = "1";

                 

                    break;

                case 4:

                    txtQuestion.Text = "В каком году компанией IBM был выпущен первый в истории жесткий диск? \nа) В 1956 году. \nб) В 1958 году. \nв) В 1955 году. \nг) В 1960 году.";

                    ans1.Content = "а)";
                    ans2.Content = "б)";
                    ans3.Content = "в)";
                    ans4.Content = "г)";

                    ans3.Tag = "1";

                 

                    break;

                case 5:

                    txtQuestion.Text = "Какая поисковая система была самой популярной в 2011 году (согласно данным компании Net Applications)? \nа) Yahoo! \nб) Google. \nв) Bing. \nг) Yandex.";

                    ans1.Content = "а)";
                    ans2.Content = "б)";
                    ans3.Content = "в)";
                    ans4.Content = "г)";

                    ans2.Tag = "1";

                    break;
                case 6:

                    txtQuestion.Text = "Что такое база данных в ИТ? \nа) Совокупность данных, организованных по определенным правилам и доступных для обработки. \nб) Совокупность данных, хранящихся на жестком диске компьютера. \nв) Совокупность данных, передаваемых по сети. \nг) Совокупность данных, защищенных от несанкционированного доступа.";

                    ans1.Content = "а)";
                    ans2.Content = "б)";
                    ans3.Content = "в)";
                    ans4.Content = "г)";

                    ans1.Tag = "1";

                    break;
                case 7:

                    txtQuestion.Text = "Что такое программное обеспечение в ИТ? \nа) Набор инструкций и правил, определяющих работу компьютера или другого устройства. \nб) Набор аппаратных компонентов, необходимых для работы компьютера или другого устройства. \nв) Набор документов, описывающих функциональность и требования к компьютеру или другому устройству. \nг) Набор сервисов и приложений, предоставляемых пользователям компьютера или другого устройства.";

                    ans1.Content = "а)";
                    ans2.Content = "б)";
                    ans3.Content = "в)";
                    ans4.Content = "г)";

                    ans1.Tag = "1";

                    break;
                case 8:

                    txtQuestion.Text = "Как называется процесс создания программного обеспечения в ИТ? \nа) Программирование. \nб) Компиляция. \nв) Декомпиляция. \nг) Дебаггинг.";

                    ans1.Content = "а)";
                    ans2.Content = "б)";
                    ans3.Content = "в)";
                    ans4.Content = "г)";

                    ans1.Tag = "1";

                    break;
                case 9:

                    txtQuestion.Text = "Как называется специальный язык, используемый для создания веб-страниц в ИТ? \nа) HTML. \nб) SQL. \nв) XML. \nг) PHP.";

                    ans1.Content = "а)";
                    ans2.Content = "б)";
                    ans3.Content = "в)";
                    ans4.Content = "г)";

                    ans1.Tag = "1";

                    break;

                case 10:

                    txtQuestion.Text = "Как называется процесс проверки и устранения ошибок в программном обеспечении в ИТ? \nа) Тестирование. \nб) Отладка. \nв) Верификация. \nг) Валидация.";

                    ans1.Content = "а)";
                    ans2.Content = "б)";
                    ans3.Content = "в)";
                    ans4.Content = "г)";

                    ans2.Tag = "1";

                    break;
            }
        }

        private void StartGame()
        {

            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();


            questionNumbers = randomList;

   
            questionOrder.Content = null;

          
            for (int i = 0; i < questionNumbers.Count; i++)
            {
                questionOrder.Content += " " + questionNumbers[i].ToString();
            }

        }
    }
}
