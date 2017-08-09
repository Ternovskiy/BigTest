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

namespace XAML
{
    /// <summary>
    /// Логика взаимодействия для Table.xaml
    /// </summary>
    public partial class Table : Window
    {
        public Table()
        {
            InitializeComponent();

            Loaded += Table_Loaded;
        }


        public class Person
        {
            public string LastName { get; set; }
            public string FirstName { get; set; }

            public Person[] Employee { get; set; }
        }



        private void Table_Loaded(object sender, RoutedEventArgs e)
        {



            lbMain.ItemsSource = new[]
            {
                new Person{LastName="Иванов",FirstName="Иван",
                    Employee =new []{new Person{LastName="Сидоров",FirstName="Алексей"},new Person{LastName="Петров",FirstName="Николай"}} },


                new Person{LastName="Сидоров",FirstName="Алексей"},
                new Person{LastName="Петров",FirstName="Николай", Employee =new []{new Person{LastName="Сидоров",FirstName="Алексей"}}}
            };
        }
    }
}
