using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.

namespace DialogFinder
{
    /// <span class="code-SummaryComment"><summary></span>
    /// Intercept creation of window and call a handler
    /// <span class="code-SummaryComment"></summary></span>
    public class WindowInterceptor
    {
        IntPtr hook_id = IntPtr.Zero;

        Win32.Functions.HookProc cbf;

        /// <span class="code-SummaryComment"><summary></span>
        /// Delegate to process intercepted window
        /// <span class="code-SummaryComment"></summary></span>
        /// <span class="code-SummaryComment"><param name="hwnd"></param></span>
        public delegate void ProcessWindow(IntPtr hwnd);
        ProcessWindow process_window;

        IntPtr owner_window = IntPtr.Zero;

        /// <span class="code-SummaryComment"><summary></span>
        /// Start dialog box interception for the specified owner window
        /// <span class="code-SummaryComment"></summary></span>
        /// <span class="code-SummaryComment"><param name="owner_window">owner window; if IntPtr.Zero,</span>
        /// any windows will be intercepted<span class="code-SummaryComment"></param></span>
        /// <span class="code-SummaryComment"><param name="process_window">custom delegate to process intercepted window</span>
        /// <span class="code-SummaryComment"></param></span>
        public WindowInterceptor(IntPtr owner_window, ProcessWindow process_window)
        {
            if (process_window == null)
                throw new Exception("process_window cannot be null!");
            this.process_window = process_window;

            this.owner_window = owner_window;

            cbf = new Win32.Functions.HookProc(dlg_box_hook_proc);
            //notice that win32 callback function must be a global variable within class
            //to avoid disposing it!
            hook_id = Win32.Functions.SetWindowsHookEx(Win32.HookType.WH_CALLWNDPROCRET,
                     cbf, IntPtr.Zero, Win32.Functions.GetCurrentThreadId());
        }

        /// <span class="code-SummaryComment"><summary></span>
        /// Stop intercepting. Should be called to calm unmanaged code correctly
        /// <span class="code-SummaryComment"></summary></span>
        public void Stop()
        {
            if (hook_id != IntPtr.Zero)
                Win32.Functions.UnhookWindowsHookEx(hook_id);
            hook_id = IntPtr.Zero;
        }

        ~WindowInterceptor()
        {
            if (hook_id != IntPtr.Zero)
                Win32.Functions.UnhookWindowsHookEx(hook_id);
        }

        private IntPtr dlg_box_hook_proc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode < 0)
                return Win32.Functions.CallNextHookEx(hook_id, nCode, wParam, lParam);

            Win32.CWPRETSTRUCT msg = (Win32.CWPRETSTRUCT)Marshal.PtrToStructure
                (lParam, typeof(Win32.CWPRETSTRUCT));

            //filter out create window events only
            if (msg.message == (uint)Win32.Messages.WM_SHOWWINDOW)
            {
                int h = Win32.Functions.GetWindow(msg.hwnd, Win32.Functions.GW_OWNER);
                //check if owner is that is specified
                if (owner_window == IntPtr.Zero || owner_window == new IntPtr(h))
                {
                    if (process_window != null)
                        process_window(msg.hwnd);
                }
            }

            return Win32.Functions.CallNextHookEx(hook_id, nCode, wParam, lParam);
        }
    }
}
