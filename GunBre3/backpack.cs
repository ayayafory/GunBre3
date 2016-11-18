using System.Windows;
using System.Windows.Controls;

namespace GunBre3
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private void bp_init(string[] abilist)
        {
            CheckCheckBox(bp_abifix00);
            CheckCheckBox(bp_abifix01);
            CheckCheckBox(bp_abifix02);
            CheckCheckBox(bp_abifix03);
            CheckCheckBox(bp_abifix04);
            CheckCheckBox(bp_abifix05);
            CheckCheckBox(bp_abifix06);
            CheckCheckBox(bp_abifix07);
            CheckCheckBox(bp_abifix08);
            CheckCheckBox(bp_abifix09);
            com.SetComboBox(bp_ability0, abilist);
            com.SetComboBox(bp_ability1, abilist);
            com.SetComboBox(bp_ability2, abilist);
            com.SetComboBox(bp_ability3, abilist);
            com.SetComboBox(bp_ability4, abilist);
            com.SetComboBox(bp_ability5, abilist);
            com.SetComboBox(bp_ability6, abilist);
            com.SetComboBox(bp_ability7, abilist);
            com.SetComboBox(bp_ability8, abilist);
            com.SetComboBox(bp_ability9, abilist);
        }


        private void bp_abifix00_Clicked(object sender, RoutedEventArgs e)
        {
            if (bp_abifix00.IsChecked == true)
            {
                com.SetComboBox(bp_ability0, fixabiname);
            }
            else
            {
                com.SetComboBox(bp_ability0, AbiTbl);
            }
        }
        private void bp_abifix01_Clicked(object sender, RoutedEventArgs e)
        {
            if (bp_abifix01.IsChecked == true)
            {
                com.SetComboBox(bp_ability1, fixabiname);
            }
            else
            {
                com.SetComboBox(bp_ability1, AbiTbl);
            }
        }
        private void bp_abifix02_Clicked(object sender, RoutedEventArgs e)
        {
            if (bp_abifix02.IsChecked == true)
            {
                com.SetComboBox(bp_ability2, fixabiname);
            }
            else
            {
                com.SetComboBox(bp_ability2, AbiTbl);
            }
        }
        private void bp_abifix03_Clicked(object sender, RoutedEventArgs e)
        {
            if (bp_abifix03.IsChecked == true)
            {
                com.SetComboBox(bp_ability3, fixabiname);
            }
            else
            {
                com.SetComboBox(bp_ability3, AbiTbl);
            }
        }
        private void bp_abifix04_Clicked(object sender, RoutedEventArgs e)
        {
            if (bp_abifix04.IsChecked == true)
            {
                com.SetComboBox(bp_ability4, fixabiname);
            }
            else
            {
                com.SetComboBox(bp_ability4, AbiTbl);
            }
        }
        private void bp_abifix05_Clicked(object sender, RoutedEventArgs e)
        {
            if (bp_abifix05.IsChecked == true)
            {
                com.SetComboBox(bp_ability5, fixabiname);
            }
            else
            {
                com.SetComboBox(bp_ability5, AbiTbl);
            }
        }
        private void bp_abifix06_Clicked(object sender, RoutedEventArgs e)
        {
            if (bp_abifix06.IsChecked == true)
            {
                com.SetComboBox(bp_ability6, fixabiname);
            }
            else
            {
                com.SetComboBox(bp_ability6, AbiTbl);
            }
        }
        private void bp_abifix07_Clicked(object sender, RoutedEventArgs e)
        {
            if (bp_abifix07.IsChecked == true)
            {
                com.SetComboBox(bp_ability7, fixabiname);
            }
            else
            {
                com.SetComboBox(bp_ability7, AbiTbl);
            }
        }
        private void bp_abifix08_Clicked(object sender, RoutedEventArgs e)
        {
            if (bp_abifix08.IsChecked == true)
            {
                com.SetComboBox(bp_ability8, fixabiname);
            }
            else
            {
                com.SetComboBox(bp_ability8, AbiTbl);
            }
        }
        private void bp_abifix09_Clicked(object sender, RoutedEventArgs e)
        {
            if (bp_abifix09.IsChecked == true)
            {
                com.SetComboBox(bp_ability9, fixabiname);
            }
            else
            {
                com.SetComboBox(bp_ability9, AbiTbl);
            }
        }
        private void bp_rarity00_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (bp_rarity00.SelectedIndex == 0)
            {
                EnableComboBox(bp_ability0);
                EnableComboBox(bp_ability1);
                EnableComboBox(bp_ability2);
                EnableComboBox(bp_ability3);
                EnableComboBox(bp_ability4);
                DisableComboBox(bp_ability5);
                DisableComboBox(bp_ability6);
                DisableComboBox(bp_ability7);
                DisableComboBox(bp_ability8);
                DisableComboBox(bp_ability9);
                EnableCheckBox(bp_abifix00);
                EnableCheckBox(bp_abifix01);
                EnableCheckBox(bp_abifix02);
                EnableCheckBox(bp_abifix03);
                EnableCheckBox(bp_abifix04);
                DisableCheckBox(bp_abifix05);
                DisableCheckBox(bp_abifix06);
                DisableCheckBox(bp_abifix07);
                DisableCheckBox(bp_abifix08);
                DisableCheckBox(bp_abifix09);
            }
            else if (bp_rarity00.SelectedIndex == 1)
            {
                EnableComboBox(bp_ability0);
                EnableComboBox(bp_ability1);
                EnableComboBox(bp_ability2);
                EnableComboBox(bp_ability3);
                EnableComboBox(bp_ability4);
                EnableComboBox(bp_ability5);
                DisableComboBox(bp_ability6);
                DisableComboBox(bp_ability7);
                DisableComboBox(bp_ability8);
                DisableComboBox(bp_ability9);
                EnableCheckBox(bp_abifix00);
                EnableCheckBox(bp_abifix01);
                EnableCheckBox(bp_abifix02);
                EnableCheckBox(bp_abifix03);
                EnableCheckBox(bp_abifix04);
                EnableCheckBox(bp_abifix05);
                DisableCheckBox(bp_abifix06);
                DisableCheckBox(bp_abifix07);
                DisableCheckBox(bp_abifix08);
                DisableCheckBox(bp_abifix09);
            }
            else if (bp_rarity00.SelectedIndex == 2)
            {
                EnableComboBox(bp_ability0);
                EnableComboBox(bp_ability1);
                EnableComboBox(bp_ability2);
                EnableComboBox(bp_ability3);
                EnableComboBox(bp_ability4);
                EnableComboBox(bp_ability5);
                EnableComboBox(bp_ability6);
                EnableComboBox(bp_ability7);
                DisableComboBox(bp_ability8);
                DisableComboBox(bp_ability9);
                EnableCheckBox(bp_abifix00);
                EnableCheckBox(bp_abifix01);
                EnableCheckBox(bp_abifix02);
                EnableCheckBox(bp_abifix03);
                EnableCheckBox(bp_abifix04);
                EnableCheckBox(bp_abifix05);
                EnableCheckBox(bp_abifix06);
                EnableCheckBox(bp_abifix07);
                DisableCheckBox(bp_abifix08);
                DisableCheckBox(bp_abifix09);
            }
            else if (bp_rarity00.SelectedIndex == 3)
            {
                EnableComboBox(bp_ability0);
                EnableComboBox(bp_ability1);
                EnableComboBox(bp_ability2);
                EnableComboBox(bp_ability3);
                EnableComboBox(bp_ability4);
                EnableComboBox(bp_ability5);
                EnableComboBox(bp_ability6);
                EnableComboBox(bp_ability7);
                EnableComboBox(bp_ability8);
                EnableComboBox(bp_ability9);
                EnableCheckBox(bp_abifix00);
                EnableCheckBox(bp_abifix01);
                EnableCheckBox(bp_abifix02);
                EnableCheckBox(bp_abifix03);
                EnableCheckBox(bp_abifix04);
                EnableCheckBox(bp_abifix05);
                EnableCheckBox(bp_abifix06);
                EnableCheckBox(bp_abifix07);
                EnableCheckBox(bp_abifix08);
                EnableCheckBox(bp_abifix09);
            }
            else
            {
                DisableComboBox(bp_ability0);
                DisableComboBox(bp_ability1);
                DisableComboBox(bp_ability2);
                DisableComboBox(bp_ability3);
                DisableComboBox(bp_ability4);
                DisableComboBox(bp_ability5);
                DisableComboBox(bp_ability6);
                DisableComboBox(bp_ability7);
                DisableComboBox(bp_ability8);
                DisableComboBox(bp_ability9);
                DisableCheckBox(bp_abifix00);
                DisableCheckBox(bp_abifix01);
                DisableCheckBox(bp_abifix02);
                DisableCheckBox(bp_abifix03);
                DisableCheckBox(bp_abifix04);
                DisableCheckBox(bp_abifix05);
                DisableCheckBox(bp_abifix06);
                DisableCheckBox(bp_abifix07);
                DisableCheckBox(bp_abifix08);
                DisableCheckBox(bp_abifix09);
            }
        }
    }
}
