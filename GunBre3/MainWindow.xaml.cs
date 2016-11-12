﻿using System;
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
        public MainWindow()
        {
            InitializeComponent();
            SetRarelityComboBox(crw_rarity00);
            SetRarelityComboBox(lrw_rarity00);
            SetRarelityComboBox(head_rarity00);
            SetRarelityComboBox(body_rarity00);
            SetRarelityComboBox(arms_rarity00);
            SetRarelityComboBox(leg_rarity00);
            SetRarelityComboBox(bp_rarity00);
            SetRarelityComboBox(sd_rarity00);
        }
    }
}
