using DevExpress.ExpressApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution3.Module.BusinessObjects
{
    interface INotification
    {
        string Message { get; set; }
        bool ShowAttribute { get; set; }
        InformationType NotificationKind { get; set; }
        void Show();
    }

    public class Notification : ViewController
    {
        public string Message { get; set; }
        public bool ShowAttribute { get; set; }
        public InformationType NotificationKind { get; set; }

        public Notification() { }
        public Notification(bool showAttribute, string message, InformationType notificationKind)
        {
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
            }
        }
        void ObjectSpaceOnObjectChanged(object sender, ObjectChangedEventArgs e)
        {
            string message =(string) e.NewValue;
            Show(message);
        }

        public void Show(string message)
        {
            MessageOptions options = new MessageOptions();
            options.Duration = 20000;
            options.Message = string.Format("Я открылся! LoL " + message);
            options.Type = (InformationType) 1;
            options.Web.Position = InformationPosition.Bottom;
            options.Win.Caption = "Успешно";
            options.Win.Type = WinMessageType.Toast;
            Application.ShowViewStrategy.ShowMessage(options);
        }
    }

    
}

