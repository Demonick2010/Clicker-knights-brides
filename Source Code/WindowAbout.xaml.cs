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

namespace Clicker_Vernost
{
    /// <summary>
    /// Логика взаимодействия для WindowAbout.xaml
    /// </summary>
    public partial class WindowAbout : Window
    {
        public WindowAbout()
        {
            InitializeComponent();
            tb_About.Text = TextAbout;
        }
        private void Button_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Left_Mouse_Down(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        public string TextAbout
        {
            get { return string.Format("Created by Demonick\nFor all questions contact the e-mail: masterprogger87@gmail.com"); }
        }

        
    }
}


