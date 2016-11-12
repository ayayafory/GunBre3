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
        GBRetVal SetRarelityComboBox(ComboBox cb)
        {
            GBRetVal gbRet = GBRetVal.GB_SUCCESS;
            cb.ItemsSource = new string[] { "uncommon", "rare", "exclusive", "legendary" };
            cb.SelectedIndex = 0;
            return gbRet;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
