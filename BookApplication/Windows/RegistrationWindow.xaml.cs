using BookApplication.ClassHelper;
using BookApplication.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }
        
        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbEmail.Text) || !IsValidEmail(TbEmail.Text))
            {
                TblErrorMaessage.Text = "НЕВЕРНЫЙ АДРЕС ЭЛ. ПОЧТЫ ИЛИ ПАРОЛЬ";
                TbEmail.Text = "";
                return;
            }
            User user = new User();

            user.Email = TbEmail.Text;
            user.FName = TbFName.Text;
            user.LName = TbLName.Text;
            user.MName = TbMName.Text;
            user.Password = PbPassword.Password;
            user.DateOfBirth = DateTime.Parse(DpDateOfBirth.Text);
            user.DateOfRegistration = DateTime.Now;
            user.RoleID = 1;

            EFClass.context.User.Add(user);
            EFClass.context.SaveChanges();
            MessageBox.Show("Вы успешно зарегистрировались");
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

        private void TblSignIn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            Close();
        }
        private bool IsValidEmail(string email)
        {
            string emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailRegex);
        }
    }
}
