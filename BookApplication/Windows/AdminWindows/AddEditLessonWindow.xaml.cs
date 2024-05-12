using BookApplication.ClassHelper;
using BookApplication.DB;
using BookApplication.Windows.UserWindows;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddEditLessonWindow.xaml
    /// </summary>
    public partial class AddEditLessonWindow : Window
    {
        //public static User User;

        private bool isEdit = false;
        private string pathImage = null;
        private Lesson editLesson;

        public AddEditLessonWindow()
        {
            InitializeComponent();
            isEdit = false;
        }

        //public AddEditLessonWindow Auth(User user)
        //{
        //    AddEditLessonWindow.User = user;
        //    return new AddEditLessonWindow();
        //}

        public AddEditLessonWindow(Lesson lesson)
        {
            InitializeComponent();

            TblStatus.Text = "ОКНО РЕДАКТИРОВАНИЯ";
            BtnAddEdit.Content = "ИЗМЕНИТЬ";
            pathImage = lesson.PhotoPath;
            TbTitle.Text = lesson.Title.ToString();
            TbContentLesson.Text = lesson.ContentLesson.ToString();

            if (lesson.PhotoPath != null)
            {
                try
                {
                    //using (MemoryStream stream = new MemoryStream(Convert.ToByte(lesson.PhotoPath)))
                    //{
                    //    BitmapImage bitmapImage = new BitmapImage();
                    //    bitmapImage.BeginInit();
                    //    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    //    bitmapImage.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                    //    bitmapImage.StreamSource = stream;
                    //    bitmapImage.EndInit();

                    //    if (lesson.PhotoPath != null)
                    //    {
                    //        ImgLesson.Source = bitmapImage;
                    //    }
                    //}
                    
                        ImgLesson.Source = new BitmapImage(new Uri($@"{pathImage}"));

                }
                catch (Exception e)
                {
                    ImgLesson.Source = null;
                }
            }

            isEdit = true;
            editLesson = lesson;
        }
        private void BtnAddEdit_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbTitle.Text))
            {
                MessageBox.Show("Поле \"Название\" не может быть пустым.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(TbContentLesson.Text))
            {
                MessageBox.Show("Поле \"Наполнение\" не может быть пустым.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (isEdit == true)
            {
                editLesson.Title = TbTitle.Text;
                editLesson.ContentLesson = TbContentLesson.Text;
                if(pathImage != null)
                {
                    editLesson.PhotoPath = pathImage;
                }
                EFClass.context.SaveChanges();
                MessageBox.Show("Урок успешно изменен", "Изменение", MessageBoxButton.OK, MessageBoxImage.Information);
                
                AdminListLessonWindow adminListLessonWindow = new AdminListLessonWindow();
                adminListLessonWindow.Show();
                this.Close();
            }
            else
            {
                Lesson lesson = new Lesson();
                lesson.Title = TbTitle.Text;
                lesson.ContentLesson = TbContentLesson.Text;
                lesson.PhotoPath = pathImage;

                EFClass.context.Lesson.Add(lesson);
                EFClass.context.SaveChanges();
                MessageBox.Show("Услуга успешно добавлена", "Добавление", MessageBoxButton.OK, MessageBoxImage.Information);

                AdminListLessonWindow adminListLesson = new AdminListLessonWindow();
                adminListLesson.Show();
                this.Close();
            }
        }

        private void BtnChooseImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == true)
            {
                ImgLesson.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                //pathImage = System.IO.Path.GetFileName(openFileDialog.FileName);
                pathImage = openFileDialog.FileName;
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
            ListLessonWindow listLessonWindow = new ListLessonWindow();
            listLessonWindow.Show();
            this.Close();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            AdminListLessonWindow adminListLesson = new AdminListLessonWindow();
            adminListLesson.Show();
            //AdminListLessonWindow.Auth(User).Show();
            this.Close();
        }
    }
}
