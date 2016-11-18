using System.Windows;
using System.Windows.Controls;

namespace GunBre3
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private void body_init(string[] abilist)
        {
            CheckCheckBox(body_abifix00);
            CheckCheckBox(body_abifix01);
            CheckCheckBox(body_abifix02);
            CheckCheckBox(body_abifix03);
            CheckCheckBox(body_abifix04);
            CheckCheckBox(body_abifix05);
            CheckCheckBox(body_abifix06);
            CheckCheckBox(body_abifix07);
            CheckCheckBox(body_abifix08);
            CheckCheckBox(body_abifix09);
            com.SetComboBox(body_ability0, abilist);
            com.SetComboBox(body_ability1, abilist);
            com.SetComboBox(body_ability2, abilist);
            com.SetComboBox(body_ability3, abilist);
            com.SetComboBox(body_ability4, abilist);
            com.SetComboBox(body_ability5, abilist);
            com.SetComboBox(body_ability6, abilist);
            com.SetComboBox(body_ability7, abilist);
            com.SetComboBox(body_ability8, abilist);
            com.SetComboBox(body_ability9, abilist);
        }


        private void body_abifix00_Clicked(object sender, RoutedEventArgs e)
        {
            if (body_abifix00.IsChecked == true)
            {
                com.SetComboBox(body_ability0, fixabiname);
            }
            else
            {
                com.SetComboBox(body_ability0, AbiTbl);
            }
        }
        private void body_abifix01_Clicked(object sender, RoutedEventArgs e)
        {
            if (body_abifix01.IsChecked == true)
            {
                com.SetComboBox(body_ability1, fixabiname);
            }
            else
            {
                com.SetComboBox(body_ability1, AbiTbl);
            }
        }
        private void body_abifix02_Clicked(object sender, RoutedEventArgs e)
        {
            if (body_abifix02.IsChecked == true)
            {
                com.SetComboBox(body_ability2, fixabiname);
            }
            else
            {
                com.SetComboBox(body_ability2, AbiTbl);
            }
        }
        private void body_abifix03_Clicked(object sender, RoutedEventArgs e)
        {
            if (body_abifix03.IsChecked == true)
            {
                com.SetComboBox(body_ability3, fixabiname);
            }
            else
            {
                com.SetComboBox(body_ability3, AbiTbl);
            }
        }
        private void body_abifix04_Clicked(object sender, RoutedEventArgs e)
        {
            if (body_abifix04.IsChecked == true)
            {
                com.SetComboBox(body_ability4, fixabiname);
            }
            else
            {
                com.SetComboBox(body_ability4, AbiTbl);
            }
        }
        private void body_abifix05_Clicked(object sender, RoutedEventArgs e)
        {
            if (body_abifix05.IsChecked == true)
            {
                com.SetComboBox(body_ability5, fixabiname);
            }
            else
            {
                com.SetComboBox(body_ability5, AbiTbl);
            }
        }
        private void body_abifix06_Clicked(object sender, RoutedEventArgs e)
        {
            if (body_abifix06.IsChecked == true)
            {
                com.SetComboBox(body_ability6, fixabiname);
            }
            else
            {
                com.SetComboBox(body_ability6, AbiTbl);
            }
        }
        private void body_abifix07_Clicked(object sender, RoutedEventArgs e)
        {
            if (body_abifix07.IsChecked == true)
            {
                com.SetComboBox(body_ability7, fixabiname);
            }
            else
            {
                com.SetComboBox(body_ability7, AbiTbl);
            }
        }
        private void body_abifix08_Clicked(object sender, RoutedEventArgs e)
        {
            if (body_abifix08.IsChecked == true)
            {
                com.SetComboBox(body_ability8, fixabiname);
            }
            else
            {
                com.SetComboBox(body_ability8, AbiTbl);
            }
        }
        private void body_abifix09_Clicked(object sender, RoutedEventArgs e)
        {
            if (body_abifix09.IsChecked == true)
            {
                com.SetComboBox(body_ability9, fixabiname);
            }
            else
            {
                com.SetComboBox(body_ability9, AbiTbl);
            }
        }
        private void body_rarity00_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (body_rarity00.SelectedIndex == 0)
            {
                EnableComboBox(body_ability0);
                EnableComboBox(body_ability1);
                EnableComboBox(body_ability2);
                EnableComboBox(body_ability3);
                EnableComboBox(body_ability4);
                DisableComboBox(body_ability5);
                DisableComboBox(body_ability6);
                DisableComboBox(body_ability7);
                DisableComboBox(body_ability8);
                DisableComboBox(body_ability9);
                EnableCheckBox(body_abifix00);
                EnableCheckBox(body_abifix01);
                EnableCheckBox(body_abifix02);
                EnableCheckBox(body_abifix03);
                EnableCheckBox(body_abifix04);
                DisableCheckBox(body_abifix05);
                DisableCheckBox(body_abifix06);
                DisableCheckBox(body_abifix07);
                DisableCheckBox(body_abifix08);
                DisableCheckBox(body_abifix09);
            }
            else if (body_rarity00.SelectedIndex == 1)
            {
                EnableComboBox(body_ability0);
                EnableComboBox(body_ability1);
                EnableComboBox(body_ability2);
                EnableComboBox(body_ability3);
                EnableComboBox(body_ability4);
                EnableComboBox(body_ability5);
                DisableComboBox(body_ability6);
                DisableComboBox(body_ability7);
                DisableComboBox(body_ability8);
                DisableComboBox(body_ability9);
                EnableCheckBox(body_abifix00);
                EnableCheckBox(body_abifix01);
                EnableCheckBox(body_abifix02);
                EnableCheckBox(body_abifix03);
                EnableCheckBox(body_abifix04);
                EnableCheckBox(body_abifix05);
                DisableCheckBox(body_abifix06);
                DisableCheckBox(body_abifix07);
                DisableCheckBox(body_abifix08);
                DisableCheckBox(body_abifix09);
            }
            else if (body_rarity00.SelectedIndex == 2)
            {
                EnableComboBox(body_ability0);
                EnableComboBox(body_ability1);
                EnableComboBox(body_ability2);
                EnableComboBox(body_ability3);
                EnableComboBox(body_ability4);
                EnableComboBox(body_ability5);
                EnableComboBox(body_ability6);
                EnableComboBox(body_ability7);
                DisableComboBox(body_ability8);
                DisableComboBox(body_ability9);
                EnableCheckBox(body_abifix00);
                EnableCheckBox(body_abifix01);
                EnableCheckBox(body_abifix02);
                EnableCheckBox(body_abifix03);
                EnableCheckBox(body_abifix04);
                EnableCheckBox(body_abifix05);
                EnableCheckBox(body_abifix06);
                EnableCheckBox(body_abifix07);
                DisableCheckBox(body_abifix08);
                DisableCheckBox(body_abifix09);
            }
            else if (body_rarity00.SelectedIndex == 3)
            {
                EnableComboBox(body_ability0);
                EnableComboBox(body_ability1);
                EnableComboBox(body_ability2);
                EnableComboBox(body_ability3);
                EnableComboBox(body_ability4);
                EnableComboBox(body_ability5);
                EnableComboBox(body_ability6);
                EnableComboBox(body_ability7);
                EnableComboBox(body_ability8);
                EnableComboBox(body_ability9);
                EnableCheckBox(body_abifix00);
                EnableCheckBox(body_abifix01);
                EnableCheckBox(body_abifix02);
                EnableCheckBox(body_abifix03);
                EnableCheckBox(body_abifix04);
                EnableCheckBox(body_abifix05);
                EnableCheckBox(body_abifix06);
                EnableCheckBox(body_abifix07);
                EnableCheckBox(body_abifix08);
                EnableCheckBox(body_abifix09);
            }
            else
            {
                DisableComboBox(body_ability0);
                DisableComboBox(body_ability1);
                DisableComboBox(body_ability2);
                DisableComboBox(body_ability3);
                DisableComboBox(body_ability4);
                DisableComboBox(body_ability5);
                DisableComboBox(body_ability6);
                DisableComboBox(body_ability7);
                DisableComboBox(body_ability8);
                DisableComboBox(body_ability9);
                DisableCheckBox(body_abifix00);
                DisableCheckBox(body_abifix01);
                DisableCheckBox(body_abifix02);
                DisableCheckBox(body_abifix03);
                DisableCheckBox(body_abifix04);
                DisableCheckBox(body_abifix05);
                DisableCheckBox(body_abifix06);
                DisableCheckBox(body_abifix07);
                DisableCheckBox(body_abifix08);
                DisableCheckBox(body_abifix09);
            }
        }
    }
}
