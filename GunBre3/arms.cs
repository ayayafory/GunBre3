using System.Windows;
using System.Windows.Controls;

namespace GunBre3
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private void arms_init(string[] abilist)
        {
            CheckCheckBox(arms_abifix00);
            CheckCheckBox(arms_abifix01);
            CheckCheckBox(arms_abifix02);
            CheckCheckBox(arms_abifix03);
            CheckCheckBox(arms_abifix04);
            CheckCheckBox(arms_abifix05);
            CheckCheckBox(arms_abifix06);
            CheckCheckBox(arms_abifix07);
            CheckCheckBox(arms_abifix08);
            CheckCheckBox(arms_abifix09);
            com.SetComboBox(arms_ability0, abilist);
            com.SetComboBox(arms_ability1, abilist);
            com.SetComboBox(arms_ability2, abilist);
            com.SetComboBox(arms_ability3, abilist);
            com.SetComboBox(arms_ability4, abilist);
            com.SetComboBox(arms_ability5, abilist);
            com.SetComboBox(arms_ability6, abilist);
            com.SetComboBox(arms_ability7, abilist);
            com.SetComboBox(arms_ability8, abilist);
            com.SetComboBox(arms_ability9, abilist);
        }


        private void arms_abifix00_Clicked(object sender, RoutedEventArgs e)
        {
            if (arms_abifix00.IsChecked == true)
            {
                com.SetComboBox(arms_ability0, fixabiname);
            }
            else
            {
                com.SetComboBox(arms_ability0, AbiTbl);
            }
        }
        private void arms_abifix01_Clicked(object sender, RoutedEventArgs e)
        {
            if (arms_abifix01.IsChecked == true)
            {
                com.SetComboBox(arms_ability1, fixabiname);
            }
            else
            {
                com.SetComboBox(arms_ability1, AbiTbl);
            }
        }
        private void arms_abifix02_Clicked(object sender, RoutedEventArgs e)
        {
            if (arms_abifix02.IsChecked == true)
            {
                com.SetComboBox(arms_ability2, fixabiname);
            }
            else
            {
                com.SetComboBox(arms_ability2, AbiTbl);
            }
        }
        private void arms_abifix03_Clicked(object sender, RoutedEventArgs e)
        {
            if (arms_abifix03.IsChecked == true)
            {
                com.SetComboBox(arms_ability3, fixabiname);
            }
            else
            {
                com.SetComboBox(arms_ability3, AbiTbl);
            }
        }
        private void arms_abifix04_Clicked(object sender, RoutedEventArgs e)
        {
            if (arms_abifix04.IsChecked == true)
            {
                com.SetComboBox(arms_ability4, fixabiname);
            }
            else
            {
                com.SetComboBox(arms_ability4, AbiTbl);
            }
        }
        private void arms_abifix05_Clicked(object sender, RoutedEventArgs e)
        {
            if (arms_abifix05.IsChecked == true)
            {
                com.SetComboBox(arms_ability5, fixabiname);
            }
            else
            {
                com.SetComboBox(arms_ability5, AbiTbl);
            }
        }
        private void arms_abifix06_Clicked(object sender, RoutedEventArgs e)
        {
            if (arms_abifix06.IsChecked == true)
            {
                com.SetComboBox(arms_ability6, fixabiname);
            }
            else
            {
                com.SetComboBox(arms_ability6, AbiTbl);
            }
        }
        private void arms_abifix07_Clicked(object sender, RoutedEventArgs e)
        {
            if (arms_abifix07.IsChecked == true)
            {
                com.SetComboBox(arms_ability7, fixabiname);
            }
            else
            {
                com.SetComboBox(arms_ability7, AbiTbl);
            }
        }
        private void arms_abifix08_Clicked(object sender, RoutedEventArgs e)
        {
            if (arms_abifix08.IsChecked == true)
            {
                com.SetComboBox(arms_ability8, fixabiname);
            }
            else
            {
                com.SetComboBox(arms_ability8, AbiTbl);
            }
        }
        private void arms_abifix09_Clicked(object sender, RoutedEventArgs e)
        {
            if (arms_abifix09.IsChecked == true)
            {
                com.SetComboBox(arms_ability9, fixabiname);
            }
            else
            {
                com.SetComboBox(arms_ability9, AbiTbl);
            }
        }
        private void arms_rarity00_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (arms_rarity00.SelectedIndex == 0)
            {
                EnableComboBox(arms_ability0);
                EnableComboBox(arms_ability1);
                EnableComboBox(arms_ability2);
                EnableComboBox(arms_ability3);
                EnableComboBox(arms_ability4);
                DisableComboBox(arms_ability5);
                DisableComboBox(arms_ability6);
                DisableComboBox(arms_ability7);
                DisableComboBox(arms_ability8);
                DisableComboBox(arms_ability9);
                EnableCheckBox(arms_abifix00);
                EnableCheckBox(arms_abifix01);
                EnableCheckBox(arms_abifix02);
                EnableCheckBox(arms_abifix03);
                EnableCheckBox(arms_abifix04);
                DisableCheckBox(arms_abifix05);
                DisableCheckBox(arms_abifix06);
                DisableCheckBox(arms_abifix07);
                DisableCheckBox(arms_abifix08);
                DisableCheckBox(arms_abifix09);
            }
            else if (arms_rarity00.SelectedIndex == 1)
            {
                EnableComboBox(arms_ability0);
                EnableComboBox(arms_ability1);
                EnableComboBox(arms_ability2);
                EnableComboBox(arms_ability3);
                EnableComboBox(arms_ability4);
                EnableComboBox(arms_ability5);
                DisableComboBox(arms_ability6);
                DisableComboBox(arms_ability7);
                DisableComboBox(arms_ability8);
                DisableComboBox(arms_ability9);
                EnableCheckBox(arms_abifix00);
                EnableCheckBox(arms_abifix01);
                EnableCheckBox(arms_abifix02);
                EnableCheckBox(arms_abifix03);
                EnableCheckBox(arms_abifix04);
                EnableCheckBox(arms_abifix05);
                DisableCheckBox(arms_abifix06);
                DisableCheckBox(arms_abifix07);
                DisableCheckBox(arms_abifix08);
                DisableCheckBox(arms_abifix09);
            }
            else if (arms_rarity00.SelectedIndex == 2)
            {
                EnableComboBox(arms_ability0);
                EnableComboBox(arms_ability1);
                EnableComboBox(arms_ability2);
                EnableComboBox(arms_ability3);
                EnableComboBox(arms_ability4);
                EnableComboBox(arms_ability5);
                EnableComboBox(arms_ability6);
                EnableComboBox(arms_ability7);
                DisableComboBox(arms_ability8);
                DisableComboBox(arms_ability9);
                EnableCheckBox(arms_abifix00);
                EnableCheckBox(arms_abifix01);
                EnableCheckBox(arms_abifix02);
                EnableCheckBox(arms_abifix03);
                EnableCheckBox(arms_abifix04);
                EnableCheckBox(arms_abifix05);
                EnableCheckBox(arms_abifix06);
                EnableCheckBox(arms_abifix07);
                DisableCheckBox(arms_abifix08);
                DisableCheckBox(arms_abifix09);
            }
            else if (arms_rarity00.SelectedIndex == 3)
            {
                EnableComboBox(arms_ability0);
                EnableComboBox(arms_ability1);
                EnableComboBox(arms_ability2);
                EnableComboBox(arms_ability3);
                EnableComboBox(arms_ability4);
                EnableComboBox(arms_ability5);
                EnableComboBox(arms_ability6);
                EnableComboBox(arms_ability7);
                EnableComboBox(arms_ability8);
                EnableComboBox(arms_ability9);
                EnableCheckBox(arms_abifix00);
                EnableCheckBox(arms_abifix01);
                EnableCheckBox(arms_abifix02);
                EnableCheckBox(arms_abifix03);
                EnableCheckBox(arms_abifix04);
                EnableCheckBox(arms_abifix05);
                EnableCheckBox(arms_abifix06);
                EnableCheckBox(arms_abifix07);
                EnableCheckBox(arms_abifix08);
                EnableCheckBox(arms_abifix09);
            }
            else
            {
                DisableComboBox(arms_ability0);
                DisableComboBox(arms_ability1);
                DisableComboBox(arms_ability2);
                DisableComboBox(arms_ability3);
                DisableComboBox(arms_ability4);
                DisableComboBox(arms_ability5);
                DisableComboBox(arms_ability6);
                DisableComboBox(arms_ability7);
                DisableComboBox(arms_ability8);
                DisableComboBox(arms_ability9);
                DisableCheckBox(arms_abifix00);
                DisableCheckBox(arms_abifix01);
                DisableCheckBox(arms_abifix02);
                DisableCheckBox(arms_abifix03);
                DisableCheckBox(arms_abifix04);
                DisableCheckBox(arms_abifix05);
                DisableCheckBox(arms_abifix06);
                DisableCheckBox(arms_abifix07);
                DisableCheckBox(arms_abifix08);
                DisableCheckBox(arms_abifix09);
            }
        }
    }
}
