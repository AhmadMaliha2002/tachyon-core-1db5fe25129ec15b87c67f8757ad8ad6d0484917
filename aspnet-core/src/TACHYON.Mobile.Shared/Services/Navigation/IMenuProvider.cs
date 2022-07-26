using System.Collections.Generic;
using MvvmHelpers;
using TACHYON.Models.NavigationMenu;

namespace TACHYON.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}