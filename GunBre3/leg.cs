using System.Windows;
using System.Windows.Controls;

namespace GunBre3
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private void leg_init(string[] abilist)
        {
            CheckCheckBox(leg_abifix00);
            CheckCheckBox(leg_abifix01);
            CheckCheckBox(leg_abifix02);
            CheckCheckBox(leg_abifix03);
            CheckCheckBox(leg_abifix04);
            CheckCheckBox(leg_abifix05);
            CheckCheckBox(leg_abifix06);
            CheckCheckBox(leg_abifix07);
            CheckCheckBox(leg_abifix08);
            CheckCheckBox(leg_abifix09);
            com.SetComboBox(leg_ability0, abilist);
            com.SetComboBox(leg_ability1, abilist);
            com.SetComboBox(leg_ability2, abilist);
            com.SetComboBox(leg_ability3, abilist);
            com.SetComboBox(leg_ability4, abilist);
            com.SetComboBox(leg_ability5, abilist);
            com.SetComboBox(leg_ability6, abilist);
            com.SetComboBox(leg_ability7, abilist);
            com.SetComboBox(leg_ability8, abilist);
            com.SetComboBox(leg_ability9, abilist);
        }


        private void leg_abifix00_Clicked(object sender, RoutedEventArgs e)
        {
            if (leg_abifix00.IsChecked == true)
            {
                com.SetComboBox(leg_ability0, fixabiname);
            }
            else
            {
                com.SetComboBox(leg_ability0, AbiTbl);
            }
        }
        private void leg_abifix01_Clicked(object sender, RoutedEventArgs e)
        {
            if (leg_abifix01.IsChecked == true)
            {
                com.SetComboBox(leg_ability1, fixabiname);
            }
            else
            {
                com.SetComboBox(leg_ability1, AbiTbl);
            }
        }
        private void leg_abifix02_Clicked(object sender, RoutedEventArgs e)
        {
            if (leg_abifix02.IsChecked == true)
            {
                com.SetComboBox(leg_ability2, fixabiname);
            }
            else
            {
                com.SetComboBox(leg_ability2, AbiTbl);
            }
        }
        private void leg_abifix03_Clicked(object sender, RoutedEventArgs e)
        {
            if (leg_abifix03.IsChecked == true)
            {
                com.SetComboBox(leg_ability3, fixabiname);
            }
            else
            {
                com.SetComboBox(leg_ability3, AbiTbl);
            }
        }
        private void leg_abifix04_Clicked(object sender, RoutedEventArgs e)
        {
            if (leg_abifix04.IsChecked == true)
            {
                com.SetComboBox(leg_ability4, fixabiname);
            }
            else
            {
                com.SetComboBox(leg_ability4, AbiTbl);
            }
        }
        private void leg_abifix05_Clicked(object sender, RoutedEventArgs e)
        {
            if (leg_abifix05.IsChecked == true)
            {
                com.SetComboBox(leg_ability5, fixabiname);
            }
            else
            {
                com.SetComboBox(leg_ability5, AbiTbl);
            }
        }
        private void leg_abifix06_Clicked(object sender, RoutedEventArgs e)
        {
            if (leg_abifix06.IsChecked == true)
            {
                com.SetComboBox(leg_ability6, fixabiname);
            }
            else
            {
                com.SetComboBox(leg_ability6, AbiTbl);
            }
        }
        private void leg_abifix07_Clicked(object sender, RoutedEventArgs e)
        {
            if (leg_abifix07.IsChecked == true)
            {
                com.SetComboBox(leg_ability7, fixabiname);
            }
            else
            {
                com.SetComboBox(leg_ability7, AbiTbl);
            }
        }
        private void leg_abifix08_Clicked(object sender, RoutedEventArgs e)
        {
            if (leg_abifix08.IsChecked == true)
            {
                com.SetComboBox(leg_ability8, fixabiname);
            }
            else
            {
                com.SetComboBox(leg_ability8, AbiTbl);
            }
        }
        private void leg_abifix09_Clicked(object sender, RoutedEventArgs e)
        {
            if (leg_abifix09.IsChecked == true)
            {
                com.SetComboBox(leg_ability9, fixabiname);
            }
            else
            {
                com.SetComboBox(leg_ability9, AbiTbl);
            }
        }
        private void leg_rarity00_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (leg_rarity00.SelectedIndex == 0)
            {
                EnableComboBox(leg_ability0);
                EnableComboBox(leg_ability1);
                EnableComboBox(leg_ability2);
                EnableComboBox(leg_ability3);
                EnableComboBox(leg_ability4);
                DisableComboBox(leg_ability5);
                DisableComboBox(leg_ability6);
                DisableComboBox(leg_ability7);
                DisableComboBox(leg_ability8);
                DisableComboBox(leg_ability9);
                EnableCheckBox(leg_abifix00);
                EnableCheckBox(leg_abifix01);
                EnableCheckBox(leg_abifix02);
                EnableCheckBox(leg_abifix03);
                EnableCheckBox(leg_abifix04);
                DisableCheckBox(leg_abifix05);
                DisableCheckBox(leg_abifix06);
                DisableCheckBox(leg_abifix07);
                DisableCheckBox(leg_abifix08);
                DisableCheckBox(leg_abifix09);
            }
            else if (leg_rarity00.SelectedIndex == 1)
            {
                EnableComboBox(leg_ability0);
                EnableComboBox(leg_ability1);
                EnableComboBox(leg_ability2);
                EnableComboBox(leg_ability3);
                EnableComboBox(leg_ability4);
                EnableComboBox(leg_ability5);
                DisableComboBox(leg_ability6);
                DisableComboBox(leg_ability7);
                DisableComboBox(leg_ability8);
                DisableComboBox(leg_ability9);
                EnableCheckBox(leg_abifix00);
                EnableCheckBox(leg_abifix01);
                EnableCheckBox(leg_abifix02);
                EnableCheckBox(leg_abifix03);
                EnableCheckBox(leg_abifix04);
                EnableCheckBox(leg_abifix05);
                DisableCheckBox(leg_abifix06);
                DisableCheckBox(leg_abifix07);
                DisableCheckBox(leg_abifix08);
                DisableCheckBox(leg_abifix09);
            }
            else if (leg_rarity00.SelectedIndex == 2)
            {
                EnableComboBox(leg_ability0);
                EnableComboBox(leg_ability1);
                EnableComboBox(leg_ability2);
                EnableComboBox(leg_ability3);
                EnableComboBox(leg_ability4);
                EnableComboBox(leg_ability5);
                EnableComboBox(leg_ability6);
                EnableComboBox(leg_ability7);
                DisableComboBox(leg_ability8);
                DisableComboBox(leg_ability9);
                EnableCheckBox(leg_abifix00);
                EnableCheckBox(leg_abifix01);
                EnableCheckBox(leg_abifix02);
                EnableCheckBox(leg_abifix03);
                EnableCheckBox(leg_abifix04);
                EnableCheckBox(leg_abifix05);
                EnableCheckBox(leg_abifix06);
                EnableCheckBox(leg_abifix07);
                DisableCheckBox(leg_abifix08);
                DisableCheckBox(leg_abifix09);
            }
            else if (leg_rarity00.SelectedIndex == 3)
            {
                EnableComboBox(leg_ability0);
                EnableComboBox(leg_ability1);
                EnableComboBox(leg_ability2);
                EnableComboBox(leg_ability3);
                EnableComboBox(leg_ability4);
                EnableComboBox(leg_ability5);
                EnableComboBox(leg_ability6);
                EnableComboBox(leg_ability7);
                EnableComboBox(leg_ability8);
                EnableComboBox(leg_ability9);
                EnableCheckBox(leg_abifix00);
                EnableCheckBox(leg_abifix01);
                EnableCheckBox(leg_abifix02);
                EnableCheckBox(leg_abifix03);
                EnableCheckBox(leg_abifix04);
                EnableCheckBox(leg_abifix05);
                EnableCheckBox(leg_abifix06);
                EnableCheckBox(leg_abifix07);
                EnableCheckBox(leg_abifix08);
                EnableCheckBox(leg_abifix09);
            }
            else
            {
                DisableComboBox(leg_ability0);
                DisableComboBox(leg_ability1);
                DisableComboBox(leg_ability2);
                DisableComboBox(leg_ability3);
                DisableComboBox(leg_ability4);
                DisableComboBox(leg_ability5);
                DisableComboBox(leg_ability6);
                DisableComboBox(leg_ability7);
                DisableComboBox(leg_ability8);
                DisableComboBox(leg_ability9);
                DisableCheckBox(leg_abifix00);
                DisableCheckBox(leg_abifix01);
                DisableCheckBox(leg_abifix02);
                DisableCheckBox(leg_abifix03);
                DisableCheckBox(leg_abifix04);
                DisableCheckBox(leg_abifix05);
                DisableCheckBox(leg_abifix06);
                DisableCheckBox(leg_abifix07);
                DisableCheckBox(leg_abifix08);
                DisableCheckBox(leg_abifix09);
            }
        }
    }
}
