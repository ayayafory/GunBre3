using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using static GunBre3.ComDef;

namespace GunBre3
{
    /// <summary>
    /// ResultWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ResultWindow : Window
    {
        MainWindow mw_tmp;
        ComDef com = new ComDef();
        List<FixAbilityTable> fixabi;

        public ResultWindow(MainWindow mw)
        {
            InitializeComponent();
            mw_tmp = mw;
            fixabi = mw_tmp.fixabitbl;
            Check();
        }

        private string[] ReadRarity(int i, ComboBox[] abi)
        {
            string[] list = new string[RareTbl[i].val];
            list[0] = abi[0].Text;
            list[1] = abi[1].Text;
            list[2] = abi[2].Text;
            list[3] = abi[3].Text;
            list[4] = abi[4].Text;
            if (RareTbl[i].val >= 6)
            {
                list[5] = abi[5].Text;
                if (RareTbl[i].val >= 8)
                {
                    list[6] = abi[6].Text;
                    list[7] = abi[7].Text;
                    if (RareTbl[i].val == 10)
                    {
                        list[8] = abi[8].Text;
                        list[9] = abi[9].Text;
                    }
                }
            }
            return list;
        }

        private string ErrMsg1(string parts, int i)
        {
            string str = parts + "の" + i.ToString() + "番目 ";
            return str;
        }

        private string ErrMsg2(int i, int j)
        {
            string str = null;
            if (i == 0)
            {
                str = ErrMsg1("近接武器", j);
            }
            else if (i == 1)
            {
                str = ErrMsg1("遠距離武器", j);
            }
            else if (i == 2)
            {
                str = ErrMsg1("頭パーツ", j);
            }
            else if (i == 3)
            {
                str = ErrMsg1("胴体パーツ", j);
            }
            else if (i == 4)
            {
                str = ErrMsg1("腕パーツ", j);
            }
            else if (i == 5)
            {
                str = ErrMsg1("脚パーツ", j);
            }
            else if (i == 6)
            {
                str = ErrMsg1("バックパック", j);
            }
            else if (i == 7)
            {
                str = ErrMsg1("シールド", j);
            }
            return str + "の効果が重複しています";
        }

        private void PrintError(int i, int j, int x, int y)
        {
            string str = null;
            if (i == 0)
            {
                str = ErrMsg1("近接武器", j) + ErrMsg2(x,y);
            }
            else if (i == 1)
            {
                str = ErrMsg1("遠距離武器", j) + ErrMsg2(x, y);
            }
            else if (i == 2)
            {
                str = ErrMsg1("頭パーツ", j) + ErrMsg2(x, y);
            }
            else if (i == 3)
            {
                str = ErrMsg1("胴体パーツ", j) + ErrMsg2(x, y);
            }
            else if (i == 4)
            {
                str = ErrMsg1("腕パーツ", j) + ErrMsg2(x, y);
            }
            else if (i == 5)
            {
                str = ErrMsg1("脚パーツ", j) + ErrMsg2(x, y);
            }
            else if (i == 6)
            {
                str = ErrMsg1("バックパック", j) + ErrMsg2(x, y);
            }
            else if (i == 7)
            {
                str = ErrMsg1("シールド", j) + ErrMsg2(x, y);
            }

            textBlock.Text += str;
            //textBlock.Text += Environment.NewLine;
        }

        private void CmpVal(int p1, int p2)
        {
            string str = "\t" + fixabi[p1].type + ":\t" + fixabi[p1].val + "\t" + fixabi[p2].val;
            textBlock.Text += str;
            textBlock.Text += Environment.NewLine;
        }

        private void Check()
        {
            string[][] Ability = new string[PartsNum][];
            ComboBox[][] abi = new ComboBox[PartsNum][];
            for (int i = 0; i < PartsNum; i++)
            {
                abi[i] = new ComboBox[SlotMaxNum];
                if (i == 0)
                {
                    abi[i][0] = mw_tmp.crw_ability0;
                    abi[i][1] = mw_tmp.crw_ability1;
                    abi[i][2] = mw_tmp.crw_ability2;
                    abi[i][3] = mw_tmp.crw_ability3;
                    abi[i][4] = mw_tmp.crw_ability4;
                    abi[i][5] = mw_tmp.crw_ability5;
                    abi[i][6] = mw_tmp.crw_ability6;
                    abi[i][7] = mw_tmp.crw_ability7;
                    abi[i][8] = mw_tmp.crw_ability8;
                    abi[i][9] = mw_tmp.crw_ability9;
                }
                else if (i == 1)
                {
                    abi[i][0] = mw_tmp.lrw_ability0;
                    abi[i][1] = mw_tmp.lrw_ability1;
                    abi[i][2] = mw_tmp.lrw_ability2;
                    abi[i][3] = mw_tmp.lrw_ability3;
                    abi[i][4] = mw_tmp.lrw_ability4;
                    abi[i][5] = mw_tmp.lrw_ability5;
                    abi[i][6] = mw_tmp.lrw_ability6;
                    abi[i][7] = mw_tmp.lrw_ability7;
                    abi[i][8] = mw_tmp.lrw_ability8;
                    abi[i][9] = mw_tmp.lrw_ability9;
                }
                else if (i == 2)
                {
                    abi[i][0] = mw_tmp.head_ability0;
                    abi[i][1] = mw_tmp.head_ability1;
                    abi[i][2] = mw_tmp.head_ability2;
                    abi[i][3] = mw_tmp.head_ability3;
                    abi[i][4] = mw_tmp.head_ability4;
                    abi[i][5] = mw_tmp.head_ability5;
                    abi[i][6] = mw_tmp.head_ability6;
                    abi[i][7] = mw_tmp.head_ability7;
                    abi[i][8] = mw_tmp.head_ability8;
                    abi[i][9] = mw_tmp.head_ability9;
                }
                else if (i == 3)
                {
                    abi[i][0] = mw_tmp.body_ability0;
                    abi[i][1] = mw_tmp.body_ability1;
                    abi[i][2] = mw_tmp.body_ability2;
                    abi[i][3] = mw_tmp.body_ability3;
                    abi[i][4] = mw_tmp.body_ability4;
                    abi[i][5] = mw_tmp.body_ability5;
                    abi[i][6] = mw_tmp.body_ability6;
                    abi[i][7] = mw_tmp.body_ability7;
                    abi[i][8] = mw_tmp.body_ability8;
                    abi[i][9] = mw_tmp.body_ability9;
                }
                else if (i == 4)
                {
                    abi[i][0] = mw_tmp.arms_ability0;
                    abi[i][1] = mw_tmp.arms_ability1;
                    abi[i][2] = mw_tmp.arms_ability2;
                    abi[i][3] = mw_tmp.arms_ability3;
                    abi[i][4] = mw_tmp.arms_ability4;
                    abi[i][5] = mw_tmp.arms_ability5;
                    abi[i][6] = mw_tmp.arms_ability6;
                    abi[i][7] = mw_tmp.arms_ability7;
                    abi[i][8] = mw_tmp.arms_ability8;
                    abi[i][9] = mw_tmp.arms_ability9;
                }
                else if (i == 5)
                {
                    abi[i][0] = mw_tmp.leg_ability0;
                    abi[i][1] = mw_tmp.leg_ability1;
                    abi[i][2] = mw_tmp.leg_ability2;
                    abi[i][3] = mw_tmp.leg_ability3;
                    abi[i][4] = mw_tmp.leg_ability4;
                    abi[i][5] = mw_tmp.leg_ability5;
                    abi[i][6] = mw_tmp.leg_ability6;
                    abi[i][7] = mw_tmp.leg_ability7;
                    abi[i][8] = mw_tmp.leg_ability8;
                    abi[i][9] = mw_tmp.leg_ability9;
                }
                else if (i == 6)
                {
                    abi[i][0] = mw_tmp.bp_ability0;
                    abi[i][1] = mw_tmp.bp_ability1;
                    abi[i][2] = mw_tmp.bp_ability2;
                    abi[i][3] = mw_tmp.bp_ability3;
                    abi[i][4] = mw_tmp.bp_ability4;
                    abi[i][5] = mw_tmp.bp_ability5;
                    abi[i][6] = mw_tmp.bp_ability6;
                    abi[i][7] = mw_tmp.bp_ability7;
                    abi[i][8] = mw_tmp.bp_ability8;
                    abi[i][9] = mw_tmp.bp_ability9;
                }
                else if (i == 7)
                {
                    abi[i][0] = mw_tmp.sd_ability0;
                    abi[i][1] = mw_tmp.sd_ability1;
                    abi[i][2] = mw_tmp.sd_ability2;
                    abi[i][3] = mw_tmp.sd_ability3;
                    abi[i][4] = mw_tmp.sd_ability4;
                    abi[i][5] = mw_tmp.sd_ability5;
                    abi[i][6] = mw_tmp.sd_ability6;
                    abi[i][7] = mw_tmp.sd_ability7;
                    abi[i][8] = mw_tmp.sd_ability8;
                    abi[i][9] = mw_tmp.sd_ability9;
                }
            }

            for (int i = 0; i < RareTbl.Count; i++)
            {
                if (mw_tmp.crw_rarity00.Text == RareTbl[i].name)
                {
                    Ability[0] = ReadRarity(i, abi[0]);
                }
                if (mw_tmp.lrw_rarity00.Text == RareTbl[i].name)
                {
                    Ability[1] = ReadRarity(i, abi[1]);
                }
                if (mw_tmp.head_rarity00.Text == RareTbl[i].name)
                {
                    Ability[2] = ReadRarity(i, abi[2]);
                }
                if (mw_tmp.body_rarity00.Text == RareTbl[i].name)
                {
                    Ability[3] = ReadRarity(i, abi[3]);
                }
                if (mw_tmp.arms_rarity00.Text == RareTbl[i].name)
                {
                    Ability[4] = ReadRarity(i, abi[4]);
                }
                if (mw_tmp.leg_rarity00.Text == RareTbl[i].name)
                {
                    Ability[5] = ReadRarity(i, abi[5]);
                }
                if (mw_tmp.bp_rarity00.Text == RareTbl[i].name)
                {
                    Ability[6] = ReadRarity(i, abi[6]);
                }
                if (mw_tmp.sd_rarity00.Text == RareTbl[i].name)
                {
                    Ability[7] = ReadRarity(i, abi[7]);
                }
            }

            for (int i = 0; i < PartsNum; i++)
            {
                for (int j = 0; j < Ability[i].Length; j++)
                {
                    for (int x = i; x < PartsNum; x++)
                    {
                        for (int y = 0; y < Ability[x].Length; y++)
                        {
                            if (!((i == x) && (j == y)))
                            {
                                if (!((i == x) && (y < j)))
                                {
                                    if (Ability[i][j] != "" && Ability[x][y] != "")
                                    {
                                        int index1 = -1;
                                        int index2 = -1;
                                        for (int z = 0; z < fixabi.Count; z++)
                                        {
                                            if(fixabi[z].name == Ability[i][j])
                                            {
                                                index1 = z;
                                            }
                                            if (fixabi[z].name == Ability[x][y])
                                            {
                                                index2 = z;
                                            }
                                        }
                                        if (fixabi[index1].type == fixabi[index2].type)
                                        {
                                            PrintError(i, j, x, y);
                                            CmpVal(index1, index2);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
