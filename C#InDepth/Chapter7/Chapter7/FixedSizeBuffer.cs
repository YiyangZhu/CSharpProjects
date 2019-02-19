using System;
using System.Runtime.InteropServices;

namespace Chapter7
{
    public class FixedSizeBuffer
    {
        public FixedSizeBuffer()
        {
        }
    }

    struct COORD
    {
        public short X, Y;
    }

    struct SMALL_RECT
    {
        public short Left, Top, Right, Bottom;
    }

    //use unsafe will introduce error: unsafe code may only appear if compiling with /unsafe
    struct CONSOLE_SCREEN_BUFFER_INFOEX
    {
        public int StructureSize;
        public COORD ConsoleSize, CursorPosition;
        public short Attributes;
        public SMALL_RECT DisplayWindow;
        public COORD MaximumwindowSize;
        public short PopupAttributes;
        public int FullScreenSupported;
        //Pointers and fixed size buffer may only be used in an unsafe context
        //public fixed int ColorTable[16];
    }

    static class FixedSizeBufferDemo
    {
        const int StdOutputHandle = -11;

        [DllImport("kernel32.dll")]
        static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll")]
        static extern bool GetConsoleScreenBufferInfoEx(IntPtr handle, ref CONSOLE_SCREEN_BUFFER_INFOEX info);

        //use unsafe will introduce error: unsafe code may only appear if compiling with /unsafe
        /*unsafe static void Main()
        {
            IntPtr handle = GetStdHandle(StdOutputHandle);
            CONSOLE_SCREEN_BUFFER_INFOEX info;
            info = new CONSOLE_SCREEN_BUFFER_INFOEX();
            //the following state can only be used in an unsafe context
            //info.StructureSize = sizeof(CONSOLE_SCREEN_BUFFER_INFOEX);
            GetConsoleScreenBufferInfoEx(handle, ref info); 

            for(int i = 0; i < 16; i++)
            {
                Console.WriteLine("{0:x6}", info.ColorTable[i]);
            }
        }
        */


    }
}
