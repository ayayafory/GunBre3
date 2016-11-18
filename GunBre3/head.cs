using System.Windows;
using System.Windows.Controls;

namespace GunBre3
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private void head_init(string[] abilist)
        {
            CheckCheckBox(head_abifix00);
            CheckCheckBox(head_abifix01);
            CheckCheckBox(head_abifix02);
            CheckCheckBox(head_abifix03);
            CheckCheckBox(head_abifix04);
            CheckCheckBox(head_abifix05);
            CheckCheckBox(head_abifix06);
            CheckCheckBox(head_abifix07);
            CheckCheckBox(head_abifix08);
            CheckCheckBox(head_abifix09);
            com.SetComboBox(head_ability0, abilist);
            com.SetComboBox(head_ability1, abilist);
            com.SetComboBox(head_ability2, abilist);
            com.SetComboBox(head_ability3, abilist);
            com.SetComboBox(head_ability4, abilist);
            com.SetComboBox(head_ability5, abilist);
            com.SetComboBox(head_ability6, abilist);
            com.SetComboBox(head_ability7, abilist);
            com.SetComboBox(head_ability8, abilist);
            com.SetComboBox(head_ability9, abilist);
        }


        private void head_abifix00_Clicked(object sender, RoutedEventArgs e)
        {
            if (head_abifix00.IsChecked == true)
            {
                com.SetComboBox(head_ability0, fixabiname);
            }
            else
            {
                com.SetComboBox(head_ability0, AbiTbl);
            }
        }
        private void head_abifix01_Clicked(object sender, RoutedEventArgs e)
        {
            if (head_abifix01.IsChecked == true)
            {
                com.SetComboBox(head_ability1, fixabiname);
            }
            else
            {
                com.SetComboBox(head_ability1, AbiTbl);
            }
        }
        private void head_abifix02_Clicked(object sender, RoutedEventArgs e)
        {
            if (head_abifix02.IsChecked == true)
            {
                com.SetComboBox(head_ability2, fixabiname);
            }
            else
            {
                com.SetComboBox(head_ability2, AbiTbl);
            }
        }
        private void head_abifix03_Clicked(object sender, RoutedEventArgs e)
        {
            if (head_abifix03.IsChecked == true)
            {
                com.SetComboBox(head_ability3, fixabiname);
            }
            else
            {
                com.SetComboBox(head_ability3, AbiTbl);
            }
        }
        private void head_abifix04_Clicked(object sender, RoutedEventArgs e)
        {
            if (head_abifix04.IsChecked == true)
            {
                com.SetComboBox(head_ability4, fixabiname);
            }
            else
            {
                com.SetComboBox(head_ability4, AbiTbl);
            }
        }
        private void head_abifix05_Clicked(object sender, RoutedEventArgs e)
        {
            if (head_abifix05.IsChecked == true)
            {
                com.SetComboBox(head_ability5, fixabiname);
            }
            else
            {
                com.SetComboBox(head_ability5, AbiTbl);
            }
        }
        private void head_abifix06_Clicked(object sender, RoutedEventArgs e)
        {
            if (head_abifix06.IsChecked == true)
            {
                com.SetComboBox(head_ability6, fixabiname);
            }
            else
            {
                com.SetComboBox(head_ability6, AbiTbl);
            }
        }
        private void head_abifix07_Clicked(object sender, RoutedEventArgs e)
        {
            if (head_abifix07.IsChecked == true)
            {
                com.SetComboBox(head_ability7, fixabiname);
            }
            else
            {
                com.SetComboBox(head_ability7, AbiTbl);
            }
        }
        private void head_abifix08_Clicked(object sender, RoutedEventArgs e)
        {
            if (head_abifix08.IsChecked == true)
            {
                com.SetComboBox(head_ability8, fixabiname);
            }
            else
            {
                com.SetComboBox(head_ability8, AbiTbl);
            }
        }
        private void head_abifix09_Clicked(object sender, RoutedEventArgs e)
        {
            if (head_abifix09.IsChecked == true)
            {
                com.SetComboBox(head_ability9, fixabiname);
            }
            else
            {
                com.SetComboBox(head_ability9, AbiTbl);
            }
        }
        private void head_rarity00_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (head_rarity00.SelectedIndex == 0)
            {
                EnableComboBox(head_ability0);
                EnableComboBox(head_ability1);
                EnableComboBox(head_ability2);
                EnableComboBox(head_ability3);
                EnableComboBox(head_ability4);
                DisableComboBox(head_ability5);
                DisableComboBox(head_ability6);
                DisableComboBox(head_ability7);
                DisableComboBox(head_ability8);
                DisableComboBox(head_ability9);
                EnableCheckBox(head_abifix00);
                EnableCheckBox(head_abifix01);
                EnableCheckBox(head_abifix02);
                EnableCheckBox(head_abifix03);
                EnableCheckBox(head_abifix04);
                DisableCheckBox(head_abifix05);
                DisableCheckBox(head_abifix06);
                DisableCheckBox(head_abifix07);
                DisableCheckBox(head_abifix08);
                DisableCheckBox(head_abifix09);
            }
            else if (head_rarity00.SelectedIndex == 1)
            {
                EnableComboBox(head_ability0);
                EnableComboBox(head_ability1);
                EnableComboBox(head_ability2);
                EnableComboBox(head_ability3);
                EnableComboBox(head_ability4);
                EnableComboBox(head_ability5);
                DisableComboBox(head_ability6);
                DisableComboBox(head_ability7);
                DisableComboBox(head_ability8);
                DisableComboBox(head_ability9);
                EnableCheckBox(head_abifix00);
                EnableCheckBox(head_abifix01);
                EnableCheckBox(head_abifix02);
                EnableCheckBox(head_abifix03);
                EnableCheckBox(head_abifix04);
                EnableCheckBox(head_abifix05);
                DisableCheckBox(head_abifix06);
                DisableCheckBox(head_abifix07);
                DisableCheckBox(head_abifix08);
                DisableCheckBox(head_abifix09);
            }
            else if (head_rarity00.SelectedIndex == 2)
            {
                EnableComboBox(head_ability0);
                EnableComboBox(head_ability1);
                EnableComboBox(head_ability2);
                EnableComboBox(head_ability3);
                EnableComboBox(head_ability4);
                EnableComboBox(head_ability5);
                EnableComboBox(head_ability6);
                EnableComboBox(head_ability7);
                DisableComboBox(head_ability8);
                DisableComboBox(head_ability9);
                EnableCheckBox(head_abifix00);
                EnableCheckBox(head_abifix01);
                EnableCheckBox(head_abifix02);
                EnableCheckBox(head_abifix03);
                EnableCheckBox(head_abifix04);
                EnableCheckBox(head_abifix05);
                EnableCheckBox(head_abifix06);
                EnableCheckBox(head_abifix07);
                DisableCheckBox(head_abifix08);
                DisableCheckBox(head_abifix09);
            }
            else if (head_rarity00.SelectedIndex == 3)
            {
                EnableComboBox(head_ability0);
                EnableComboBox(head_ability1);
                EnableComboBox(head_ability2);
                EnableComboBox(head_ability3);
                EnableComboBox(head_ability4);
                EnableComboBox(head_ability5);
                EnableComboBox(head_ability6);
                EnableComboBox(head_ability7);
                EnableComboBox(head_ability8);
                EnableComboBox(head_ability9);
                EnableCheckBox(head_abifix00);
                EnableCheckBox(head_abifix01);
                EnableCheckBox(head_abifix02);
                EnableCheckBox(head_abifix03);
                EnableCheckBox(head_abifix04);
                EnableCheckBox(head_abifix05);
                EnableCheckBox(head_abifix06);
                EnableCheckBox(head_abifix07);
                EnableCheckBox(head_abifix08);
                EnableCheckBox(head_abifix09);
            }
            else
            {
                DisableComboBox(head_ability0);
                DisableComboBox(head_ability1);
                DisableComboBox(head_ability2);
                DisableComboBox(head_ability3);
                DisableComboBox(head_ability4);
                DisableComboBox(head_ability5);
                DisableComboBox(head_ability6);
                DisableComboBox(head_ability7);
                DisableComboBox(head_ability8);
                DisableComboBox(head_ability9);
                DisableCheckBox(head_abifix00);
                DisableCheckBox(head_abifix01);
                DisableCheckBox(head_abifix02);
                DisableCheckBox(head_abifix03);
                DisableCheckBox(head_abifix04);
                DisableCheckBox(head_abifix05);
                DisableCheckBox(head_abifix06);
                DisableCheckBox(head_abifix07);
                DisableCheckBox(head_abifix08);
                DisableCheckBox(head_abifix09);
            }
        }
    }
}
