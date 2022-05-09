

#region using statements


#endregion

namespace UIBuilder
{

    #region class ProjectEditorControl
    /// <summary>
    /// This class [Enter Class Description]
    /// </summary>
    public partial class ProjectEditorControl : UserControl, ITextChanged
    {
        
        #region Private Variables
        private UIProject project;
        private int savedCount;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a ProjectEditorControl
        /// </summary>
        public ProjectEditorControl()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

            #region CancelNewProjectButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CancelNewProjectButton' is clicked.
            /// </summary>
            private void CancelNewProjectButton_Click(object sender, EventArgs e)
            {
                
            }
            #endregion
            
            #region CloseTimer_Tick(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Close Timer _ Tick
            /// </summary>
            private void CloseTimer_Tick(object sender, EventArgs e)
            {
                // if the value for HasParentMainForm is true
                if (HasParentMainForm)
                {   
                    // refresh
                    ParentMainForm.ScreenMode = ScreenModeEnum.ViewProjectTemplates;
                }
            }
            #endregion
            
            #region CreateProjectButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CreateProjectButton' is clicked.
            /// </summary>
            private void CreateProjectButton_Click(object sender, EventArgs e)
            {  
                // get the fileName
                string fileName = MainFormControl.Text;
                string designerFileName = fileName.Replace(".cs", ".designer.cs");
                string resxFileName = fileName.Replace(".cs", ".resx");
                string resourceFileName = ResourcesFileControl.Text;
                string resoucesDesignerFile = resourceFileName.Replace(".resx", ".Designer.cs");
                string projectFile = ProjectFileControl.Text;
                string programFile = ProgramFileControl.Text;
                string globalUsingsFile = GlobalUsingsControl.Text;

                // Save the form
                UIControlTemplate template = SaveFile(fileName, true);

                // If the template object exists
                if (NullHelper.Exists(template))
                {
                    // Now save the Designer
                    UIControlTemplate designerTemplate = SaveFile(designerFileName, false);

                    // Save the resxFileName file
                    UIControlTemplate resxTemplate = SaveFile(resxFileName, false);

                    // Save the Resources files
                    UIControlTemplate resourcesTemplate = SaveFile(ResourcesFileControl.Text, false);

                    // Save the Resources files
                    UIControlTemplate resourcesDesignerTemplate = SaveFile(resoucesDesignerFile, false);

                    // Save the project
                    UIControlTemplate projectTemplate = SaveFile(projectFile, false);

                    // Save the program.cs file
                    UIControlTemplate programFileTemplate = SaveFile(programFile, false);

                    // Save the Global Usings
                    UIControlTemplate globalUsingsTemplate = SaveFile(globalUsingsFile, false);

                    // If the 'template' object and the 'designerTemplate' and the resxTemplate objects all exist.
                    if (NullHelper.Exists(designerTemplate, resxTemplate, resourcesTemplate, resourcesDesignerTemplate, projectTemplate, programFileTemplate, globalUsingsTemplate))
                    {
                        // Create a new instance of a 'Gateway' object.
                        Gateway gateway = new Gateway(Connection.Name);

                        // Save
                        resourcesTemplate.DesignerTemplateId = resourcesDesignerTemplate.Id;

                        // update the ResourcesDesigner file
                        bool saved = gateway.SaveUIControlTemplate(ref resourcesTemplate);

                        // Set the DesignerTemplate
                        template.DesignerTemplateId = designerTemplate.Id;
                        template.ResxTemplateId = resxTemplate.Id;
                        template.ResourcesTemplateId = resourcesTemplate.Id;
                        template.ProjectTemplateId = projectTemplate.Id;
                        template.ProgramFileTemplateId = programFileTemplate.Id;
                        template.GlobalUsingsTemplateId = globalUsingsTemplate.Id;
                        
                        // Update the template with the DesignerTemplateId
                        saved = gateway.SaveUIControlTemplate(ref template);

                        // if the value for saved is true
                        if (saved)
                        {
                            // increment the value
                            SavedCount++;

                            // Create a new instance of an 'UIProject' object.
                            UIProject project = new UIProject();

                            // Get the text
                            project.Name = ProjectNameControl.Text;

                            // set this template
                            project.UIControlTemplateId = template.Id;

                            // Set platform
                            project.IsWindowsForm = WinFormsCheckBox.Checked;                                                        
                            project.IsBlazor = BlazorCheckBox.Checked;

                            // now save the project
                            saved = gateway.SaveUIProject(ref project);

                            // if the value for saved is true
                            if (saved)
                            {   
                                // increment the value
                                SavedCount++;
                            }

                            // Display
                            StatusLabel.Text = String.Format("{0:n0}", SavedCount);

                            // Setup to close
                            CloseTimer.Enabled = true;
                        }
                        else
                        {
                            // get last exception
                            Exception error = gateway.GetLastException();

                            // If the error object exists
                            if (NullHelper.Exists(error))
                            {
                                // Something went wrong
                                MessageBox.Show("Template file could not be saved. Your connection string may not be set.", "Could Not Save");
                            }
                        }
                    }                
                }
                else
                {
                    // Something went wrong
                    MessageBox.Show("Template file could not be saved. Your connection string may not be set.", "Could Not Save");
                }            
            }
            #endregion
            
            #region OnTextChanged(Control sender, string text)
            /// <summary>
            /// event is fired when On Text Changed
            /// </summary>
            public void OnTextChanged(Control sender, string text)
            {
                // populating everything selected from the project
                string path = MainFormControl.Text;

                FileInfo fileInfo = new FileInfo(path);

                // set resourcesPath
                string resourcePath = Path.Combine(fileInfo.Directory.FullName, @"Properties\Resources.resx");

                // Set the resoucesPath
                ResourcesFileControl.Text = resourcePath;

                // set the projectFilePath
                string programFilePath = Path.Combine(fileInfo.Directory.FullName, @"Program.cs");

                // display
                ProgramFileControl.Text = programFilePath;

                 // set the globalUsingsPath
                string globalUsingsPath = Path.Combine(fileInfo.Directory.FullName, @"GlobalUsings.cs");

                // display
                GlobalUsingsControl.Text = globalUsingsPath;

                // now the project file

                // Get the project files recursively
                List<string> extensions = new List<string>();
                extensions.Add(".csproj");
                List<string> files = new List<string>();
                files = FileHelper.GetFilesRecursively(fileInfo.Directory.FullName, ref files, extensions);

                // if the file was found
                if (ListHelper.HasOneOrMoreItems(files))
                {
                    // take the first time
                    ProjectFileControl.Text = files[0];
                }
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
                // Set the Location
                MainFormControl.OnTextChangedListener = this;
                CreateProjectButton.Location = new Point(372, 425);
                CreateProjectButton.Visible = true;
                CreateProjectButton.Size = new Size(148, 44);
                CreateProjectButton.Font = new Font("Verdana", 12, FontStyle.Bold);
                CancelNewProjectButton.Location = new Point(539, 425);
                CancelNewProjectButton.Visible = true;
                CancelNewProjectButton.Size = new Size(96, 44);
                CancelNewProjectButton.Font = new Font("Verdana", 12, FontStyle.Bold);
                BackgroundImage = null;
                BackColor = Color.Transparent;
            }
            #endregion
            
            #region SaveFile(string fileName, bool resetSavedCount)
            /// <summary>
            /// Save a file
            /// </summary>
            public UIControlTemplate SaveFile(string fileName, bool resetSavedCount)
            {
                // initial value
                UIControlTemplate template = null;

                try
                {
                    // get the text of the files
                    string fileText = File.ReadAllText(fileName);
                
                    // locals
                    List<TextLine> textLines = null;
                    FileInfo fileInfo = null;
                    int lineNumber = 0;
                
                    // if the value for resetSavedCount is true
                    if (resetSavedCount)
                    {
                        // reset
                        SavedCount = 0;
                   }

                    // If the fileText string exists
                    if (TextHelper.Exists(fileText))
                    {
                        // get the textLines
                        textLines = TextHelper.GetTextLines(fileText);

                        // If the textLines collection exists and has one or more items
                        if (ListHelper.HasOneOrMoreItems(textLines))
                        {
                            // Create a new instance of an 'UIControlTemplate' object.
                            template = new UIControlTemplate();

                            // get the fileInfo object
                            fileInfo = new FileInfo(fileName);

                            // get the fileName
                            template.Name = fileInfo.Name;

                            // 1 Form for now, needs to be an enum
                            template.ControlType = 1;

                            // set properties
                            template.NugetPackage = "";
                            template.Version = "1.0";
                        
                            // Store the Path, to make it easy to deploy
                            template.Path = fileName;
                        
                            // zero for now
                            template.DesignerTemplateId = 0;

                            // Create a new instance of a 'Gateway' object.
                            Gateway gateway = new Gateway(Connection.Name);

                            // perform the save
                            bool saved = gateway.SaveUIControlTemplate(ref template);

                            // if saved
                            if (saved)
                            {
                                // Increment the value for savedCount
                                SavedCount++;

                                // Iterate the collection of TextLine objects
                                foreach (TextLine line in textLines)
                                {
                                    // Increment the value for lineNumber
                                    lineNumber++;

                                    // the detail must be saved next
                                    UIControlDetail detail = new UIControlDetail();

                                    // Set the Parent
                                    detail.UIControlId = template.Id;

                                    // set the lineNumber
                                    detail.LineNumber = lineNumber;

                                    // Set the text
                                    detail.LineText = line.Text;

                                    // Set the index
                                    detail.Indent = TextHelper.GetSpacesCount(line.Text);

                                    // Perform the Save
                                    saved = gateway.SaveUIControlDetail(ref detail);

                                    // if the value for saved is true
                                    if (saved)
                                    {
                                        // Increment the value for savedCount
                                        SavedCount++;

                                        // refresh every 100 records
                                        if (savedCount % 100 == 0)
                                        {
                                            // Display
                                            StatusLabel.Text = SavedCount.ToString();
                                        }
                                    }
                                }
                            }
                            else
                            {  
                                // get last exception
                                Exception error = gateway.GetLastException();

                                // If the error object exists
                                if (NullHelper.Exists(error))
                                {
                                    // for debugging only
                                    string message = error.ToString();
                                }                    
                            }

                            // Display
                            StatusLabel.Text = String.Format("{0:n0}", SavedCount);
                        }
                    }
                }
                catch (Exception error)
                {
                    // for debugging only
                    DebugHelper.WriteDebugError("SaveFile", "ProjectEditorControl.cs", error);
                }

                // return value
                return template;
            }
            #endregion

        #endregion

        #region Properties

            #region HasParentMainForm
            /// <summary>
            /// This property returns true if this object has a 'ParentMainForm'.
            /// </summary>
            public bool HasParentMainForm
            {
                get
                {
                    // initial value
                    bool hasParentMainForm = (this.ParentMainForm != null);
                    
                    // return value
                    return hasParentMainForm;
                }
            }
            #endregion
            
            #region ParentMainForm
            /// <summary>
            /// This property gets or sets the value for 'ParentMainForm'.
            /// </summary>
            public MainForm ParentMainForm
            {
                get 
                {
                    // initial value
                    MainForm parentMainForm = ParentForm as MainForm;

                    // return value
                    return parentMainForm;
                }
            }
            #endregion
            
            #region Project
            /// <summary>
            /// This property gets or sets the value for 'Project'.
            /// </summary>
            public UIProject Project
            {
                get { return project; }
                set { project = value; }
            }
            #endregion

            #region SavedCount
            /// <summary>
            /// This property gets or sets the value for 'SavedCount'.
            /// </summary>
            public int SavedCount
            {
                get { return savedCount; }
                set { savedCount = value; }
            }
        #endregion

        #endregion
    }
    #endregion

}
