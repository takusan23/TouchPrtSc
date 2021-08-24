using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace TouchPrtSc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// スクリーンショットのショートカットキーを送信する
        /// </summary>
        private async void ScreenShotIconButton_Click(object sender, RoutedEventArgs e)
        {
            // 一旦このウィンドウを消す
            Hide();
            await Task.Delay(100);
            // スクリーンショットのショートカットキーを送信
            SendScreenShotKeyCode.Send();
            // また戻す
            await Task.Delay(100);
            Show();
        }

        /// <summary>
        /// 終了ボタン
        /// </summary>
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        /// <summary>
        /// 動かせるようにする
        /// </summary>
        private void MouseMoveButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
