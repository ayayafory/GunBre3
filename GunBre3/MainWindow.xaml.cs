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
        List<FixAbilityTable> fixabitbl;
        public string[] fixabiname;

        public MainWindow()
        {
            InitializeComponent();
            SetComboBox(crw_rarity00, RareTbl);
            SetComboBox(lrw_rarity00, RareTbl);
            SetComboBox(head_rarity00, RareTbl);
            SetComboBox(body_rarity00, RareTbl);
            SetComboBox(arms_rarity00, RareTbl);
            SetComboBox(leg_rarity00, RareTbl);
            SetComboBox(bp_rarity00, RareTbl);
            SetComboBox(sd_rarity00, RareTbl);
            string[] abilist = ReadCsvFile("abi.csv");
            fixabitbl = CnvString2List(abilist);
            fixabiname = CnvList2String(fixabitbl);
            SetComboBox(crw_ability0, fixabiname);
            SetComboBox(crw_ability1, fixabiname);
            SetComboBox(crw_ability2, fixabiname);
            SetComboBox(crw_ability3, fixabiname);
            SetComboBox(crw_ability4, fixabiname);
            SetComboBox(crw_ability5, fixabiname);
            SetComboBox(crw_ability6, fixabiname);
            SetComboBox(crw_ability7, fixabiname);
            SetComboBox(crw_ability8, fixabiname);
            SetComboBox(crw_ability9, fixabiname);
            CheckCheckBox(leg_abifix00);
            SetComboBox(leg_ability0, fixabiname);
        }

        private void check_Click(object sender, RoutedEventArgs e)
        {

        }

        private void leg_abifix00_Clicked(object sender, RoutedEventArgs e)
        {
            if(leg_abifix00.IsChecked == true)
            {
                SetComboBox(leg_ability0, fixabiname);
            }
            else if (leg_abifix00.IsChecked == false)
            {
                SetComboBox(leg_ability0, AbiTbl);
            }
        }
    }
}
