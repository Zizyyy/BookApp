using BookApplication.ClassHelper;
using BookApplication.DB;
using BookApplication.Windows.UserWindows;
using Microsoft.Win32;
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
    /// Логика взаимодействия для AddEditListTutorialWindow.xaml
    /// </summary>
    public partial class AddEditListTutorialWindow : Window
    {
        private bool isEdit = false;
        private Tutorial editTutorial;

        public AddEditListTutorialWindow()
        {
            InitializeComponent();
            CbListLesson.ItemsSource = EFClass.context.Lesson.ToList();
            CbListLesson.DisplayMemberPath = "Title";
            CbListLesson.SelectedIndex = 0;

            isEdit = false;
        }

        //public AddEditLessonWindow Auth(User user)
        //{
        //    AddEditLessonWindow.User = user;
        //    return new AddEditLessonWindow();
        //}

        public AddEditListTutorialWindow(Tutorial tutorial)
        {
            InitializeComponent();
            TblStatus.Text = "ОКНО РЕДАКТИРОВАНИЯ";
            BtnAddEdit.Content = "ИЗМЕНИТЬ";

            TbTitle.Text = tutorial.Title;
            TbUrlPath.Text = tutorial.UrlPath;

            editTutorial = tutorial;
            isEdit = true;
        }
        private void BtnAddEdit_Click(object sender, RoutedEventArgs e)
        {
            if(isEdit == true)
            {
                editTutorial.Title = TbTitle.Text;
                editTutorial.DateOfAddition = DateTime.Now;
                editTutorial.UrlPath = TbUrlPath.Text;
                editTutorial.LessonId = CbListLesson.SelectedIndex + 1;

                EFClass.context.SaveChanges();
                AdminListTutorialWindow adminListTutorial = new AdminListTutorialWindow();
                adminListTutorial.Show();
                this.Close();
            } 
            else
            {
                Tutorial tutorial = new Tutorial();
                tutorial.Title = TbTitle.Text;
                tutorial.DateOfAddition = DateTime.Now;
                tutorial.UrlPath = TbUrlPath.Text;
                tutorial.LessonId = CbListLesson.SelectedIndex + 1;

                MessageBox.Show("Видеорок успешно добавлена", "Добавление", MessageBoxButton.OK, MessageBoxImage.Information);
                AdminListTutorialWindow adminListTutorial = new AdminListTutorialWindow();
                adminListTutorial.Show();
                this.Close();
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
            AdminListTutorialWindow adminListTutorialWindow = new AdminListTutorialWindow();
            adminListTutorialWindow.Show();
            this.Close();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            AdminListTutorialWindow adminListTutorialWindow = new AdminListTutorialWindow();
            adminListTutorialWindow.Show();
            this.Close();
        }
    }
}