using System.Windows;
using System.Windows.Controls;

namespace GunBre3
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        void CheckCheckBox(CheckBox cb)
        {
            cb.IsChecked = true;
        }

        void EnableCheckBox(CheckBox cb)
        {
            cb.IsEnabled = true;
        }
        void DisableCheckBox(CheckBox cb)
        {
            cb.IsEnabled = false;
        }

        

        void EnableComboBox(ComboBox cb)
        {
            cb.IsEnabled = true;
        }
        void DisableComboBox(ComboBox cb)
        {
            cb.IsEnabled = false;
            cb.SelectedIndex = -1;
        }

        

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
