using System;
using System.Windows;
using System.Windows.Controls;

namespace UT2_Ac3_CaracteresLimitados
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void inputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int longitud = inputTextBox.Text.Length;
            if (longitud == 140)
                inputTextBox.IsReadOnly = true;
            caracteresTextBlock.Text = longitud + "/140";
        }
    }
}
