using System.Windows;
using System.Windows.Controls;

namespace GunBre3
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private void sd_init(string[] abilist)
        {
            CheckCheckBox(sd_abifix00);
            CheckCheckBox(sd_abifix01);
            CheckCheckBox(sd_abifix02);
            CheckCheckBox(sd_abifix03);
            CheckCheckBox(sd_abifix04);
            CheckCheckBox(sd_abifix05);
            CheckCheckBox(sd_abifix06);
            CheckCheckBox(sd_abifix07);
            CheckCheckBox(sd_abifix08);
            CheckCheckBox(sd_abifix09);
            com.SetComboBox(sd_ability0, abilist);
            com.SetComboBox(sd_ability1, abilist);
            com.SetComboBox(sd_ability2, abilist);
            com.SetComboBox(sd_ability3, abilist);
            com.SetComboBox(sd_ability4, abilist);
            com.SetComboBox(sd_ability5, abilist);
            com.SetComboBox(sd_ability6, abilist);
            com.SetComboBox(sd_ability7, abilist);
            com.SetComboBox(sd_ability8, abilist);
            com.SetComboBox(sd_ability9, abilist);
        }


        private void sd_abifix00_Clicked(object sender, RoutedEventArgs e)
        {
            if (sd_abifix00.IsChecked == true)
            {
                com.SetComboBox(sd_ability0, fixabiname);
            }
            else
            {
                com.SetComboBox(sd_ability0, AbiTbl);
            }
        }
        private void sd_abifix01_Clicked(object sender, RoutedEventArgs e)
        {
            if (sd_abifix01.IsChecked == true)
            {
                com.SetComboBox(sd_ability1, fixabiname);
            }
            else
            {
                com.SetComboBox(sd_ability1, AbiTbl);
            }
        }
        private void sd_abifix02_Clicked(object sender, RoutedEventArgs e)
        {
            if (sd_abifix02.IsChecked == true)
            {
                com.SetComboBox(sd_ability2, fixabiname);
            }
            else
            {
                com.SetComboBox(sd_ability2, AbiTbl);
            }
        }
        private void sd_abifix03_Clicked(object sender, RoutedEventArgs e)
        {
            if (sd_abifix03.IsChecked == true)
            {
                com.SetComboBox(sd_ability3, fixabiname);
            }
            else
            {
                com.SetComboBox(sd_ability3, AbiTbl);
            }
        }
        private void sd_abifix04_Clicked(object sender, RoutedEventArgs e)
        {
            if (sd_abifix04.IsChecked == true)
            {
                com.SetComboBox(sd_ability4, fixabiname);
            }
            else
            {
                com.SetComboBox(sd_ability4, AbiTbl);
            }
        }
        private void sd_abifix05_Clicked(object sender, RoutedEventArgs e)
        {
            if (sd_abifix05.IsChecked == true)
            {
                com.SetComboBox(sd_ability5, fixabiname);
            }
            else
            {
                com.SetComboBox(sd_ability5, AbiTbl);
            }
        }
        private void sd_abifix06_Clicked(object sender, RoutedEventArgs e)
        {
            if (sd_abifix06.IsChecked == true)
            {
                com.SetComboBox(sd_ability6, fixabiname);
            }
            else
            {
                com.SetComboBox(sd_ability6, AbiTbl);
            }
        }
        private void sd_abifix07_Clicked(object sender, RoutedEventArgs e)
        {
            if (sd_abifix07.IsChecked == true)
            {
                com.SetComboBox(sd_ability7, fixabiname);
            }
            else
            {
                com.SetComboBox(sd_ability7, AbiTbl);
            }
        }
        private void sd_abifix08_Clicked(object sender, RoutedEventArgs e)
        {
            if (sd_abifix08.IsChecked == true)
            {
                com.SetComboBox(sd_ability8, fixabiname);
            }
            else
            {
                com.SetComboBox(sd_ability8, AbiTbl);
            }
        }
        private void sd_abifix09_Clicked(object sender, RoutedEventArgs e)
        {
            if (sd_abifix09.IsChecked == true)
            {
                com.SetComboBox(sd_ability9, fixabiname);
            }
            else
            {
                com.SetComboBox(sd_ability9, AbiTbl);
            }
        }
        private void sd_rarity00_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sd_rarity00.SelectedIndex == 0)
            {
                EnableComboBox(sd_ability0);
                EnableComboBox(sd_ability1);
                EnableComboBox(sd_ability2);
                EnableComboBox(sd_ability3);
                EnableComboBox(sd_ability4);
                DisableComboBox(sd_ability5);
                DisableComboBox(sd_ability6);
                DisableComboBox(sd_ability7);
                DisableComboBox(sd_ability8);
                DisableComboBox(sd_ability9);
                EnableCheckBox(sd_abifix00);
                EnableCheckBox(sd_abifix01);
                EnableCheckBox(sd_abifix02);
                EnableCheckBox(sd_abifix03);
                EnableCheckBox(sd_abifix04);
                DisableCheckBox(sd_abifix05);
                DisableCheckBox(sd_abifix06);
                DisableCheckBox(sd_abifix07);
                DisableCheckBox(sd_abifix08);
                DisableCheckBox(sd_abifix09);
            }
            else if (sd_rarity00.SelectedIndex == 1)
            {
                EnableComboBox(sd_ability0);
                EnableComboBox(sd_ability1);
                EnableComboBox(sd_ability2);
                EnableComboBox(sd_ability3);
                EnableComboBox(sd_ability4);
                EnableComboBox(sd_ability5);
                DisableComboBox(sd_ability6);
                DisableComboBox(sd_ability7);
                DisableComboBox(sd_ability8);
                DisableComboBox(sd_ability9);
                EnableCheckBox(sd_abifix00);
                EnableCheckBox(sd_abifix01);
                EnableCheckBox(sd_abifix02);
                EnableCheckBox(sd_abifix03);
                EnableCheckBox(sd_abifix04);
                EnableCheckBox(sd_abifix05);
                DisableCheckBox(sd_abifix06);
                DisableCheckBox(sd_abifix07);
                DisableCheckBox(sd_abifix08);
                DisableCheckBox(sd_abifix09);
            }
            else if (sd_rarity00.SelectedIndex == 2)
            {
                EnableComboBox(sd_ability0);
                EnableComboBox(sd_ability1);
                EnableComboBox(sd_ability2);
                EnableComboBox(sd_ability3);
                EnableComboBox(sd_ability4);
                EnableComboBox(sd_ability5);
                EnableComboBox(sd_ability6);
                EnableComboBox(sd_ability7);
                DisableComboBox(sd_ability8);
                DisableComboBox(sd_ability9);
                EnableCheckBox(sd_abifix00);
                EnableCheckBox(sd_abifix01);
                EnableCheckBox(sd_abifix02);
                EnableCheckBox(sd_abifix03);
                EnableCheckBox(sd_abifix04);
                EnableCheckBox(sd_abifix05);
                EnableCheckBox(sd_abifix06);
                EnableCheckBox(sd_abifix07);
                DisableCheckBox(sd_abifix08);
                DisableCheckBox(sd_abifix09);
            }
            else if (sd_rarity00.SelectedIndex == 3)
            {
                EnableComboBox(sd_ability0);
                EnableComboBox(sd_ability1);
                EnableComboBox(sd_ability2);
                EnableComboBox(sd_ability3);
                EnableComboBox(sd_ability4);
                EnableComboBox(sd_ability5);
                EnableComboBox(sd_ability6);
                EnableComboBox(sd_ability7);
                EnableComboBox(sd_ability8);
                EnableComboBox(sd_ability9);
                EnableCheckBox(sd_abifix00);
                EnableCheckBox(sd_abifix01);
                EnableCheckBox(sd_abifix02);
                EnableCheckBox(sd_abifix03);
                EnableCheckBox(sd_abifix04);
                EnableCheckBox(sd_abifix05);
                EnableCheckBox(sd_abifix06);
                EnableCheckBox(sd_abifix07);
                EnableCheckBox(sd_abifix08);
                EnableCheckBox(sd_abifix09);
            }
            else
            {
                DisableComboBox(sd_ability0);
                DisableComboBox(sd_ability1);
                DisableComboBox(sd_ability2);
                DisableComboBox(sd_ability3);
                DisableComboBox(sd_ability4);
                DisableComboBox(sd_ability5);
                DisableComboBox(sd_ability6);
                DisableComboBox(sd_ability7);
                DisableComboBox(sd_ability8);
                DisableComboBox(sd_ability9);
                DisableCheckBox(sd_abifix00);
                DisableCheckBox(sd_abifix01);
                DisableCheckBox(sd_abifix02);
                DisableCheckBox(sd_abifix03);
                DisableCheckBox(sd_abifix04);
                DisableCheckBox(sd_abifix05);
                DisableCheckBox(sd_abifix06);
                DisableCheckBox(sd_abifix07);
                DisableCheckBox(sd_abifix08);
                DisableCheckBox(sd_abifix09);
            }
        }
    }
}
