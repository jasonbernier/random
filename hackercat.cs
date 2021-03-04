using System;
using System.Runtime.InteropServices;
using System.Net;


namespace HackerCat
{
    class Program
    {
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAlloc(IntPtr lpAddress, uint dwSize,
       uint flAllocationType, uint flProtect);
        [DllImport("kernel32.dll")]
        static extern IntPtr CreateThread(IntPtr lpThreadAttributes,
        uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter,
        uint dwCreationFlags, IntPtr lpThreadId);
        [DllImport("kernel32.dll")]
        static extern UInt32 WaitForSingleObject(IntPtr hHandle,
        UInt32 dwMilliseconds);
        [DllImport("kernel32.dll")]
        static extern void Sleep(uint dwMilliseconds);



        static void Main(string[] args)
        {
            DateTime t1 = DateTime.Now;
            Sleep(2000);
            double t2 = DateTime.Now.Subtract(t1).TotalSeconds;
            if (t2 < 1.5)
            {
                return;
            }
            Console.Write("");
            Console.Write("Hacker Cat!");
            Console.Write("");
            
            //Add proxy server info here
            WebProxy proxyObject = new WebProxy("X.X.X.X", 8080);
            
            WebRequest req = WebRequest.Create("https://giphy.com/gifs/unQ3IJU2RG7DO/html5");
            req.Proxy = proxyObject;
            Console.Write("");
            Console.Write("");
            Console.Write("Look at him go!");
            Console.Write("");

            {
              Console.Write("Hacker Cat is infinite!");
                System.Threading.Thread.Sleep(-1);
            }
        }
        
    }
}
