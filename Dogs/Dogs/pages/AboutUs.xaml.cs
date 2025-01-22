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
    /// Логика взаимодействия для AboutUs.xaml
    /// </summary>
    public partial class AboutUs : Page
    {
        public AboutUs()
        {
            InitializeComponent();
            StartAllAnimations();
        }
        private async void StartAllAnimations()
        {
            ImageBehavior.SetAnimatedSource(Wall, new BitmapImage(new Uri("/DimaResources/Wall.gif", UriKind.Relative)));
            await Task.Delay(50).ConfigureAwait(true);
            ImageBehavior.SetAnimatedSource(Head1, new BitmapImage(new Uri("/DimaResources/Head_1_A.gif", UriKind.Relative)));
            await Task.Delay(50).ConfigureAwait(true);
            ImageBehavior.SetAnimatedSource(Head2, new BitmapImage(new Uri("/DimaResources/Head_2_A.gif", UriKind.Relative)));
            await Task.Delay(50).ConfigureAwait(true);
            ImageBehavior.SetAnimatedSource(Head3, new BitmapImage(new Uri("/DimaResources/Head_3_A.gif", UriKind.Relative)));
            await Task.Delay(50).ConfigureAwait(true);
            ImageBehavior.SetAnimatedSource(Head4, new BitmapImage(new Uri("/DimaResources/Head_4_A.gif", UriKind.Relative)));
            await Task.Delay(50).ConfigureAwait(true);
            ImageBehavior.SetAnimatedSource(Head5, new BitmapImage(new Uri("/DimaResources/Head_5_A.gif", UriKind.Relative)));
            await Task.Delay(50).ConfigureAwait(true);
            ImageBehavior.SetAnimatedSource(Head6, new BitmapImage(new Uri("/DimaResources/Head_6_A.gif", UriKind.Relative)));
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
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            App.mainFrame.Navigate(new nav_page());
        }
    }
}
