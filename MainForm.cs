

#region using statements


#endregion

namespace UIBuilder
{

    #region class MainForm : Form, ITextChanged
    /// <summary>
    /// This class is the main form for this app.
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables        
        private const string NewProjectCLI = "dotnet new winforms --framework \"net6.0\" -o [ProjectFolder]";
        private ScreenModeEnum screenMode;        
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion
        
        #region Events
            
            #region Button_Enter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Enter
            /// </summary>
            private void Button_Enter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_Leave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Leave
            /// </summary>
            private void Button_Leave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;
            }
            #endregion
            
            #region CreateProjectButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CreateProjectButton' is clicked.
            /// </summary>
            private void CreateProjectButton_Click(object sender, EventArgs e)
            {
                //// if the SelectedProject exists
                //if (ProjectFolderControl.HasText)
                //{
                //    // Test if there are any files in this directory
                //    List<string> files = FileHelper.GetFiles(ProjectFolderControl.Text, "", false);

                //    // If the files collection exists and has one or more items
                //    if (ListHelper.HasOneOrMoreItems(files))
                //    {
                //        // show the user a message
                //        MessageBox.Show("The Project Folder is not empty. You must select an empty folder for a Dot Net Core data-tier.", "Project Folder Is Not Empty");
                //    }
                //    else
                //    {
                //        // get the cli
                //        string cli = NewProjectCLI.Replace("[ProjectFolder]", ProjectFolderControl.Text);

                //        // Create a Process to launch a command window (hidden) to create the item templates
                //        Process process = new Process();
                //        ProcessStartInfo startInfo = new ProcessStartInfo();
                //        startInfo.WindowStyle = ProcessWindowStyle.Hidden;                        
                //        startInfo.FileName = "cmd.exe";
                //        startInfo.WorkingDirectory = ProjectFolderControl.SelectedPath;
                
                //        // if Net6
                //        startInfo.Arguments = "/C " + cli;                

                //        process.StartInfo = startInfo;
                //        process.Start();
                //    }
                //}
            }
            #endregion
            
            #region CreateProjectTemplateButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CreateProjectTemplateButton' is clicked.
            /// </summary>
            private void CreateProjectTemplateButton_Click(object sender, EventArgs e)
            {
                // change
                ScreenMode = ScreenModeEnum.CreateNewProjectTemplate;
            }
            #endregion
            
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            ///  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Perform initializations for this object
                ProjectEditorControl.Init();

                // Determine which controls are enabled and visible
                UIControl();
            }
            #endregion
            
            #region UIControl()
            /// <summary>
            /// UI Control
            /// </summary>
            public void UIControl()
            {
                // default
                ProjectEditorControl.Visible = false;

                // Determine the action by the ScreenMode
                switch(ScreenMode)
                {
                    case ScreenModeEnum.CreateNewProjectTemplate:

                        // show
                        ProjectEditorControl.Visible = true;

                        // required
                        break;
                }
            }
            #endregion
            
        #endregion

        #region Properties

            #region CreateParams
            /// <summary>
            /// This property here is what did the trick to reduce the flickering.
            /// I also needed to make all of the controls Double Buffered, but
            /// this was the final touch. It is a little slow when you switch tabs
            /// but that is because the repainting is finishing before control is
            /// returned.
            /// </summary>
            protected override CreateParams CreateParams
            {
                get
                {
                    // initial value
                    CreateParams cp = base.CreateParams;

                    // Apparently this interrupts Paint to finish before showing
                    cp.ExStyle |= 0x02000000;

                    // return value
                    return cp;
                }
            }
            #endregion
            
            #region ScreenMode
            /// <summary>
            /// This property gets or sets the value for 'ScreenMode'.
            /// </summary>
            public ScreenModeEnum ScreenMode
            {
                get { return screenMode; }
                set 
                {
                    // set the value
                    screenMode = value;

                    // Determine which controls are enabled and visible
                    UIControl();
                }
            }
        #endregion

        #endregion
    }
    #endregion

}
