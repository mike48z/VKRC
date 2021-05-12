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
using DiplomMisha.Model;
using DiplomMisha.View;

namespace DiplomMisha
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public enum Forms { ClassRooms, GroupOfStudents, Student, Teacher, Discipline }
        public Forms activForm = Forms.ClassRooms;

        public MainWindow()
        {
            InitializeComponent();
            ApplicationContext db = ApplicationContext.GetDbConnectionHandler();
                        
            gridRooms.ItemsSource = db.ClassRooms.ToList();
            List<GroupOfStudent> groupOfStudents = db.GroupOfStudents.ToList();

        }

        private void addNew_Click(object sender, RoutedEventArgs e)
        {
            switch (activForm)
            {
                case Forms.ClassRooms:
                    AddingClassRoomWindow addingClassRoom = new AddingClassRoomWindow();
                    addingClassRoom.Show();
                    break;
                case Forms.Teacher:
                    AddTeacherWindow addingTeacher = new AddTeacherWindow();
                    addingTeacher.Show();
                    break;
                case Forms.Student:

                    AddigStudentView addingStudent = new AddigStudentView();
                    addingStudent.Show();

                    break;
                case Forms.GroupOfStudents:
                    AddingGroupWindow addingGroup = new AddingGroupWindow();
                    addingGroup.Show();
                    break;
                case Forms.Discipline:
                    AddingDisciplineWindow addingDiscipline = new AddingDisciplineWindow();
                    addingDiscipline.Show();
                    break;
                default:
                    MessageBox.Show("TBD");
                    break;
            }
        }

        private void deleteSeleted_Click(object sender, RoutedEventArgs e)
        {
            if (gridRooms.SelectedItem == null)
            {
                MessageBox.Show("Ничего не выбрано");
            }
            else
            {
                MessageBox.Show("TBD");
            }
        }

        private void TimetableOfClassesView_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TBD");
        }

        private void TeachersView_Click(object sender, RoutedEventArgs e)
        {
            ApplicationContext db = ApplicationContext.GetDbConnectionHandler();
            gridRooms.ItemsSource = db.Teachers.ToList();
            activForm = Forms.Teacher;
        }

        private void GroupsView_Click(object sender, RoutedEventArgs e)
        {
            ApplicationContext db = ApplicationContext.GetDbConnectionHandler();
            gridRooms.ItemsSource = db.GroupOfStudents.ToList();
            activForm = Forms.GroupOfStudents;
        }

        private void StudentsView_Click(object sender, RoutedEventArgs e)
        {
            ApplicationContext db = ApplicationContext.GetDbConnectionHandler();
            gridRooms.ItemsSource = db.Students.ToList();
            activForm = Forms.Student;
        }

        private void ClassRoomsView_Click(object sender, RoutedEventArgs e)
        {
            ApplicationContext db = ApplicationContext.GetDbConnectionHandler();
            gridRooms.ItemsSource = db.ClassRooms.ToList();
            activForm = Forms.ClassRooms;
        }

        private void DisciplineView_Click(object sender, RoutedEventArgs e)
        {
            ApplicationContext db = ApplicationContext.GetDbConnectionHandler();
            gridRooms.ItemsSource = db.Disciplines.ToList();
            activForm = Forms.Discipline;
        }
    }
}
