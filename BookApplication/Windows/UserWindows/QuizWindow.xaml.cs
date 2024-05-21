using BookApplication.ClassHelper;
using BookApplication.DB;
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
using System.Windows.Shapes;

namespace BookApplication.Windows.UserWindows
{
    /// <summary>
    /// Логика взаимодействия для QuizWindow.xaml
    /// </summary>
    public partial class QuizWindow : Window
    {
        private int points = 0;

        public static User User;

        public QuizWindow()
        {
            InitializeComponent();
            TblRole.Text = User.Role.Title + ": ";
            if (User.MName == "")
            {
                TblName.Text = $"{User.LName} {User.FName.Substring(0, 1)}.";
            }
            else
            {
                TblName.Text = $"{User.LName} {User.FName.Substring(0, 1)}. {User.MName.Substring(0, 1)}.";
            }
        }

        public static QuizWindow Auth(User user)
        {
            User = user;
            return new QuizWindow();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void BtnClose_MouseDown(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnProfile_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null) { return; }
            var user = button.DataContext as User;
            ProfileUserWindow profileUserWindow = new ProfileUserWindow(User);
            profileUserWindow.Show();
            Close();
        }

        private void BtnVideoLesson_Click(object sender, RoutedEventArgs e)
        {
            ListVideoWindow.Auth(User).Show();
            Close();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            Close();
        }

        private void BtnLesson_Click(object sender, RoutedEventArgs e)
        {
            ListLessonWindow.Auth(User).Show();
            Close();
        }

        private void BtnComplete_Click(object sender, RoutedEventArgs e)
        {
            if(RbTwo.IsChecked == true)
            {
                points++;
            }
            if(CbFirst.IsChecked == true &&
               CbThird.IsChecked == true &&
               CbFourth.IsChecked == true && CbSecond.IsChecked != true)
            {
                points++;
            }
            if (RbFourth.IsChecked == true)
            {
                points++;
            }
            if(RbSeventh.IsChecked == true)
            {
                points++;
            }
            if(RbTwelfth.IsChecked == true)
            {
                points++;
            }
            if(RbFifteenth.IsChecked == true)
            {
                points++;
            }
            if(CbSeventh.IsChecked == true && CbFifth.IsChecked !=true && CbSixth.IsChecked !=true)
            {
                points++;
            }
            if(RbEighteenth.IsChecked == true)
            {
                points++;
            }
            if(RbTwentieth.IsChecked == true)
            {
                points++;
            }
            if(CbNine.IsChecked == true || CbTen.IsChecked != true || CbEleven.IsChecked != true)
            {
                points++;
            }
            
            Quiz quiz = new Quiz();
            quiz.UserID = User.Id;
            quiz.DateOfCompletion = DateTime.Now;
            quiz.Result = points;
            EFClass.context.Quiz.Add(quiz);
            EFClass.context.SaveChanges();
            var mbb = MessageBox.Show($"Ваш Результат:{points}", "Изменение", MessageBoxButton.OK, MessageBoxImage.Information);
            if(mbb == MessageBoxResult.OK)
            {
                QuizWindow quizWindow = new QuizWindow();
                quizWindow.Show();
                Close();
            }
            points = 0;
        }
    }
}
