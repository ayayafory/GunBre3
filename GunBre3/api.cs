using System;
using System.IO;
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
        void CheckCheckBox(CheckBox cb)
        {
            cb.IsChecked = true;
        }

        void SetComboBox(ComboBox cb, string[] listname)
        {
            cb.ItemsSource = listname;
            cb.SelectedIndex = 0;
        }

        string[] ReadCsvFile(string filename)
        {
            using (StreamReader sr = new StreamReader(filename, Encoding.GetEncoding("Shift_JIS")))
            {
                string text = sr.ReadToEnd();
                string rep = text.Replace("\r", string.Empty);
                string[] line = rep.Split('\n');
                return line;
            }
        }

        List<FixAbilityTable> CnvString2List(string[] str)
        {
            List<FixAbilityTable> AbiTbl = new List<FixAbilityTable>();

            for (int i = 0; i < str.Count()-1; i++)
            {
                string[] split = str[i].Split(',');
                AbiTbl.Add(new FixAbilityTable(split[0], split[1], double.Parse(split[2])));
            }
            return AbiTbl;
        }

        string[] CnvList2String(List<FixAbilityTable> abitbl)
        {
            string[] abilist = new string[abitbl.Count()+1];

            abilist[0] = string.Empty;
            for (int i = 0; i < abitbl.Count(); i++)
            {
                abilist[i+1] = abitbl[i].name;
            }
            return abilist;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
