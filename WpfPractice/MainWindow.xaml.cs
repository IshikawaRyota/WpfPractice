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

namespace WpfPractice
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string moji = (string)btn.Content; //　object型のbtn.ContentをString型に変換

            if (moji == "Ishikawa") // ボタンの表記(Content)がIshikawaならばクリックでGoemonに変更
            {
                btn.Content = "Goemon";
            }
            else if (moji == "Goemon")
            {
                btn.Content = "Ishikawa";
            }
        }

        private void cbx_Checked(object sender, RoutedEventArgs e)
        {
            // btnの表記を日本語に変更するチェックボックス
            if ((string)btn.Content == "Ishikawa")
            {
                btn.Content = "石川";
            }
            else if ((string)btn.Content == "Goemon")
            {
                btn.Content = "五右衛門";
            }
        }
    }
}
