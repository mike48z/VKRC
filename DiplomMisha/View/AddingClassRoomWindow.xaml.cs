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
using DiplomMisha;

namespace DiplomMisha.View
{
    /// <summary>
    /// Логика взаимодействия для AddingClassRoomWindow.xaml
    /// </summary>
    public partial class AddingClassRoomWindow : Window
    {
        public AddingClassRoomWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ClassRoom NewClassRoom = new ClassRoom(this.ClassRoomName.Text.ToString(), this.ClassRoomDescription.Text.ToString());
            ApplicationContext db = ApplicationContext.GetDbConnectionHandler();
            db.Add(NewClassRoom);
            db.SaveChanges();
            this.Close();            
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
