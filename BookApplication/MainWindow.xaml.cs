using BookApplication.ClassHelper;
using BookApplication.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
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

namespace BookApplication
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayVideoFromYandexDisk()
        {
            //Замени ссылку на видео URL из Яндекс.Диска
            //string videoUrl = "https://disk.yandex.ru/i/mFL6r6rWWABhww";

            //// Создаем новый UriSource на основе ссылки на видео
            //Uri videoUri = new Uri(videoUrl);

            //// Задаем источник видео элементу MediaElement
            //mediaElement.Source = videoUri;

            //// Начинаем воспроизведение видео
            //mediaElement.Play();
           
        }
    }
}
