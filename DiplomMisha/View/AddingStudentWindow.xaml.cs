using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для AddigStudentView.xaml
    /// </summary>
    public partial class AddigStudentView : Window
    {

        public ObservableCollection<string> ListOfGroup { get; } = new ObservableCollection<string>();
        ApplicationContext db = ApplicationContext.GetDbConnectionHandler();

        public AddigStudentView()
        {
            InitializeComponent();
            DataContext = this;

            foreach (GroupOfStudent group in db.GroupOfStudents.ToList())
            {
                ListOfGroup.Add(group.Name);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Student newStudent = new Student(this.StudentName.Text.ToString(), this.Email.Text.ToString(), this.Group.SelectedItem.ToString());
            ApplicationContext db = ApplicationContext.GetDbConnectionHandler();
            db.Add(newStudent);
            db.SaveChanges();
            this.Close();


            //MessageBox.Show("TBD");
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
