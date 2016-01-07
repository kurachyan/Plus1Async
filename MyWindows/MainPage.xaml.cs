using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Plus1Async;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 を参照してください

namespace MyWindows
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        #region 初期設定
        private CS_Plus1Async plus1;
        #endregion

        public MainPage()
        {
            this.InitializeComponent();
            plus1 = new CS_Plus1Async();

            TextBox01.Text = "";
        }

        private async void TextBox01_TextChanged(object sender, TextChangedEventArgs e)
        {   // 初期値の変更
            if (TextBox01.Text.Length != 0)
            {   //  初期値の設定あり？
                int _add = int.Parse(TextBox01.Text);   // 初期値を設定する

                await plus1.SetAsync(_add);
            }
        }

        private async void Button01_Click(object sender, RoutedEventArgs e)
        {   // [＋１]ボタン押下

            await plus1.ExecAsync();        // ［＋１］実行

            int _ans = plus1.Result;
            TextBox01.Text = _ans.ToString();    // 結果表示

        }

        private async void Button02_Click(object sender, RoutedEventArgs e)
        {   // [Ｒｅｓｅｔ]ボタン押下
            await plus1.ClearAsync();

            TextBox01.Text = "";
        }
    }
}
