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

namespace Test
{
    public partial class MainWindow : Window
    {
        List<QuestionClass> questionClasses;
        int counter = 0;
        List<string> selectedValue = new List<string>();
        List<string> corans = new List<string>();
        List<int> idofv = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
            questionClasses = new List<QuestionClass>();
            FillList();
            for(int i = 0; i < 10; i++)
            {
                selectedValue.Add("");
                idofv.Add(i);
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton item)
            {
                selectedValue[counter] = item.Content.ToString();

            }
        }

        private void FillList()
        {
            questionClasses.Add(new QuestionClass("https://stopfire.ru/wp-content/cache/thumb/47/b5d8231d0804a47_470x340.jpg", 1, "Верны ли следующие суждения? А. " +
                "Выделение теплоты свидетельствует о протекании химической реакции. Б. " +
                "Испарение жидкой воды - это химическая реакция.", "оба суждения неверны",
                "верны оба суждения", "верно только Б", "верно только А", 4, "верно только А"));
            questionClasses.Add(new QuestionClass("https://o.quizlet.com/BwQJ0PmmBdT3nKOjztMUrw.png", 2, "Верны ли следующие суждения? А. " +
                "Выпадение осадка свидетельствует о протекании химической реакции. Б. " +
                "Чем больше площадь соприкосновения реагентов, тем быстрее идет химическая " +
                "реакция.", "оба суждения неверны", "верны оба суждения", "верно только Б", 
                "верно только А", 2, "верны оба суждения"));
            questionClasses.Add(new QuestionClass("https://thumbs.dreamstime.com/b/%D1%85%D0%B8%D0%BC%D0%B8%D1%87%D0%B5%D1%81%D0%BA%D0%B0%D1%8F-%D1%80%D0%B5%D0%B0%D0%BA%D1%86%D0%B8%D1%8F-%D0%B2-%D1%81%D1%82%D0%B5%D0%BA-%D0%B5-%D0%BE%D0%B1%D1%8A%D0%B5%D0%BC%D0%BD%D0%BE%D0%B9-%D1%81%D0%BA-%D1%8F%D0%BD%D0%BA%D0%B8-%D0%B2-labolatory-46933667.jpg", 3, "В ходе химической реакции количество " +
                "вещества продуктов реакции", "может как увеличиваться, так и уменьшаться", 
                "не меняется", "только уменьшается", "только увеличивается", 4, "только увеличивается"));
            questionClasses.Add(new QuestionClass("https://i.ytimg.com/vi/OEcY6X4e0rg/maxresdefault.jpg", 4, "Приставка <экзо> означает", "направо", 
                "наружу", "внутрь", "налево",2, "наружу"));
            questionClasses.Add(new QuestionClass("https://i.ytimg.com/vi/OEcY6X4e0rg/maxresdefault.jpg", 5, "Экзотермическая реакция - это реакция, " +
                "протекающая", "с поглощением теплоты", "с выделением теплоты", "с образованием " +
                "осадка", "с выделением газа", 2, "с выделением теплоты"));
            questionClasses.Add(new QuestionClass("https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/Mercury%28I%29_oxide.png/236px-Mercury%28I%29_oxide.png", 6, "Верны ли следующие суждения? А. " +
                "Реакция разложения оксида ртути (II) - это экзотермическая реакция. " +
                "Б.Экзотермическая реакция протекает с выделением теплоты.", "оба суждения неверны", 
                "верны оба суждения", "верно только Б", "верно только А", 3, "верно только Б"));
            questionClasses.Add(new QuestionClass("http://www.gogetnews.info/uploads/posts/2013-03/1363984721_himik-otravil-vsyu-svoyu-semyu.jpg", 7, "К химическим реакциям относится явление", 
                "взаимодействие CaCO3 с соляной кислотой", "растворение сахара в воде", 
                "притягивание железа к магниту", "испарение воды", 1, "взаимодействие CaCO3 с " +
                "соляной кислотой"));
            questionClasses.Add(new QuestionClass("http://www.gogetnews.info/uploads/posts/2013-03/1363984721_himik-otravil-vsyu-svoyu-semyu.jpg", 8, "К химическим реакциям относится явление", 
                "вытягивание проволоки", "дистилляция воды", "центрифугирование смеси", 
                "пропускание углекислого газа через известковую воду",4, "пропускание " +
                "углекислого газа через известковую воду"));
            questionClasses.Add(new QuestionClass("https://i.ytimg.com/vi/OEcY6X4e0rg/maxresdefault.jpg", 9, "Верны ли следующие суждения? А. Эндотермическая реакция " +
                "протекает с поглощением теплоты. Б. Реакция горения - это экзотермическая реакция.", "" +
                "оба суждения неверны", "верны оба суждения", "верно только Б", "верно только А", 2, "верны оба суждения"));
            questionClasses.Add(new QuestionClass("https://i.ytimg.com/vi/OEcY6X4e0rg/maxresdefault.jpg", 10, "Эндотермическая реакция - это реакция, протекающая", 
                "с поглощением теплоты", "с выделением теплоты", "с выделением газа", "с образованием осадка", 1,
                "с поглощением теплоты"));
            corans.Add("верно только А");
            corans.Add("верны оба суждения");
            corans.Add("только увеличивается");
            corans.Add("наружу");
            corans.Add("с выделением теплоты");
            corans.Add("верно только Б");
            corans.Add("взаимодействие CaCO3 с соляной кислотой");
            corans.Add("пропускание углекислого газа через известковую воду");
            corans.Add("верны оба суждения");
            corans.Add("с поглощением теплоты");
        }

        private void NextQuestion_Click(object sender, RoutedEventArgs e)
        {
            if(AnswerID.IsChecked==true | AnswerID2.IsChecked==true | AnswerID3.IsChecked==true | AnswerID4.IsChecked == true)
            {
                if (counter != 9)
                {
                    counter++;
                    AnswerID.IsChecked = false;
                    AnswerID2.IsChecked = false;
                    AnswerID3.IsChecked = false;
                    AnswerID4.IsChecked = false;
                    NumOfQuestion.Text = "Вопрос №" + Convert.ToString(questionClasses[counter].QuestNumv);
                    Question.Text = questionClasses[counter].Question;
                    AnswerID.Content = questionClasses[counter].Answer1;
                    AnswerID2.Content = questionClasses[counter].Answer2;
                    AnswerID3.Content = questionClasses[counter].Answer3;
                    AnswerID4.Content = questionClasses[counter].Answer4;
                    Photochka.Source = new BitmapImage(new Uri(questionClasses[counter].Ph));
                }
                else
                {
                    CountOfAnswers.Text = "Кол-во правильных ответов:";
                    CountOFA.Text = Convert.ToString(counter);
                    MessageBox.Show("Сейчас будет показана таблица с правильными ответами." +
                        "\nЕсли текст зелёный - вы ответили правильно,Иначе вы ответили неправильно.", "Конец теста!", MessageBoxButton.OK);
                    Test.Visibility = Visibility.Hidden;
                    table.Visibility = Visibility.Visible;
                    if (selectedValue[0] == corans[0]) d1.Foreground = Brushes.Green;
                    else d1.Foreground = Brushes.Red;
                    if (selectedValue[1] == corans[1]) b2.Foreground = Brushes.Green;
                    else b2.Foreground = Brushes.Red;
                    if (selectedValue[2] == corans[2]) d3.Foreground = Brushes.Green;
                    else d3.Foreground = Brushes.Red;
                    if (selectedValue[3] == corans[3]) b4.Foreground = Brushes.Green;
                    else b4.Foreground = Brushes.Red;
                    if (selectedValue[4] == corans[4]) b5.Foreground = Brushes.Green;
                    else b5.Foreground = Brushes.Red;
                    if (selectedValue[5] == corans[5]) c6.Foreground = Brushes.Green;
                    else c6.Foreground = Brushes.Red;
                    if (selectedValue[6] == corans[6]) a7.Foreground = Brushes.Green;
                    else a7.Foreground = Brushes.Red;
                    if (selectedValue[7] == corans[7]) d8.Foreground = Brushes.Green;
                    else d8.Foreground = Brushes.Red;
                    if (selectedValue[8] == corans[8]) b9.Foreground = Brushes.Green;
                    else b9.Foreground = Brushes.Red;
                    if (selectedValue[9] == corans[9]) a10.Foreground = Brushes.Green;
                    else a10.Foreground = Brushes.Red;
                }
            }
            else
            {
                MessageBox.Show("Вам необходимо ответить на вопрос!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PreviousQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (counter != 0)
            {
                counter--;
                AnswerID.IsChecked = false;
                AnswerID2.IsChecked = false;
                AnswerID3.IsChecked = false;
                AnswerID4.IsChecked = false;
                NumOfQuestion.Text = "Вопрос №" + Convert.ToString(questionClasses[counter].QuestNumv);
                Question.Text = questionClasses[counter].Question;
                AnswerID.Content = questionClasses[counter].Answer1;
                AnswerID2.Content = questionClasses[counter].Answer2;
                AnswerID3.Content = questionClasses[counter].Answer3;
                AnswerID4.Content = questionClasses[counter].Answer4;
            }
            else
            {
                MessageBox.Show("Ошибка возврата!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            NumOfQuestion.Text = "Вопрос №" + Convert.ToString(questionClasses[counter].QuestNumv);
            Question.Text = questionClasses[counter].Question;
            AnswerID.Content = questionClasses[counter].Answer1;
            AnswerID2.Content = questionClasses[counter].Answer2;
            AnswerID3.Content = questionClasses[counter].Answer3;
            AnswerID4.Content = questionClasses[counter].Answer4;
            Photochka.Source = new BitmapImage(new Uri(questionClasses[counter].Ph));
            Start.Visibility = Visibility.Hidden;
            Test.Visibility = Visibility.Visible;
        }
    }
}
