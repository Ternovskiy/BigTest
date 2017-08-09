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

namespace XAML.Pages
{
    /// <summary>
    /// Логика взаимодействия для ContenerPage.xaml
    /// </summary>
    public partial class ContenerPage : Window
    {
        public ContenerPage()
        {
            InitializeComponent();
        }

        private bool f = false;

        private void MyBut_Click(object sender, RoutedEventArgs e)
        {
            if (!f)
                MyFrame.Source = new Uri("Page2.xaml", UriKind.Relative);
            else
                //MyFrame.Source = null;
                MyFrame.Source = new Uri("Page3.xaml", UriKind.Relative);
            f = !f;

            //var ur= new Uri("Page2.xaml", UriKind.Relative);

            //if (f)
            //{
            //    MyFrame.Dispatcher.Invoke(delegate
            //        {
            //            MyFrame.Source = ur;
            //        }
            //    );
            //}
            //else
            //{
            //    MyFrame.Dispatcher.Invoke(delegate
            //        {
            //            MyFrame.Source = null;
            //        }
            //    );
            //}
            //f = !f;
        }

        private void MyButClear_Click(object sender, RoutedEventArgs e)
        {
           // MyFrame.Source = null; //на пустую страницу
           
            MyFrame.RemoveBackEntry();
        }
    }
}
