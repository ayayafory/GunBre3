using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace GunBre3
{
    public class ComDef
    {
        public struct FixAbilityTable
        {
            public string name;
            public string type;
            public double val;

            public FixAbilityTable(string p1, string p2, double p3)
            {
                name = p1;
                type = p2;
                val = p3;
            }

        }

        public struct RarityTable
        {
            public string name { get; set; }
            public int val { get; set; }
    }

        public static readonly List<RarityTable> RareTbl = new List<RarityTable>
        {
            new RarityTable() { name = "UNCOMMON", val = 5 },
            new RarityTable() { name = "RARE", val = 6 },
            new RarityTable() { name = "EXCLUSIVE", val = 8 },
            new RarityTable() { name = "LEGENDARY", val = 10 },
        };
        public const string AbilityFile = "abi.csv";
        public const int PartsNum = 8;
        public const int SlotMaxNum = 10;

        public void SetComboBox(ComboBox cb, string[] listname)
        {
            cb.ItemsSource = listname;
            cb.SelectedIndex = 0;
        }

        public void SetComboBox(ComboBox cb, List<RarityTable> listname)
        {
            string[] list = new string[listname.Count()];

            for (int i = 0; i < listname.Count(); i++)
            {
                list[i] = listname[i].name;
            }

            cb.ItemsSource = list;
            cb.SelectedIndex = 0;
        }

        public void SetComboBox(ComboBox cb, List<string> listname)
        {
            cb.ItemsSource = listname;
            cb.SelectedIndex = 0;
        }

        public string[] ReadCsvFile(string filename)
        {
            using (StreamReader sr = new StreamReader(filename, Encoding.GetEncoding("Shift_JIS")))
            {
                string text = sr.ReadToEnd();
                string rep = text.Replace("\r", string.Empty);
                string[] line = rep.Split('\n');
                return line;
            }
        }

        public List<FixAbilityTable> CnvString2List(string[] str)
        {
            List<FixAbilityTable> AbiTbl = new List<FixAbilityTable>();

            for (int i = 0; i < str.Count() - 1; i++)
            {
                string[] split = str[i].Split(',');
                AbiTbl.Add(new FixAbilityTable(split[0], split[1], double.Parse(split[2])));
            }
            return AbiTbl;
        }

        public string[] CnvNameList2String(List<FixAbilityTable> abitbl)
        {
            string[] abilist = new string[abitbl.Count() + 1];

            abilist[0] = string.Empty;
            for (int i = 0; i < abitbl.Count(); i++)
            {
                abilist[i + 1] = abitbl[i].name;
            }
            return abilist;
        }

        public List<string> CnvTypeList2String(List<FixAbilityTable> abitbl)
        {
            List<string> abilist = new List<string>();

            abilist.Add(string.Empty);
            for (int i = 0; i < abitbl.Count(); i++)
            {
                if (abilist[abilist.Count() - 1] != abitbl[i].type)
                {
                    abilist.Add(abitbl[i].type);
                }
            }
            return abilist;
        }

    }
}
