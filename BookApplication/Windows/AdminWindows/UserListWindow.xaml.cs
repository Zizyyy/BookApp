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

namespace BookApplication.Windows.AdminWindows
{
    /// <summary>
    /// Логика взаимодействия для UserListWindow.xaml
    /// </summary>
    public partial class UserListWindow : Window
    {
        public static User User;

        public UserListWindow()
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
            GetUserList();
        }

        public static UserListWindow Auth(User user)
        {
            UserListWindow.User = user;
            return new UserListWindow();
        }

        private void GetUserList()
        {
            List<User> listUser = new List<User>();

            listUser = EFClass.context.User.ToList();

            LvUser.ItemsSource = listUser;
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

        private void BtnLesson_Click(object sender, RoutedEventArgs e)
        {
            AdminListLessonWindow adminListLessonWindow = new AdminListLessonWindow();
            adminListLessonWindow.Show();
            Close();
        }
    }
}
