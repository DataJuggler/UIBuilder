

#region using statements


#endregion

namespace UIBuilder
{

    #region class MainForm
    /// <summary>
    /// This is the designer for the MainSplit control
    /// </summary>
    partial class MainForm
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
            /// <summary>
            ///  Clean up any resources being used.
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
            #endregion
            
            #region InitializeComponent()
            /// <summary>
            ///  Required method for Designer support - do not modify
            ///  the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LeftMarginPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.LeftPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.CreateProjectTemplateLabel = new System.Windows.Forms.Label();
            this.CreateProjectTemplateButton = new System.Windows.Forms.PictureBox();
            this.RightMarginPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.MarginPanel1 = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.ProjectEditorControl = new UIBuilder.ProjectEditorControl();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreateProjectTemplateButton)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftMarginPanel
            // 
            this.LeftMarginPanel.BackColor = System.Drawing.Color.Transparent;
            this.LeftMarginPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMarginPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftMarginPanel.Name = "LeftMarginPanel";
            this.LeftMarginPanel.Size = new System.Drawing.Size(16, 806);
            this.LeftMarginPanel.TabIndex = 0;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.Transparent;
            this.LeftPanel.Controls.Add(this.CreateProjectTemplateLabel);
            this.LeftPanel.Controls.Add(this.CreateProjectTemplateButton);
            this.LeftPanel.Controls.Add(this.RightMarginPanel);
            this.LeftPanel.Controls.Add(this.MarginPanel1);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(16, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(80, 806);
            this.LeftPanel.TabIndex = 1;
            // 
            // CreateProjectTemplateLabel
            // 
            this.CreateProjectTemplateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateProjectTemplateLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateProjectTemplateLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CreateProjectTemplateLabel.Location = new System.Drawing.Point(0, 80);
            this.CreateProjectTemplateLabel.Name = "CreateProjectTemplateLabel";
            this.CreateProjectTemplateLabel.Size = new System.Drawing.Size(64, 18);
            this.CreateProjectTemplateLabel.TabIndex = 6;
            this.CreateProjectTemplateLabel.Text = "New";
            this.CreateProjectTemplateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateProjectTemplateLabel.Click += new System.EventHandler(this.CreateProjectTemplateButton_Click);
            this.CreateProjectTemplateLabel.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.CreateProjectTemplateLabel.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // CreateProjectTemplateButton
            // 
            this.CreateProjectTemplateButton.BackgroundImage = global::UIBuilder.Properties.Resources.NewProject;
            this.CreateProjectTemplateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateProjectTemplateButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateProjectTemplateButton.Location = new System.Drawing.Point(0, 16);
            this.CreateProjectTemplateButton.MaximumSize = new System.Drawing.Size(64, 64);
            this.CreateProjectTemplateButton.Name = "CreateProjectTemplateButton";
            this.CreateProjectTemplateButton.Size = new System.Drawing.Size(64, 64);
            this.CreateProjectTemplateButton.TabIndex = 5;
            this.CreateProjectTemplateButton.TabStop = false;
            this.CreateProjectTemplateButton.Click += new System.EventHandler(this.CreateProjectTemplateButton_Click);
            this.CreateProjectTemplateButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.CreateProjectTemplateButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // RightMarginPanel
            // 
            this.RightMarginPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightMarginPanel.Location = new System.Drawing.Point(64, 16);
            this.RightMarginPanel.Name = "RightMarginPanel";
            this.RightMarginPanel.Size = new System.Drawing.Size(16, 790);
            this.RightMarginPanel.TabIndex = 3;
            // 
            // MarginPanel1
            // 
            this.MarginPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.MarginPanel1.Location = new System.Drawing.Point(0, 0);
            this.MarginPanel1.Name = "MarginPanel1";
            this.MarginPanel1.Size = new System.Drawing.Size(80, 16);
            this.MarginPanel1.TabIndex = 0;
            // 
            // ProjectEditorControl
            // 
            this.ProjectEditorControl.BackColor = System.Drawing.Color.Transparent;
            this.ProjectEditorControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProjectEditorControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjectEditorControl.Location = new System.Drawing.Point(96, 0);
            this.ProjectEditorControl.Name = "ProjectEditorControl";
            this.ProjectEditorControl.Project = null;
            this.ProjectEditorControl.SavedCount = 0;
            this.ProjectEditorControl.Size = new System.Drawing.Size(1348, 528);
            this.ProjectEditorControl.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::UIBuilder.Properties.Resources.BlackImage;
            this.ClientSize = new System.Drawing.Size(1444, 806);
            this.Controls.Add(this.ProjectEditorControl);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.LeftMarginPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "DataTier.Net UI Builder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CreateProjectTemplateButton)).EndInit();
            this.ResumeLayout(false);

            }
        #endregion

        #endregion

        private DataJuggler.Win.Controls.Objects.PanelExtender LeftMarginPanel;
        private DataJuggler.Win.Controls.Objects.PanelExtender LeftPanel;
        private Label CreateProjectTemplateLabel;
        private PictureBox CreateProjectTemplateButton;
        private DataJuggler.Win.Controls.Objects.PanelExtender RightMarginPanel;
        private DataJuggler.Win.Controls.Objects.PanelExtender MarginPanel1;
        private ProjectEditorControl ProjectEditorControl;
    }
    #endregion

}
