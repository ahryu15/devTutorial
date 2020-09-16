namespace devTutorial.Module.Controllers
{
    partial class ClearContactTasksController
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
            this.components = new System.ComponentModel.Container();
            this.ClearTasksAction = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // ClearTasksAction
            // 
            this.ClearTasksAction.Caption = "Clear Tasks";
            this.ClearTasksAction.Category = "View";
            this.ClearTasksAction.ConfirmationMessage = "작업 목록을 모두 삭제하겠습니까?";
            this.ClearTasksAction.Id = "9446da7c-86dd-4a43-ab9a-e8dac5810c6f";
            this.ClearTasksAction.ImageName = "Action_Clear";
            this.ClearTasksAction.ToolTip = null;
            this.ClearTasksAction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ClearTasksAction_Execute);
            // 
            // ClearContactTasksController
            // 
            this.Actions.Add(this.ClearTasksAction);
            this.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.Activated += new System.EventHandler(this.ClearContactTasksController_Activated);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ClearTasksAction;
    }
}
