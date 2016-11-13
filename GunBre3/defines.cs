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

namespace GunBre3
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public struct FixAbilityTable
        {
            public string name;
            public string type;
            public double val;

            public FixAbilityTable(string p1, string p2, double p3)
            {
                name = p1;
                type = p2;
                val = p3;
            }

        }

        public string[] RareTbl = new string[] { "uncommon", "rare", "exclusive", "legendary" };
        public string[] AbiTbl = new string[] { "準備中" };

    }
}
