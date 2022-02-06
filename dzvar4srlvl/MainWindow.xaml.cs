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

namespace dzvar4srlvl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class GG
        {
            
            public int z;
            public int s;
            public int d;
            public TimeSpan vr;
        }
        GG gg = new GG();
        public MainWindow()
        {
            InitializeComponent();
        }
        

        

        private void Time1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Time1.Text != "")
                
            gg.s = Convert.ToInt32(Time1.Text);//chas
        }

        private void Time_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Time.Text != "")
                
               gg.d = Convert.ToInt32(Time.Text);//min
        }

        private void Time2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Time2.Text != "")
               
                gg.z = Convert.ToInt32(Time2.Text);//sec
        }
        private void vsec_Click(object sender, RoutedEventArgs e)
        {
            int m;
            m = gg.d ;
            m *= 60;
            int y;
            y = gg.s;
            y*= 60 * 60;
            int j = m + y + gg.z;
            Sec.Text = Convert.ToString(j);
           
            
        }
        private void pat_Click(object sender, RoutedEventArgs e)
        {
            gg.vr = new TimeSpan(gg.s, gg.d, gg.z);
            gg.z += 5;
            Pat.Text = gg.vr.ToString("T");
        }
    }
} 
