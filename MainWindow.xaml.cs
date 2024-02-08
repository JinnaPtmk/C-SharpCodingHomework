using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lecture60Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void executeBtn_Click(object sender, RoutedEventArgs e)
        {
            double income = double.Parse(incomeTxtBox.Text);
            double expense = double.Parse(expenseTxtBox.Text);
            double goalCost = double.Parse(goalCostTxtBox.Text);
            double savingDays = goalCost / (income - expense);
            savingDaysTxtBox.Text = savingDays.ToString();
        }

        private void incomeTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}