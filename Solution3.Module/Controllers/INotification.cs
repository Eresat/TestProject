using DevExpress.ExpressApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution3.Module.Controllers
{
    interface INotification
    {       
        string Message { get; set; }
        bool ShowAttribute { get; set; }
        InformationType NotificationKind { get; set; }
        void Show();
        
    }
}
