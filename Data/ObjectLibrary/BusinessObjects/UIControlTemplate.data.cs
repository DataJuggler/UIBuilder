

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class UIControlTemplate
    public partial class UIControlTemplate
    {

        #region Private Variables
        private int controlType;
        private int designerTemplateId;
        private int globalUsingsTemplateId;
        private int id;
        private string name;
        private string nugetPackage;
        private string path;
        private int programFileTemplateId;
        private int projectTemplateId;
        private int resourcesTemplateId;
        private int resxTemplateId;
        private string version;
        #endregion

        #region Methods

            #region UpdateIdentity(int id)
            // <summary>
            // This method provides a 'setter'
            // functionality for the Identity field.
            // </summary>
            public void UpdateIdentity(int id)
            {
                // Update The Identity field
                this.id = id;
            }
            #endregion

        #endregion

        #region Properties

            #region int ControlType
            public int ControlType
            {
                get
                {
                    return controlType;
                }
                set
                {
                    controlType = value;
                }
            }
            #endregion

            #region int DesignerTemplateId
            public int DesignerTemplateId
            {
                get
                {
                    return designerTemplateId;
                }
                set
                {
                    designerTemplateId = value;
                }
            }
            #endregion

            #region int GlobalUsingsTemplateId
            public int GlobalUsingsTemplateId
            {
                get
                {
                    return globalUsingsTemplateId;
                }
                set
                {
                    globalUsingsTemplateId = value;
                }
            }
            #endregion

            #region int Id
            public int Id
            {
                get
                {
                    return id;
                }
            }
            #endregion

            #region string Name
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            #endregion

            #region string NugetPackage
            public string NugetPackage
            {
                get
                {
                    return nugetPackage;
                }
                set
                {
                    nugetPackage = value;
                }
            }
            #endregion

            #region string Path
            public string Path
            {
                get
                {
                    return path;
                }
                set
                {
                    path = value;
                }
            }
            #endregion

            #region int ProgramFileTemplateId
            public int ProgramFileTemplateId
            {
                get
                {
                    return programFileTemplateId;
                }
                set
                {
                    programFileTemplateId = value;
                }
            }
            #endregion

            #region int ProjectTemplateId
            public int ProjectTemplateId
            {
                get
                {
                    return projectTemplateId;
                }
                set
                {
                    projectTemplateId = value;
                }
            }
            #endregion

            #region int ResourcesTemplateId
            public int ResourcesTemplateId
            {
                get
                {
                    return resourcesTemplateId;
                }
                set
                {
                    resourcesTemplateId = value;
                }
            }
            #endregion

            #region int ResxTemplateId
            public int ResxTemplateId
            {
                get
                {
                    return resxTemplateId;
                }
                set
                {
                    resxTemplateId = value;
                }
            }
            #endregion

            #region string Version
            public string Version
            {
                get
                {
                    return version;
                }
                set
                {
                    version = value;
                }
            }
            #endregion

            #region bool IsNew
            public bool IsNew
            {
                get
                {
                    // Initial Value
                    bool isNew = (this.Id < 1);

                    // return value
                    return isNew;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
