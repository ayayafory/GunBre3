using System.Windows;
using System.Windows.Controls;

namespace GunBre3
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private void crw_init(string[] abilist)
        {
            CheckCheckBox(crw_abifix00);
            CheckCheckBox(crw_abifix01);
            CheckCheckBox(crw_abifix02);
            CheckCheckBox(crw_abifix03);
            CheckCheckBox(crw_abifix04);
            CheckCheckBox(crw_abifix05);
            CheckCheckBox(crw_abifix06);
            CheckCheckBox(crw_abifix07);
            CheckCheckBox(crw_abifix08);
            CheckCheckBox(crw_abifix09);
            com.SetComboBox(crw_ability0, abilist);
            com.SetComboBox(crw_ability1, abilist);
            com.SetComboBox(crw_ability2, abilist);
            com.SetComboBox(crw_ability3, abilist);
            com.SetComboBox(crw_ability4, abilist);
            com.SetComboBox(crw_ability5, abilist);
            com.SetComboBox(crw_ability6, abilist);
            com.SetComboBox(crw_ability7, abilist);
            com.SetComboBox(crw_ability8, abilist);
            com.SetComboBox(crw_ability9, abilist);
        }


        private void crw_abifix00_Clicked(object sender, RoutedEventArgs e)
        {
            if (crw_abifix00.IsChecked == true)
            {
                com.SetComboBox(crw_ability0, fixabiname);
            }
            else
            {
                com.SetComboBox(crw_ability0, AbiTbl);
            }
        }
        private void crw_abifix01_Clicked(object sender, RoutedEventArgs e)
        {
            if (crw_abifix01.IsChecked == true)
            {
                com.SetComboBox(crw_ability1, fixabiname);
            }
            else
            {
                com.SetComboBox(crw_ability1, AbiTbl);
            }
        }
        private void crw_abifix02_Clicked(object sender, RoutedEventArgs e)
        {
            if (crw_abifix02.IsChecked == true)
            {
                com.SetComboBox(crw_ability2, fixabiname);
            }
            else
            {
                com.SetComboBox(crw_ability2, AbiTbl);
            }
        }
        private void crw_abifix03_Clicked(object sender, RoutedEventArgs e)
        {
            if (crw_abifix03.IsChecked == true)
            {
                com.SetComboBox(crw_ability3, fixabiname);
            }
            else
            {
                com.SetComboBox(crw_ability3, AbiTbl);
            }
        }
        private void crw_abifix04_Clicked(object sender, RoutedEventArgs e)
        {
            if (crw_abifix04.IsChecked == true)
            {
                com.SetComboBox(crw_ability4, fixabiname);
            }
            else
            {
                com.SetComboBox(crw_ability4, AbiTbl);
            }
        }
        private void crw_abifix05_Clicked(object sender, RoutedEventArgs e)
        {
            if (crw_abifix05.IsChecked == true)
            {
                com.SetComboBox(crw_ability5, fixabiname);
            }
            else
            {
                com.SetComboBox(crw_ability5, AbiTbl);
            }
        }
        private void crw_abifix06_Clicked(object sender, RoutedEventArgs e)
        {
            if (crw_abifix06.IsChecked == true)
            {
                com.SetComboBox(crw_ability6, fixabiname);
            }
            else
            {
                com.SetComboBox(crw_ability6, AbiTbl);
            }
        }
        private void crw_abifix07_Clicked(object sender, RoutedEventArgs e)
        {
            if (crw_abifix07.IsChecked == true)
            {
                com.SetComboBox(crw_ability7, fixabiname);
            }
            else
            {
                com.SetComboBox(crw_ability7, AbiTbl);
            }
        }
        private void crw_abifix08_Clicked(object sender, RoutedEventArgs e)
        {
            if (crw_abifix08.IsChecked == true)
            {
                com.SetComboBox(crw_ability8, fixabiname);
            }
            else
            {
                com.SetComboBox(crw_ability8, AbiTbl);
            }
        }
        private void crw_abifix09_Clicked(object sender, RoutedEventArgs e)
        {
            if (crw_abifix09.IsChecked == true)
            {
                com.SetComboBox(crw_ability9, fixabiname);
            }
            else
            {
                com.SetComboBox(crw_ability9, AbiTbl);
            }
        }

        private void crw_rarity00_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(crw_rarity00.SelectedIndex == 0)
            {
                EnableComboBox(crw_ability0);
                EnableComboBox(crw_ability1);
                EnableComboBox(crw_ability2);
                EnableComboBox(crw_ability3);
                EnableComboBox(crw_ability4);
                DisableComboBox(crw_ability5);
                DisableComboBox(crw_ability6);
                DisableComboBox(crw_ability7);
                DisableComboBox(crw_ability8);
                DisableComboBox(crw_ability9);
                EnableCheckBox(crw_abifix00);
                EnableCheckBox(crw_abifix01);
                EnableCheckBox(crw_abifix02);
                EnableCheckBox(crw_abifix03);
                EnableCheckBox(crw_abifix04);
                DisableCheckBox(crw_abifix05);
                DisableCheckBox(crw_abifix06);
                DisableCheckBox(crw_abifix07);
                DisableCheckBox(crw_abifix08);
                DisableCheckBox(crw_abifix09);
            }
            else if (crw_rarity00.SelectedIndex == 1)
            {
                EnableComboBox(crw_ability0);
                EnableComboBox(crw_ability1);
                EnableComboBox(crw_ability2);
                EnableComboBox(crw_ability3);
                EnableComboBox(crw_ability4);
                EnableComboBox(crw_ability5);
                DisableComboBox(crw_ability6);
                DisableComboBox(crw_ability7);
                DisableComboBox(crw_ability8);
                DisableComboBox(crw_ability9);
                EnableCheckBox(crw_abifix00);
                EnableCheckBox(crw_abifix01);
                EnableCheckBox(crw_abifix02);
                EnableCheckBox(crw_abifix03);
                EnableCheckBox(crw_abifix04);
                EnableCheckBox(crw_abifix05);
                DisableCheckBox(crw_abifix06);
                DisableCheckBox(crw_abifix07);
                DisableCheckBox(crw_abifix08);
                DisableCheckBox(crw_abifix09);
            }
            else if (crw_rarity00.SelectedIndex == 2)
            {
                EnableComboBox(crw_ability0);
                EnableComboBox(crw_ability1);
                EnableComboBox(crw_ability2);
                EnableComboBox(crw_ability3);
                EnableComboBox(crw_ability4);
                EnableComboBox(crw_ability5);
                EnableComboBox(crw_ability6);
                EnableComboBox(crw_ability7);
                DisableComboBox(crw_ability8);
                DisableComboBox(crw_ability9);
                EnableCheckBox(crw_abifix00);
                EnableCheckBox(crw_abifix01);
                EnableCheckBox(crw_abifix02);
                EnableCheckBox(crw_abifix03);
                EnableCheckBox(crw_abifix04);
                EnableCheckBox(crw_abifix05);
                EnableCheckBox(crw_abifix06);
                EnableCheckBox(crw_abifix07);
                DisableCheckBox(crw_abifix08);
                DisableCheckBox(crw_abifix09);
            }
            else if (crw_rarity00.SelectedIndex == 3)
            {
                EnableComboBox(crw_ability0);
                EnableComboBox(crw_ability1);
                EnableComboBox(crw_ability2);
                EnableComboBox(crw_ability3);
                EnableComboBox(crw_ability4);
                EnableComboBox(crw_ability5);
                EnableComboBox(crw_ability6);
                EnableComboBox(crw_ability7);
                EnableComboBox(crw_ability8);
                EnableComboBox(crw_ability9);
                EnableCheckBox(crw_abifix00);
                EnableCheckBox(crw_abifix01);
                EnableCheckBox(crw_abifix02);
                EnableCheckBox(crw_abifix03);
                EnableCheckBox(crw_abifix04);
                EnableCheckBox(crw_abifix05);
                EnableCheckBox(crw_abifix06);
                EnableCheckBox(crw_abifix07);
                EnableCheckBox(crw_abifix08);
                EnableCheckBox(crw_abifix09);
            }
            else
            {
                DisableComboBox(crw_ability0);
                DisableComboBox(crw_ability1);
                DisableComboBox(crw_ability2);
                DisableComboBox(crw_ability3);
                DisableComboBox(crw_ability4);
                DisableComboBox(crw_ability5);
                DisableComboBox(crw_ability6);
                DisableComboBox(crw_ability7);
                DisableComboBox(crw_ability8);
                DisableComboBox(crw_ability9);
                DisableCheckBox(crw_abifix00);
                DisableCheckBox(crw_abifix01);
                DisableCheckBox(crw_abifix02);
                DisableCheckBox(crw_abifix03);
                DisableCheckBox(crw_abifix04);
                DisableCheckBox(crw_abifix05);
                DisableCheckBox(crw_abifix06);
                DisableCheckBox(crw_abifix07);
                DisableCheckBox(crw_abifix08);
                DisableCheckBox(crw_abifix09);
            }
        }
    }
}
