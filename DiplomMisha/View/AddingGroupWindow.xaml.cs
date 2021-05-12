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
using DiplomMisha.Model;

namespace DiplomMisha.View
{
    /// <summary>
    /// Логика взаимодействия для AddingGroupWindow.xaml
    /// </summary>
    public partial class AddingGroupWindow : Window
    {
        public AddingGroupWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            GroupOfStudent groupOfStudent = new GroupOfStudent(this.GroupName.Text.ToString(), this.GroupDescription.Text.ToString());
            ApplicationContext db = ApplicationContext.GetDbConnectionHandler();
            db.Add(groupOfStudent);
            db.SaveChanges();
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
