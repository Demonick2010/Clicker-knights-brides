using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using System.Windows.Forms;

namespace Clicker_Vernost
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public System.Windows.Point GetMousePosition()
        {
            System.Drawing.Point point = System.Windows.Forms.Control.MousePosition;
            return new System.Windows.Point(point.X, point.Y);
        }

        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Left_Mouse_Down(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Btn_About_Click(object sender, RoutedEventArgs e)
        {
            WindowAbout wa = new WindowAbout();
            wa.Show();
        }

        private void Button_Write(object sender, RoutedEventArgs e)
        {
            var transform = PresentationSource.FromVisual(this).CompositionTarget.TransformFromDevice;
            var mouse = transform.Transform(GetMousePosition());

            int x, y;

            x = (int)mouse.X;
            y = (int)mouse.Y;

            tb_click_x.Text = x.ToString();
            tb_click_y.Text = y.ToString();
        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            tb_click_x.Text = "X";
            tb_click_y.Text = "Y";
        }

        private void Button_Start(object sender, RoutedEventArgs e)
        {
            int x, y;
            int count;

            try
            {
                x = Convert.ToInt32(tb_click_x.Text);
                y = Convert.ToInt32(tb_click_y.Text);
                count = Convert.ToInt32(TextBox_Repet.Text);

                for (int i = 0; i < count; i++)
                {
                    DoMouseClick(x, y);
                }
            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show("Please, set coordinates or/and Number of repetitions\n !ONLY DIGITS ALLOWED!", "Error");
            }
        }

        public void DoMouseClick(int x, int y)
        {
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, 0);
        }

        private void OnKeyDownHandler(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (!(((int)e.Key >= 34) && ((int)e.Key <= 43)) && !(((int)e.Key >= 74) && ((int)e.Key <= 83)))
            {
                e.Handled = true;
            }
        }

        private void OnGotFocusHandler(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button tb = e.Source as System.Windows.Controls.Button;
            tb.Foreground = Brushes.Red;
        }

        private void OnLostFocusHandler(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button tb = e.Source as System.Windows.Controls.Button;
            tb.Foreground = Brushes.Black;
        }
    }
}
