
using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DialogFinder;

namespace DialogFinder
{
/// <author>Shrijeet Nair</author>
public class Win32
{
[DllImport("User32.dll")]
public static extern Int32 FindWindow(String lpClassName,String lpWindowName);
[DllImport("User32.dll")]
public static extern Int32 SetForegroundWindow(int hWnd);
[DllImport("User32.dll")]
public static extern Boolean EnumChildWindows(int hWndParent,Delegate lpEnumFunc,int lParam);
[DllImport("User32.dll")]
public static extern Int32 GetWindowText(int hWnd,StringBuilder s,int nMaxCount);
[DllImport("User32.dll")]
public static extern Int32 GetWindowTextLength(int hwnd);
[DllImport("user32.dll", EntryPoint="GetDesktopWindow")]
public static extern int GetDesktopWindow();
}
}


