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
using practice_5;

namespace practice_9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Operations op;
        public MainWindow()
        {
            op = new Operations();
            InitializeComponent();
        }

        private void SplitTxt_Click(object sender, RoutedEventArgs e)
        {
            string text = InputTextSplit.Text;
            string[] splitText = op.SplitText(text);

            foreach (var item in splitText)
            {
                SplitMsg.Items.Add(item);
            }
        }

        private void ReverseButton_Click(object sender, RoutedEventArgs e)
        {
            string text = InputTextReverse.Text;

            ReverseMsg.Content = op.Reverse(text);
        }
    }
}
