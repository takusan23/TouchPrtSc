using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// スクリーンショットのショートカットキーを送信する
/// </summary>
namespace TouchPrtSc
{
    class SendScreenShotKeyCode
    {

        /// <summary>
        /// スクリーンショットのショートカットキー(PrintScreen+Win)を送信する
        /// </summary>
        public static void Send()
        {
            WindowsAPISendInput.Input[] inputs = new WindowsAPISendInput.Input[4];

            // Windowsキー押す
            inputs[0] = new WindowsAPISendInput.Input();
            inputs[0].Type = 1;
            inputs[0].ui.Keyboard.VirtualKey = (short)WindowsAPISendInput.VK_LWIN;
            inputs[0].ui.Keyboard.ScanCode = (short)WindowsAPISendInput.MapVirtualKey(WindowsAPISendInput.VK_LWIN, 0);
            inputs[0].ui.Keyboard.Flags = WindowsAPISendInput.KEYEVENTF_KEYDOWN;
            inputs[0].ui.Keyboard.Time = 0;
            inputs[0].ui.Keyboard.ExtraInfo = IntPtr.Zero;

            // PrintScreenキー押す
            inputs[1] = new WindowsAPISendInput.Input();
            inputs[1].Type = 1;
            inputs[1].ui.Keyboard.VirtualKey = (short)WindowsAPISendInput.VK_SNAPSHOT;
            inputs[1].ui.Keyboard.ScanCode = (short)WindowsAPISendInput.MapVirtualKey(WindowsAPISendInput.VK_SNAPSHOT, 0);
            inputs[1].ui.Keyboard.Flags = WindowsAPISendInput.KEYEVENTF_KEYDOWN;
            inputs[1].ui.Keyboard.Time = 0;
            inputs[1].ui.Keyboard.ExtraInfo = IntPtr.Zero;

            // PrintScreenキー離す
            inputs[2] = new WindowsAPISendInput.Input();
            inputs[2].Type = 1;
            inputs[2].ui.Keyboard.VirtualKey = (short)WindowsAPISendInput.VK_SNAPSHOT;
            inputs[2].ui.Keyboard.ScanCode = (short)WindowsAPISendInput.MapVirtualKey(WindowsAPISendInput.VK_SNAPSHOT, 0);
            inputs[2].ui.Keyboard.Flags = WindowsAPISendInput.KEYEVENTF_KEYUP;
            inputs[2].ui.Keyboard.Time = 0;
            inputs[2].ui.Keyboard.ExtraInfo = IntPtr.Zero;

            // Windowsキー離す
            inputs[3] = new WindowsAPISendInput.Input();
            inputs[3].Type = 1;
            inputs[3].ui.Keyboard.VirtualKey = (short)WindowsAPISendInput.VK_LWIN;
            inputs[3].ui.Keyboard.ScanCode = (short)WindowsAPISendInput.MapVirtualKey(WindowsAPISendInput.VK_LWIN, 0);
            inputs[3].ui.Keyboard.Flags = WindowsAPISendInput.KEYEVENTF_KEYUP;
            inputs[3].ui.Keyboard.Time = 0;
            inputs[3].ui.Keyboard.ExtraInfo = IntPtr.Zero;

            WindowsAPISendInput.SendInput(inputs.Length, inputs, Marshal.SizeOf(inputs[0]));
        }
    }
}
