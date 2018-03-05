namespace MiŚ.UI.Forms
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.userMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordUserItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffUserItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradesMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseGradesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyGradesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseAttendanceItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modidfyAttendanceItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagesMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseMessagesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMessagesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseInformationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeworkInformationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesAdministrationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsAdministrationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersAdministrationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationAdministrationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeworkAdministrationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMenuStripItem,
            this.gradesMenuStripItem,
            this.attendanceMenuStripItem,
            this.messagesMenuStripItem,
            this.informationMenuStripItem,
            this.administrationMenuStripItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenuStrip.Size = new System.Drawing.Size(1264, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // userMenuStripItem
            // 
            this.userMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserItem,
            this.changePasswordUserItem,
            this.logOffUserItem});
            this.userMenuStripItem.Name = "userMenuStripItem";
            this.userMenuStripItem.Size = new System.Drawing.Size(80, 20);
            this.userMenuStripItem.Text = "Użytkownik";
            // 
            // addUserItem
            // 
            this.addUserItem.Name = "addUserItem";
            this.addUserItem.Size = new System.Drawing.Size(174, 22);
            this.addUserItem.Text = "Dodaj użytkownika";
            // 
            // changePasswordUserItem
            // 
            this.changePasswordUserItem.Name = "changePasswordUserItem";
            this.changePasswordUserItem.Size = new System.Drawing.Size(174, 22);
            this.changePasswordUserItem.Text = "Zmień hasło";
            // 
            // logOffUserItem
            // 
            this.logOffUserItem.Name = "logOffUserItem";
            this.logOffUserItem.Size = new System.Drawing.Size(174, 22);
            this.logOffUserItem.Text = "Wyloguj się";
            // 
            // gradesMenuStripItem
            // 
            this.gradesMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseGradesItem,
            this.modifyGradesItem});
            this.gradesMenuStripItem.Name = "gradesMenuStripItem";
            this.gradesMenuStripItem.Size = new System.Drawing.Size(53, 20);
            this.gradesMenuStripItem.Text = "Oceny";
            // 
            // browseGradesItem
            // 
            this.browseGradesItem.Name = "browseGradesItem";
            this.browseGradesItem.Size = new System.Drawing.Size(177, 22);
            this.browseGradesItem.Text = "Przeglądaj oceny";
            // 
            // modifyGradesItem
            // 
            this.modifyGradesItem.Name = "modifyGradesItem";
            this.modifyGradesItem.Size = new System.Drawing.Size(177, 22);
            this.modifyGradesItem.Text = "Dodaj/zmień oceny";
            // 
            // attendanceMenuStripItem
            // 
            this.attendanceMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseAttendanceItem,
            this.modidfyAttendanceItem});
            this.attendanceMenuStripItem.Name = "attendanceMenuStripItem";
            this.attendanceMenuStripItem.Size = new System.Drawing.Size(78, 20);
            this.attendanceMenuStripItem.Text = "Frekwencja";
            // 
            // browseAttendanceItem
            // 
            this.browseAttendanceItem.Name = "browseAttendanceItem";
            this.browseAttendanceItem.Size = new System.Drawing.Size(202, 22);
            this.browseAttendanceItem.Text = "Przeglądaj frekwencję";
            // 
            // modidfyAttendanceItem
            // 
            this.modidfyAttendanceItem.Name = "modidfyAttendanceItem";
            this.modidfyAttendanceItem.Size = new System.Drawing.Size(202, 22);
            this.modidfyAttendanceItem.Text = "Dodaj/zmień frekwencję";
            // 
            // messagesMenuStripItem
            // 
            this.messagesMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseMessagesItem,
            this.sendMessagesItem});
            this.messagesMenuStripItem.Name = "messagesMenuStripItem";
            this.messagesMenuStripItem.Size = new System.Drawing.Size(85, 20);
            this.messagesMenuStripItem.Text = "Wiadomości";
            // 
            // browseMessagesItem
            // 
            this.browseMessagesItem.Name = "browseMessagesItem";
            this.browseMessagesItem.Size = new System.Drawing.Size(195, 22);
            this.browseMessagesItem.Text = "Przeglądaj wiadomości";
            // 
            // sendMessagesItem
            // 
            this.sendMessagesItem.Name = "sendMessagesItem";
            this.sendMessagesItem.Size = new System.Drawing.Size(195, 22);
            this.sendMessagesItem.Text = "Wyślij wiadomość";
            // 
            // informationMenuStripItem
            // 
            this.informationMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseInformationItem,
            this.homeworkInformationItem});
            this.informationMenuStripItem.Name = "informationMenuStripItem";
            this.informationMenuStripItem.Size = new System.Drawing.Size(76, 20);
            this.informationMenuStripItem.Text = "Informacje";
            // 
            // browseInformationItem
            // 
            this.browseInformationItem.Name = "browseInformationItem";
            this.browseInformationItem.Size = new System.Drawing.Size(187, 22);
            this.browseInformationItem.Text = "Przeglądaj ogłoszenia";
            // 
            // homeworkInformationItem
            // 
            this.homeworkInformationItem.Name = "homeworkInformationItem";
            this.homeworkInformationItem.Size = new System.Drawing.Size(187, 22);
            this.homeworkInformationItem.Text = "Zadania domowe";
            // 
            // administrationMenuStripItem
            // 
            this.administrationMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classesAdministrationItem,
            this.studentsAdministrationItem,
            this.teachersAdministrationItem,
            this.informationAdministrationItem,
            this.homeworkAdministrationItem});
            this.administrationMenuStripItem.Name = "administrationMenuStripItem";
            this.administrationMenuStripItem.Size = new System.Drawing.Size(92, 20);
            this.administrationMenuStripItem.Text = "Administracja";
            // 
            // classesAdministrationItem
            // 
            this.classesAdministrationItem.Name = "classesAdministrationItem";
            this.classesAdministrationItem.Size = new System.Drawing.Size(166, 22);
            this.classesAdministrationItem.Text = "Klasy";
            // 
            // studentsAdministrationItem
            // 
            this.studentsAdministrationItem.Name = "studentsAdministrationItem";
            this.studentsAdministrationItem.Size = new System.Drawing.Size(166, 22);
            this.studentsAdministrationItem.Text = "Uczniowie";
            // 
            // teachersAdministrationItem
            // 
            this.teachersAdministrationItem.Name = "teachersAdministrationItem";
            this.teachersAdministrationItem.Size = new System.Drawing.Size(166, 22);
            this.teachersAdministrationItem.Text = "Nauczyciele";
            // 
            // informationAdministrationItem
            // 
            this.informationAdministrationItem.Name = "informationAdministrationItem";
            this.informationAdministrationItem.Size = new System.Drawing.Size(166, 22);
            this.informationAdministrationItem.Text = "Panel ogłoszeń";
            // 
            // homeworkAdministrationItem
            // 
            this.homeworkAdministrationItem.Name = "homeworkAdministrationItem";
            this.homeworkAdministrationItem.Size = new System.Drawing.Size(166, 22);
            this.homeworkAdministrationItem.Text = "Zadania domowe";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mainMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MiŚ School";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem userMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem addUserItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordUserItem;
        private System.Windows.Forms.ToolStripMenuItem logOffUserItem;
        private System.Windows.Forms.ToolStripMenuItem gradesMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem browseGradesItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem browseAttendanceItem;
        private System.Windows.Forms.ToolStripMenuItem modidfyAttendanceItem;
        private System.Windows.Forms.ToolStripMenuItem messagesMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem administrationMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem classesAdministrationItem;
        private System.Windows.Forms.ToolStripMenuItem studentsAdministrationItem;
        private System.Windows.Forms.ToolStripMenuItem modifyGradesItem;
        private System.Windows.Forms.ToolStripMenuItem browseMessagesItem;
        private System.Windows.Forms.ToolStripMenuItem sendMessagesItem;
        private System.Windows.Forms.ToolStripMenuItem informationMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem browseInformationItem;
        private System.Windows.Forms.ToolStripMenuItem homeworkInformationItem;
        private System.Windows.Forms.ToolStripMenuItem teachersAdministrationItem;
        private System.Windows.Forms.ToolStripMenuItem informationAdministrationItem;
        private System.Windows.Forms.ToolStripMenuItem homeworkAdministrationItem;
    }
}