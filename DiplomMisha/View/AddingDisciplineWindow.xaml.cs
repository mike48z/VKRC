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
    /// Логика взаимодействия для AddingDisciplineWindow.xaml
    /// </summary>
    public partial class AddingDisciplineWindow : Window
    {
        public AddingDisciplineWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Discipline newDiscipline = new Discipline(this.DisciplineName.Text.ToString(), this.DisciplineDescription.Text.ToString());
            ApplicationContext db = ApplicationContext.GetDbConnectionHandler();
            db.Add(newDiscipline);
            db.SaveChanges();
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
