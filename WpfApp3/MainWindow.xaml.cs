using System.Windows;
using WpfApp3;

namespace InheritanceDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateStudentButton_Click(object sender, RoutedEventArgs e)
        {
            Student s = new Student();

            s.Name = NameBox.Text;
            s.Grade = int.Parse(GradeBox.Text);

            ResultTextBlock.Text = s.Name + " - " + s.Grade;
        }
    }
}
