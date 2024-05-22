using BookApplication.ClassHelper;
using BookApplication.DB;
using BookApplication.Windows.AdminWindows;
using BookApplication.Windows.UserWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BookApplication.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            var authUser = EFClass.context.User.ToList()
                .Where(x => x.Email == TbEmail.Text && x.Password == PbPassword.Password).FirstOrDefault();

            if(!IsValidEmail(TbEmail.Text))
            {
                TblErrorMessage.Text = "НЕВЕРНЫЙ АДРЕС ЭЛ. ПОЧТЫ ИЛИ ПАРОЛЬ";
                TbEmail.Text = "";
                PbPassword.Password = "";
                return;
            }
            if (string.IsNullOrWhiteSpace(TbEmail.Text) ||  string.IsNullOrWhiteSpace(PbPassword.Password))
            {
                TblErrorMessage.Text = "НЕВЕРНЫЙ АДРЕС ЭЛ. ПОЧТЫ ИЛИ ПАРОЛЬ";
                TbEmail.Text = "";
                PbPassword.Password = "";
                return;
            }

            if (authUser.RoleID == 1)
            {
                ListLessonWindow.Auth(authUser).Show();

                Close();
            }
            else
            {
                AdminListLessonWindow.Auth(authUser).Show();
                Close();
            }
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

        private void TblSignUp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RegistrationWindow registration = new RegistrationWindow();
            registration.Show();
            Close();
        }
        private bool IsValidEmail(string email)
        {
            string emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailRegex);
        }
    }
}
