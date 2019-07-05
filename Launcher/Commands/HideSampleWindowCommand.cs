using System.Windows;
using System.Windows.Input;
using System.Diagnostics;

namespace Samples.Commands
{
    /// <summary>
    /// Hides the main window.
    /// </summary>
    public class HideSampleWindowCommand : CommandBase<HideSampleWindowCommand>
    {
        public override void Execute(object parameter)
        {
            GetTaskbarWindow(parameter).Hide();
            CommandManager.InvalidateRequerySuggested();
        }


        public override bool CanExecute(object parameter)
        {
            Window win = GetTaskbarWindow(parameter);
            return win != null && win.IsVisible;
        }
    }
    public class Launch : CommandBase<Launch>
    {

        public override void Execute(object parameter)
        {
            GetTaskbarWindow(parameter).Hide();
            Process.Start("wowstep.exe");
            GetTaskbarWindow(parameter).Hide();
        }
        public override bool CanExecute(object parameter)
        {
            Window win = GetTaskbarWindow(parameter);
            return win != null;

        }
    }
}