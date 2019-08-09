namespace Solution3.Module.Controllers
{
    partial class NotificationController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.simpleAction1 = new DevExpress.ExpressApp.Actions.SimpleAction();
            // 
            // simpleAction1
            // 
            this.simpleAction1.Caption = "cd39ba30-a4d2-46d4-a772-a12fa27e3d49";
            this.simpleAction1.ConfirmationMessage = null;
            this.simpleAction1.Id = "cd39ba30-a4d2-46d4-a772-a12fa27e3d49";
            this.simpleAction1.TargetObjectType = typeof(Solution3.Module.BusinessObjects.DemoTask);
            this.simpleAction1.TargetViewType = DevExpress.ExpressApp.ViewType.DashboardView;
            this.simpleAction1.ToolTip = null;
            this.simpleAction1.TypeOfView = typeof(DevExpress.ExpressApp.DashboardView);
            this.simpleAction1.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleAction1_Execute);
            // 
            // NotificationController
            // 
            this.Actions.Add(this.simpleAction1);
            this.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction simpleAction1;
    }
}
