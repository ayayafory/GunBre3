using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using static GunBre3.ComDef;

namespace GunBre3
{
    /// <summary>
    /// AbilityShowWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class AbilityShowWindow : Window
    {
        ComDef com = new ComDef();

        List<FixAbilityTable> fixabitbl = new List<FixAbilityTable>();
        List<string> fixabitype;

        public AbilityShowWindow()
        {
            InitializeComponent();
            string[] abilist = com.ReadCsvFile(AbilityFile);
            fixabitbl = com.CnvString2List(abilist);
            fixabitype = com.CnvTypeList2String(fixabitbl);
            com.SetComboBox(type, fixabitype);
        }

        private void type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (type.SelectedIndex > 0)
            {
                abiname.Text = string.Empty;
                abival.Text = string.Empty;

                for (int i = 0; i < fixabitbl.Count(); i++)
                {
                    if (fixabitype[type.SelectedIndex] == fixabitbl[i].type)
                    {
                        abiname.Text += fixabitbl[i].name;
                        abival.Text += fixabitbl[i].val.ToString();
                        abiname.Text += Environment.NewLine;
                        abival.Text += Environment.NewLine;
                    }
                }
            }
        }
    }
}
