            using System;
using System.Runtime.InteropServices;

namespace ParallelPort
{
   class PortAccess
  {
     [DllImport("inpout32.dll", EntryPoint="Out32")]
     public static extern void Output(int adress, int value);

     [DllImport("inpout32.dll", EntryPoint="Inp32")]
     public static extern void Input( int adress);
  }
}