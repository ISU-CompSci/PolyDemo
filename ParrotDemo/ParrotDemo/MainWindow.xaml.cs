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

namespace ParrotDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            SuperHero s = new SuperHero() {
                FirstName = "Max", MiddleName = "A",
                LastName = "Million"
            };

            SuperHero s1 = new SuperHero();
            s1.FirstName = "Max";
            s1.MiddleName = "A";
            s1.LastName = "Million";

             tbOutput.Text = string.Format("{0} {1}\r\n", s.Flies(), s);

            IFlyable flyer = new SuperHero();
            IFlyable nFly = new Jet();

            IFlyable[] flyers = new IFlyable[6];
            flyers[0] = new Jet();
            flyers[1] = new SuperHero();
            flyers[2] = flyer;
            flyers[3] = flyers[2];
            flyers[4] = nFly;
            flyers[5] = s.CloneMe();

            foreach (IFlyable f in flyers) {
                tbOutput.Text += string.Format("{0} {1}\r\n", f.Flies(), f);

            }







        }
    }
}
