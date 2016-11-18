using System.Windows;
using System.Windows.Controls;

namespace GunBre3
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private void lrw_init(string[] abilist)
        {
            CheckCheckBox(lrw_abifix00);
            CheckCheckBox(lrw_abifix01);
            CheckCheckBox(lrw_abifix02);
            CheckCheckBox(lrw_abifix03);
            CheckCheckBox(lrw_abifix04);
            CheckCheckBox(lrw_abifix05);
            CheckCheckBox(lrw_abifix06);
            CheckCheckBox(lrw_abifix07);
            CheckCheckBox(lrw_abifix08);
            CheckCheckBox(lrw_abifix09);
            com.SetComboBox(lrw_ability0, abilist);
            com.SetComboBox(lrw_ability1, abilist);
            com.SetComboBox(lrw_ability2, abilist);
            com.SetComboBox(lrw_ability3, abilist);
            com.SetComboBox(lrw_ability4, abilist);
            com.SetComboBox(lrw_ability5, abilist);
            com.SetComboBox(lrw_ability6, abilist);
            com.SetComboBox(lrw_ability7, abilist);
            com.SetComboBox(lrw_ability8, abilist);
            com.SetComboBox(lrw_ability9, abilist);
        }

        private void lrw_abifix00_Clicked(object sender, RoutedEventArgs e)
        {
            if (lrw_abifix00.IsChecked == true)
            {
                com.SetComboBox(lrw_ability0, fixabiname);
            }
            else
            {
                com.SetComboBox(lrw_ability0, AbiTbl);
            }
        }
        private void lrw_abifix01_Clicked(object sender, RoutedEventArgs e)
        {
            if (lrw_abifix01.IsChecked == true)
            {
                com.SetComboBox(lrw_ability1, fixabiname);
            }
            else
            {
                com.SetComboBox(lrw_ability1, AbiTbl);
            }
        }
        private void lrw_abifix02_Clicked(object sender, RoutedEventArgs e)
        {
            if (lrw_abifix02.IsChecked == true)
            {
                com.SetComboBox(lrw_ability2, fixabiname);
            }
            else
            {
                com.SetComboBox(lrw_ability2, AbiTbl);
            }
        }
        private void lrw_abifix03_Clicked(object sender, RoutedEventArgs e)
        {
            if (lrw_abifix03.IsChecked == true)
            {
                com.SetComboBox(lrw_ability3, fixabiname);
            }
            else
            {
                com.SetComboBox(lrw_ability3, AbiTbl);
            }
        }
        private void lrw_abifix04_Clicked(object sender, RoutedEventArgs e)
        {
            if (lrw_abifix04.IsChecked == true)
            {
                com.SetComboBox(lrw_ability4, fixabiname);
            }
            else
            {
                com.SetComboBox(lrw_ability4, AbiTbl);
            }
        }
        private void lrw_abifix05_Clicked(object sender, RoutedEventArgs e)
        {
            if (lrw_abifix05.IsChecked == true)
            {
                com.SetComboBox(lrw_ability5, fixabiname);
            }
            else
            {
                com.SetComboBox(lrw_ability5, AbiTbl);
            }
        }
        private void lrw_abifix06_Clicked(object sender, RoutedEventArgs e)
        {
            if (lrw_abifix06.IsChecked == true)
            {
                com.SetComboBox(lrw_ability6, fixabiname);
            }
            else
            {
                com.SetComboBox(lrw_ability6, AbiTbl);
            }
        }
        private void lrw_abifix07_Clicked(object sender, RoutedEventArgs e)
        {
            if (lrw_abifix07.IsChecked == true)
            {
                com.SetComboBox(lrw_ability7, fixabiname);
            }
            else
            {
                com.SetComboBox(lrw_ability7, AbiTbl);
            }
        }
        private void lrw_abifix08_Clicked(object sender, RoutedEventArgs e)
        {
            if (lrw_abifix08.IsChecked == true)
            {
                com.SetComboBox(lrw_ability8, fixabiname);
            }
            else
            {
                com.SetComboBox(lrw_ability8, AbiTbl);
            }
        }
        private void lrw_abifix09_Clicked(object sender, RoutedEventArgs e)
        {
            if (lrw_abifix09.IsChecked == true)
            {
                com.SetComboBox(lrw_ability9, fixabiname);
            }
            else
            {
                com.SetComboBox(lrw_ability9, AbiTbl);
            }
        }

        private void lrw_rarity00_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lrw_rarity00.SelectedIndex == 0)
            {
                EnableComboBox(lrw_ability0);
                EnableComboBox(lrw_ability1);
                EnableComboBox(lrw_ability2);
                EnableComboBox(lrw_ability3);
                EnableComboBox(lrw_ability4);
                DisableComboBox(lrw_ability5);
                DisableComboBox(lrw_ability6);
                DisableComboBox(lrw_ability7);
                DisableComboBox(lrw_ability8);
                DisableComboBox(lrw_ability9);
                EnableCheckBox(lrw_abifix00);
                EnableCheckBox(lrw_abifix01);
                EnableCheckBox(lrw_abifix02);
                EnableCheckBox(lrw_abifix03);
                EnableCheckBox(lrw_abifix04);
                DisableCheckBox(lrw_abifix05);
                DisableCheckBox(lrw_abifix06);
                DisableCheckBox(lrw_abifix07);
                DisableCheckBox(lrw_abifix08);
                DisableCheckBox(lrw_abifix09);
            }
            else if (lrw_rarity00.SelectedIndex == 1)
            {
                EnableComboBox(lrw_ability0);
                EnableComboBox(lrw_ability1);
                EnableComboBox(lrw_ability2);
                EnableComboBox(lrw_ability3);
                EnableComboBox(lrw_ability4);
                EnableComboBox(lrw_ability5);
                DisableComboBox(lrw_ability6);
                DisableComboBox(lrw_ability7);
                DisableComboBox(lrw_ability8);
                DisableComboBox(lrw_ability9);
                EnableCheckBox(lrw_abifix00);
                EnableCheckBox(lrw_abifix01);
                EnableCheckBox(lrw_abifix02);
                EnableCheckBox(lrw_abifix03);
                EnableCheckBox(lrw_abifix04);
                EnableCheckBox(lrw_abifix05);
                DisableCheckBox(lrw_abifix06);
                DisableCheckBox(lrw_abifix07);
                DisableCheckBox(lrw_abifix08);
                DisableCheckBox(lrw_abifix09);
            }
            else if (lrw_rarity00.SelectedIndex == 2)
            {
                EnableComboBox(lrw_ability0);
                EnableComboBox(lrw_ability1);
                EnableComboBox(lrw_ability2);
                EnableComboBox(lrw_ability3);
                EnableComboBox(lrw_ability4);
                EnableComboBox(lrw_ability5);
                EnableComboBox(lrw_ability6);
                EnableComboBox(lrw_ability7);
                DisableComboBox(lrw_ability8);
                DisableComboBox(lrw_ability9);
                EnableCheckBox(lrw_abifix00);
                EnableCheckBox(lrw_abifix01);
                EnableCheckBox(lrw_abifix02);
                EnableCheckBox(lrw_abifix03);
                EnableCheckBox(lrw_abifix04);
                EnableCheckBox(lrw_abifix05);
                EnableCheckBox(lrw_abifix06);
                EnableCheckBox(lrw_abifix07);
                DisableCheckBox(lrw_abifix08);
                DisableCheckBox(lrw_abifix09);
            }
            else if (lrw_rarity00.SelectedIndex == 3)
            {
                EnableComboBox(lrw_ability0);
                EnableComboBox(lrw_ability1);
                EnableComboBox(lrw_ability2);
                EnableComboBox(lrw_ability3);
                EnableComboBox(lrw_ability4);
                EnableComboBox(lrw_ability5);
                EnableComboBox(lrw_ability6);
                EnableComboBox(lrw_ability7);
                EnableComboBox(lrw_ability8);
                EnableComboBox(lrw_ability9);
                EnableCheckBox(lrw_abifix00);
                EnableCheckBox(lrw_abifix01);
                EnableCheckBox(lrw_abifix02);
                EnableCheckBox(lrw_abifix03);
                EnableCheckBox(lrw_abifix04);
                EnableCheckBox(lrw_abifix05);
                EnableCheckBox(lrw_abifix06);
                EnableCheckBox(lrw_abifix07);
                EnableCheckBox(lrw_abifix08);
                EnableCheckBox(lrw_abifix09);
            }
            else
            {
                DisableComboBox(lrw_ability0);
                DisableComboBox(lrw_ability1);
                DisableComboBox(lrw_ability2);
                DisableComboBox(lrw_ability3);
                DisableComboBox(lrw_ability4);
                DisableComboBox(lrw_ability5);
                DisableComboBox(lrw_ability6);
                DisableComboBox(lrw_ability7);
                DisableComboBox(lrw_ability8);
                DisableComboBox(lrw_ability9);
                DisableCheckBox(lrw_abifix00);
                DisableCheckBox(lrw_abifix01);
                DisableCheckBox(lrw_abifix02);
                DisableCheckBox(lrw_abifix03);
                DisableCheckBox(lrw_abifix04);
                DisableCheckBox(lrw_abifix05);
                DisableCheckBox(lrw_abifix06);
                DisableCheckBox(lrw_abifix07);
                DisableCheckBox(lrw_abifix08);
                DisableCheckBox(lrw_abifix09);
            }
        }
    }
}
