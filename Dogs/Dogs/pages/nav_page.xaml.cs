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
using WpfAnimatedGif;

namespace Dogs.pages
{
    /// <summary>
    /// Логика взаимодействия для nav_page.xaml
    /// </summary>
    public partial class nav_page : Page
    {
        public nav_page()
        {
            InitializeComponent();
            StartAllAnimations();
            Dog1.Visibility = Visibility.Hidden;
            Dog2.Visibility = Visibility.Hidden;
        }
        public void StartAllAnimations()
        {
            ImageBehavior.SetAnimatedSource(Wall, new BitmapImage(new Uri("/DimaResources/Wall.gif", UriKind.Relative)));
            ImageBehavior.SetAnimatedSource(Logo, new BitmapImage(new Uri("/DimaResources/Dog_Logo.gif", UriKind.Relative)));
        }

        private void Card_MouseEnter(object sender, MouseEventArgs e)
        {
            Rectangle rec = sender as Rectangle;
            if (rec.Name == "Trigger2") Card1.Source = new BitmapImage(new Uri("/DimaResources/Card_2_N.png", UriKind.Relative));
            if (rec.Name == "Trigger1") Card2.Source = new BitmapImage(new Uri("/DimaResources/Card_2_N.png", UriKind.Relative));
            if (rec.Name == "Trigger2") Dog1.Visibility = Visibility.Visible;
            if (rec.Name == "Trigger1") Dog2.Visibility = Visibility.Visible;
        }

        private void Card_MouseLeave(object sender, MouseEventArgs e)
        {
            Rectangle rec = sender as Rectangle;
            if (rec.Name == "Trigger2") Card1.Source = new BitmapImage(new Uri("/DimaResources/Card_1_N.png", UriKind.Relative));
            if (rec.Name == "Trigger1") Card2.Source = new BitmapImage(new Uri("/DimaResources/Card_1_N.png", UriKind.Relative));
            if (rec.Name == "Trigger2") Dog1.Visibility = Visibility.Hidden;
            if (rec.Name == "Trigger1") Dog2.Visibility = Visibility.Hidden;
        }

        private void Logo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            App.mainFrame.Navigate(new AboutUs());
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вошёл =)");
        }

        private void HelpBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Страница заявки");
        }

        private void DogsBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Страница Собак");
        }

        private void DogsBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            Grid grid = button.Content as Grid;
            Image img = grid.Children.OfType<Image>().FirstOrDefault();
            ImageBehavior.SetAnimatedSource(img, new BitmapImage(new Uri("/DimaResources/Bone.gif", UriKind.Relative)));

            Button btn = sender as Button;
            if (btn.Name == "DogsBtn") Card1.Source = new BitmapImage(new Uri("/DimaResources/Card_2_N.png", UriKind.Relative));
            if (btn.Name == "HelpBtn") Card2.Source = new BitmapImage(new Uri("/DimaResources/Card_2_N.png", UriKind.Relative));
            if (btn.Name == "DogsBtn") Dog1.Visibility = Visibility.Visible;
            if (btn.Name == "HelpBtn") Dog2.Visibility = Visibility.Visible;
        }

        private void DogsBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            Grid grid = button.Content as Grid;
            Image img = grid.Children.OfType<Image>().FirstOrDefault();
            ImageBehavior.SetAnimatedSource(img, new BitmapImage(new Uri("/DimaResources/Button_1.png", UriKind.Relative)));

            Button btn = sender as Button;
            if (btn.Name == "DogsBtn") Card1.Source = new BitmapImage(new Uri("/DimaResources/Card_1_N.png", UriKind.Relative));
            if (btn.Name == "HelpBtn") Card2.Source = new BitmapImage(new Uri("/DimaResources/Card_1_N.png", UriKind.Relative));
            if (btn.Name == "DogsBtn") Dog1.Visibility = Visibility.Hidden;
            if (btn.Name == "HelpBtn") Dog2.Visibility = Visibility.Hidden;
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            Grid grid = button.Content as Grid;
            Image img = grid.Children.OfType<Image>().FirstOrDefault();
            ImageBehavior.SetAnimatedSource(img, new BitmapImage(new Uri("/DimaResources/Bone.gif", UriKind.Relative)));
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            Grid grid = button.Content as Grid;
            Image img = grid.Children.OfType<Image>().FirstOrDefault();
            ImageBehavior.SetAnimatedSource(img, new BitmapImage(new Uri("/DimaResources/Button_1.png", UriKind.Relative)));
            //img.Source = new BitmapImage(new Uri("/DimaResources/Button_1.png", UriKind.Relative));
        }
    }
}
