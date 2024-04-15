using CRM_Robyline.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM_Robyline.Service.Until
{
    class ViewModelLocator
    {
        public static MainWindowModel windowModel => Ioc.ReResolve<MainWindowModel>();
        public static SidebarModel sidebarModel => Ioc.ReResolve<SidebarModel>();
    }
}
