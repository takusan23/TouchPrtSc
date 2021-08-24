using System;
using System.Runtime.InteropServices;

/// <summary>
/// 参考：https://qiita.com/kob58im/items/ca3b61e72111dfbab8a8
/// 
/// C#でWindowsAPIのSendInputを呼び出す
/// 
/// thx!
/// </summary>
namespace TouchPrtSc
{
    class WindowsAPISendInput
    {

        [DllImport("user32.dll", SetLastError = true)]
        public extern static void SendInput(int nInputs, Input[] pInputs, int cbsize);

        [DllImport("user32.dll", EntryPoint = "MapVirtualKeyA")]
        public extern static int MapVirtualKey(int wCode, int wMapType);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MouseInput
        {
            public int X;
            public int Y;
            public int Data;
            public int Flags;
            public int Time;
            public IntPtr ExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct KeyboardInput
        {
            public short VirtualKey;
            public short ScanCode;
            public int Flags;
            public int Time;
            public IntPtr ExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HardwareInput
        {
            public int uMsg;
            public short wParamL;
            public short wParamH;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Input
        {
            public int Type;
            public InputUnion ui;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct InputUnion
        {
            [FieldOffset(0)]
            public MouseInput Mouse;
            [FieldOffset(0)]
            public KeyboardInput Keyboard;
            [FieldOffset(0)]
            public HardwareInput Hardware;
        }

        public const int INPUT_MOUSE = 0;

        public const int INPUT_KEYBOARD = 1;

        public const int INPUT_HARDWARE = 2;

        public const int KEYEVENTF_KEYDOWN = 0x0;

        public const int KEYEVENTF_KEYUP = 0x2;

        public const int KEYEVENTF_EXTENDEDKEY = 0x1;

        public const int VK_SNAPSHOT = 0x2C;

        public const int VK_LWIN = 0x5B;


    }
}
