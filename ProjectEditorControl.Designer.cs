namespace UIBuilder
{
    partial class ProjectEditorControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectEditorControl));
            this.ProjectNameControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.GlobalUsingsControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.ProgramFileControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.ProjectFileControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.ResourcesFileControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.MainFormControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.CreateProjectButton = new DataJuggler.Win.Controls.Button();
            this.CancelNewProjectButton = new DataJuggler.Win.Controls.Button();
            this.LeftMarginControl = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new DataJuggler.Win.Controls.LabelLabelControl();
            this.BlazorCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.WinFormsCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.CloseTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ProjectNameControl
            // 
            this.ProjectNameControl.BackColor = System.Drawing.Color.Transparent;
            this.ProjectNameControl.BottomMargin = 0;
            this.ProjectNameControl.Editable = true;
            this.ProjectNameControl.Encrypted = false;
            this.ProjectNameControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectNameControl.Inititialized = true;
            this.ProjectNameControl.LabelBottomMargin = 0;
            this.ProjectNameControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ProjectNameControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProjectNameControl.LabelText = "Project Name:";
            this.ProjectNameControl.LabelTopMargin = 0;
            this.ProjectNameControl.LabelWidth = 140;
            this.ProjectNameControl.Location = new System.Drawing.Point(57, 47);
            this.ProjectNameControl.MultiLine = false;
            this.ProjectNameControl.Name = "ProjectNameControl";
            this.ProjectNameControl.OnTextChangedListener = null;
            this.ProjectNameControl.PasswordMode = false;
            this.ProjectNameControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProjectNameControl.Size = new System.Drawing.Size(578, 32);
            this.ProjectNameControl.TabIndex = 18;
            this.ProjectNameControl.TextBoxBottomMargin = 0;
            this.ProjectNameControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.ProjectNameControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.ProjectNameControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectNameControl.TextBoxTopMargin = 0;
            this.ProjectNameControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // GlobalUsingsControl
            // 
            this.GlobalUsingsControl.BackColor = System.Drawing.Color.Transparent;
            this.GlobalUsingsControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.GlobalUsingsControl.ButtonColor = System.Drawing.Color.LemonChiffon;
            this.GlobalUsingsControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("GlobalUsingsControl.ButtonImage")));
            this.GlobalUsingsControl.ButtonWidth = 48;
            this.GlobalUsingsControl.DarkMode = false;
            this.GlobalUsingsControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.GlobalUsingsControl.Editable = true;
            this.GlobalUsingsControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.GlobalUsingsControl.Filter = null;
            this.GlobalUsingsControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GlobalUsingsControl.HideBrowseButton = false;
            this.GlobalUsingsControl.LabelBottomMargin = 0;
            this.GlobalUsingsControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.GlobalUsingsControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GlobalUsingsControl.LabelText = "Global Usings:";
            this.GlobalUsingsControl.LabelTopMargin = 0;
            this.GlobalUsingsControl.LabelWidth = 140;
            this.GlobalUsingsControl.Location = new System.Drawing.Point(57, 287);
            this.GlobalUsingsControl.Name = "GlobalUsingsControl";
            this.GlobalUsingsControl.OnTextChangedListener = null;
            this.GlobalUsingsControl.OpenCallback = null;
            this.GlobalUsingsControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GlobalUsingsControl.SelectedPath = null;
            this.GlobalUsingsControl.Size = new System.Drawing.Size(578, 32);
            this.GlobalUsingsControl.StartPath = null;
            this.GlobalUsingsControl.TabIndex = 17;
            this.GlobalUsingsControl.TextBoxBottomMargin = 0;
            this.GlobalUsingsControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.GlobalUsingsControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.GlobalUsingsControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GlobalUsingsControl.TextBoxTopMargin = 0;
            this.GlobalUsingsControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ProgramFileControl
            // 
            this.ProgramFileControl.BackColor = System.Drawing.Color.Transparent;
            this.ProgramFileControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.ProgramFileControl.ButtonColor = System.Drawing.Color.LemonChiffon;
            this.ProgramFileControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("ProgramFileControl.ButtonImage")));
            this.ProgramFileControl.ButtonWidth = 48;
            this.ProgramFileControl.DarkMode = false;
            this.ProgramFileControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.ProgramFileControl.Editable = true;
            this.ProgramFileControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.ProgramFileControl.Filter = null;
            this.ProgramFileControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgramFileControl.HideBrowseButton = false;
            this.ProgramFileControl.LabelBottomMargin = 0;
            this.ProgramFileControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ProgramFileControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProgramFileControl.LabelText = "Program.cs:";
            this.ProgramFileControl.LabelTopMargin = 0;
            this.ProgramFileControl.LabelWidth = 140;
            this.ProgramFileControl.Location = new System.Drawing.Point(57, 239);
            this.ProgramFileControl.Name = "ProgramFileControl";
            this.ProgramFileControl.OnTextChangedListener = null;
            this.ProgramFileControl.OpenCallback = null;
            this.ProgramFileControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProgramFileControl.SelectedPath = null;
            this.ProgramFileControl.Size = new System.Drawing.Size(578, 32);
            this.ProgramFileControl.StartPath = null;
            this.ProgramFileControl.TabIndex = 16;
            this.ProgramFileControl.TextBoxBottomMargin = 0;
            this.ProgramFileControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.ProgramFileControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.ProgramFileControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgramFileControl.TextBoxTopMargin = 0;
            this.ProgramFileControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ProjectFileControl
            // 
            this.ProjectFileControl.BackColor = System.Drawing.Color.Transparent;
            this.ProjectFileControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.ProjectFileControl.ButtonColor = System.Drawing.Color.LemonChiffon;
            this.ProjectFileControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("ProjectFileControl.ButtonImage")));
            this.ProjectFileControl.ButtonWidth = 48;
            this.ProjectFileControl.DarkMode = false;
            this.ProjectFileControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.ProjectFileControl.Editable = true;
            this.ProjectFileControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.ProjectFileControl.Filter = null;
            this.ProjectFileControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectFileControl.HideBrowseButton = false;
            this.ProjectFileControl.LabelBottomMargin = 0;
            this.ProjectFileControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ProjectFileControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProjectFileControl.LabelText = "Project File:";
            this.ProjectFileControl.LabelTopMargin = 0;
            this.ProjectFileControl.LabelWidth = 140;
            this.ProjectFileControl.Location = new System.Drawing.Point(57, 191);
            this.ProjectFileControl.Name = "ProjectFileControl";
            this.ProjectFileControl.OnTextChangedListener = null;
            this.ProjectFileControl.OpenCallback = null;
            this.ProjectFileControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProjectFileControl.SelectedPath = null;
            this.ProjectFileControl.Size = new System.Drawing.Size(578, 32);
            this.ProjectFileControl.StartPath = null;
            this.ProjectFileControl.TabIndex = 15;
            this.ProjectFileControl.TextBoxBottomMargin = 0;
            this.ProjectFileControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.ProjectFileControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.ProjectFileControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectFileControl.TextBoxTopMargin = 0;
            this.ProjectFileControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ResourcesFileControl
            // 
            this.ResourcesFileControl.BackColor = System.Drawing.Color.Transparent;
            this.ResourcesFileControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.ResourcesFileControl.ButtonColor = System.Drawing.Color.LemonChiffon;
            this.ResourcesFileControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("ResourcesFileControl.ButtonImage")));
            this.ResourcesFileControl.ButtonWidth = 48;
            this.ResourcesFileControl.DarkMode = false;
            this.ResourcesFileControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.ResourcesFileControl.Editable = true;
            this.ResourcesFileControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.ResourcesFileControl.Filter = null;
            this.ResourcesFileControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResourcesFileControl.HideBrowseButton = false;
            this.ResourcesFileControl.LabelBottomMargin = 0;
            this.ResourcesFileControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ResourcesFileControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResourcesFileControl.LabelText = "Resources:";
            this.ResourcesFileControl.LabelTopMargin = 0;
            this.ResourcesFileControl.LabelWidth = 140;
            this.ResourcesFileControl.Location = new System.Drawing.Point(57, 143);
            this.ResourcesFileControl.Name = "ResourcesFileControl";
            this.ResourcesFileControl.OnTextChangedListener = null;
            this.ResourcesFileControl.OpenCallback = null;
            this.ResourcesFileControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ResourcesFileControl.SelectedPath = null;
            this.ResourcesFileControl.Size = new System.Drawing.Size(578, 32);
            this.ResourcesFileControl.StartPath = null;
            this.ResourcesFileControl.TabIndex = 14;
            this.ResourcesFileControl.TextBoxBottomMargin = 0;
            this.ResourcesFileControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.ResourcesFileControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.ResourcesFileControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResourcesFileControl.TextBoxTopMargin = 0;
            this.ResourcesFileControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MainFormControl
            // 
            this.MainFormControl.BackColor = System.Drawing.Color.Transparent;
            this.MainFormControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.MainFormControl.ButtonColor = System.Drawing.Color.LemonChiffon;
            this.MainFormControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("MainFormControl.ButtonImage")));
            this.MainFormControl.ButtonWidth = 48;
            this.MainFormControl.DarkMode = false;
            this.MainFormControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.MainFormControl.Editable = true;
            this.MainFormControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.MainFormControl.Filter = null;
            this.MainFormControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainFormControl.HideBrowseButton = false;
            this.MainFormControl.LabelBottomMargin = 0;
            this.MainFormControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.MainFormControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainFormControl.LabelText = "Main Form:";
            this.MainFormControl.LabelTopMargin = 0;
            this.MainFormControl.LabelWidth = 140;
            this.MainFormControl.Location = new System.Drawing.Point(57, 95);
            this.MainFormControl.Name = "MainFormControl";
            this.MainFormControl.OnTextChangedListener = null;
            this.MainFormControl.OpenCallback = null;
            this.MainFormControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MainFormControl.SelectedPath = null;
            this.MainFormControl.Size = new System.Drawing.Size(578, 32);
            this.MainFormControl.StartPath = null;
            this.MainFormControl.TabIndex = 12;
            this.MainFormControl.TextBoxBottomMargin = 0;
            this.MainFormControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.MainFormControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.MainFormControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainFormControl.TextBoxTopMargin = 0;
            this.MainFormControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // CreateProjectButton
            // 
            this.CreateProjectButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateProjectButton.ButtonText = "Save Project";
            this.CreateProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateProjectButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CreateProjectButton.Location = new System.Drawing.Point(383, 425);
            this.CreateProjectButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateProjectButton.Name = "CreateProjectButton";
            this.CreateProjectButton.Size = new System.Drawing.Size(148, 44);
            this.CreateProjectButton.TabIndex = 11;
            this.CreateProjectButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.CreateProjectButton.Click += new System.EventHandler(this.CreateProjectButton_Click);
            // 
            // CancelNewProjectButton
            // 
            this.CancelNewProjectButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelNewProjectButton.ButtonText = "Cancel";
            this.CancelNewProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelNewProjectButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CancelNewProjectButton.Location = new System.Drawing.Point(539, 425);
            this.CancelNewProjectButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelNewProjectButton.Name = "CancelNewProjectButton";
            this.CancelNewProjectButton.Size = new System.Drawing.Size(96, 44);
            this.CancelNewProjectButton.TabIndex = 19;
            this.CancelNewProjectButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.CancelNewProjectButton.Click += new System.EventHandler(this.CancelNewProjectButton_Click);
            // 
            // LeftMarginControl
            // 
            this.LeftMarginControl.BackColor = System.Drawing.Color.Transparent;
            this.LeftMarginControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMarginControl.Location = new System.Drawing.Point(0, 0);
            this.LeftMarginControl.Name = "LeftMarginControl";
            this.LeftMarginControl.Size = new System.Drawing.Size(16, 528);
            this.LeftMarginControl.TabIndex = 21;
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.TitleLabel.Location = new System.Drawing.Point(16, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(691, 47);
            this.TitleLabel.TabIndex = 22;
            this.TitleLabel.Text = "Create New Project";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StatusLabel.LabelColor = System.Drawing.Color.LemonChiffon;
            this.StatusLabel.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.LabelText = "Files Saved:";
            this.StatusLabel.LabelWidth = 120;
            this.StatusLabel.Location = new System.Drawing.Point(16, 500);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(691, 28);
            this.StatusLabel.TabIndex = 23;
            this.StatusLabel.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.StatusLabel.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // BlazorCheckBox
            // 
            this.BlazorCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.BlazorCheckBox.CheckBoxHorizontalOffSet = 0;
            this.BlazorCheckBox.CheckBoxVerticalOffSet = 4;
            this.BlazorCheckBox.CheckChangedListener = null;
            this.BlazorCheckBox.Checked = false;
            this.BlazorCheckBox.Editable = true;
            this.BlazorCheckBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BlazorCheckBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.BlazorCheckBox.LabelFont = null;
            this.BlazorCheckBox.LabelText = "Blazor:";
            this.BlazorCheckBox.LabelWidth = 140;
            this.BlazorCheckBox.Location = new System.Drawing.Point(57, 335);
            this.BlazorCheckBox.Name = "BlazorCheckBox";
            this.BlazorCheckBox.Size = new System.Drawing.Size(170, 28);
            this.BlazorCheckBox.TabIndex = 24;
            this.BlazorCheckBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // WinFormsCheckBox
            // 
            this.WinFormsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.WinFormsCheckBox.CheckBoxHorizontalOffSet = 0;
            this.WinFormsCheckBox.CheckBoxVerticalOffSet = 4;
            this.WinFormsCheckBox.CheckChangedListener = null;
            this.WinFormsCheckBox.Checked = false;
            this.WinFormsCheckBox.Editable = true;
            this.WinFormsCheckBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WinFormsCheckBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.WinFormsCheckBox.LabelFont = null;
            this.WinFormsCheckBox.LabelText = "WinForms:";
            this.WinFormsCheckBox.LabelWidth = 140;
            this.WinFormsCheckBox.Location = new System.Drawing.Point(57, 379);
            this.WinFormsCheckBox.Name = "WinFormsCheckBox";
            this.WinFormsCheckBox.Size = new System.Drawing.Size(170, 28);
            this.WinFormsCheckBox.TabIndex = 25;
            this.WinFormsCheckBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // CloseTimer
            // 
            this.CloseTimer.Interval = 3000;
            this.CloseTimer.Tick += new System.EventHandler(this.CloseTimer_Tick);
            // 
            // ProjectEditorControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.WinFormsCheckBox);
            this.Controls.Add(this.BlazorCheckBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.LeftMarginControl);
            this.Controls.Add(this.CancelNewProjectButton);
            this.Controls.Add(this.CreateProjectButton);
            this.Controls.Add(this.ProjectNameControl);
            this.Controls.Add(this.GlobalUsingsControl);
            this.Controls.Add(this.ProgramFileControl);
            this.Controls.Add(this.ProjectFileControl);
            this.Controls.Add(this.ResourcesFileControl);
            this.Controls.Add(this.MainFormControl);
            this.DoubleBuffered = true;
            this.Name = "ProjectEditorControl";
            this.Size = new System.Drawing.Size(707, 528);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelTextBoxControl ProjectNameControl;
        private LabelTextBoxBrowserControl GlobalUsingsControl;
        private LabelTextBoxBrowserControl ProgramFileControl;
        private LabelTextBoxBrowserControl ProjectFileControl;
        private LabelTextBoxBrowserControl ResourcesFileControl;
        private LabelTextBoxBrowserControl MainFormControl;
        private DataJuggler.Win.Controls.Button CreateProjectButton;
        private DataJuggler.Win.Controls.Button CancelNewProjectButton;
        private DataJuggler.Win.Controls.Objects.PanelExtender LeftMarginControl;
        private Label TitleLabel;
        private LabelLabelControl StatusLabel;
        private LabelCheckBoxControl BlazorCheckBox;
        private LabelCheckBoxControl WinFormsCheckBox;
        private System.Windows.Forms.Timer CloseTimer;
    }
}
