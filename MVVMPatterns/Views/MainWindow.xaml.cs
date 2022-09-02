using MVVMPatterns.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MVVMPatterns
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // public string Text { get; set; } = "Salam";
        //public MainWindow()
        //{
        //    InitializeComponent();
        //    this.DataContext = this;
        //}

        //    private void Help_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        //    {
        //        if (Text.Length > 10)
        //        {
        //            e.CanExecute = true;
        //        }
        //        else
        //        {
        //            e.CanExecute = false;
        //        }

        //    }

        //    private void Help_Executed(object sender, ExecutedRoutedEventArgs e)
        //    {
        //        Process.Start("msedge.exe");
        //    }



        //public string Text { get; set; } = "Salam";



        public SendCommand SendCommand { get; set; }
        public DisplayCommand DisplayCommand { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            SendCommand = new SendCommand(Send);
            DisplayCommand = new DisplayCommand(Display);

        }

        private void Display()
        {
            MessageBox.Show("Message was sent successfully");
        }

        private void Send()
        {
            MessageBox.Show("Message was sent successfully");
        }
    }
}
