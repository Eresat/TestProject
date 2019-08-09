using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using Solution3.Module.BusinessObjects;

namespace Solution3.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class NotificationController : ViewController
    {
        public bool ShowAttribute { get; set; }
        public string Message { get; set; }
        public InformationType NotificationKind { get; set; }
        public NotificationController()
        {
            InitializeComponent();
        }
        public NotificationController(bool showAttribute, string message, InformationType notificationKind)
        {
            InitializeComponent();
            ShowAttribute = showAttribute;
            Message = message;
            NotificationKind = notificationKind;
        }

        protected override void OnActivated()
        {
            base.OnActivated();
            if (ShowAttribute)
            {
                ObjectSpace.ObjectChanged += ObjectSpaceOnObjectChanged;
                ShowAttribute = false;
            }
        }
        void ObjectSpaceOnObjectChanged(object sender, ObjectChangedEventArgs e)
        {
            string message = (string)e.NewValue;
            Show(message);
        }

        public void Show(string message)
        {
            MessageOptions options = new MessageOptions();
            options.Duration = 20000;
            options.Message = string.Format("Я открылся! LoL " + message);
            options.Type = (InformationType)1;
            options.Web.Position = InformationPosition.Bottom;
            options.Win.Caption = "Успешно";
            options.Win.Type = WinMessageType.Toast;
            Application.ShowViewStrategy.ShowMessage(options);
        }
    
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
//            Notification notification = new Notification(true, "LoL");
//            notification.ShowNotification();

        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void simpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e)
        {

        }
    }
}
