using Xamarin.Forms.Internals;

namespace TACHYON.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}