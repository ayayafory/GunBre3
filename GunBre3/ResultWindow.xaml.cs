using System.Windows;
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

        public ResultWindow(MainWindow mw)
        {
            InitializeComponent();
            mw_tmp = mw;
        }

        private void Check()
        {

        }
    }
}
