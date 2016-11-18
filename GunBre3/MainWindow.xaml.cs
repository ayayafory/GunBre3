using System.Collections.Generic;
using System.Windows;
using static GunBre3.ComDef;

namespace GunBre3
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        ComDef com = new ComDef();

        List<FixAbilityTable> fixabitbl;
        string[] fixabiname;

        public MainWindow()
        {
            InitializeComponent();
            com.SetComboBox(crw_rarity00, RareTbl);
            com.SetComboBox(lrw_rarity00, RareTbl);
            com.SetComboBox(head_rarity00, RareTbl);
            com.SetComboBox(body_rarity00, RareTbl);
            com.SetComboBox(arms_rarity00, RareTbl);
            com.SetComboBox(leg_rarity00, RareTbl);
            com.SetComboBox(bp_rarity00, RareTbl);
            com.SetComboBox(sd_rarity00, RareTbl);
            string[] abilist = com.ReadCsvFile(AbilityFile);
            fixabitbl = com.CnvString2List(abilist);
            fixabiname = com.CnvNameList2String(fixabitbl);
            crw_init(fixabiname);
            lrw_init(fixabiname);
            head_init(fixabiname);
            body_init(fixabiname);
            arms_init(fixabiname);
            leg_init(fixabiname);
            bp_init(fixabiname);
            sd_init(fixabiname);
        }

        private void check_Click(object sender, RoutedEventArgs e)
        {
            var win = new ResultWindow(this);
            win.Show();
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            var win = new AbilityShowWindow();
            win.Show();
        }
    }
}
