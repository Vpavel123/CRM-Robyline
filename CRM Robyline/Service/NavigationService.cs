using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CRM_Robyline.Service
{
    class NavigationService
    {
        public static NavigationService Inst { get; private set; }
        public Action<UserControl> OnNavigate;

        static NavigationService()
        {
            Inst = new NavigationService();
        }
        private NavigationService() { }

        public void PageControl(UserControl page)
        {
            OnNavigate.Invoke(page);
        }
    }
}
