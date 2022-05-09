

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class UIProject
    public partial class UIProject
    {

        #region Private Variables
        private int id;
        private bool isBlazor;
        private bool isWindowsForm;
        private string name;
        private int uIControlTemplateId;
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

            #region int Id
            public int Id
            {
                get
                {
                    return id;
                }
            }
            #endregion

            #region bool IsBlazor
            public bool IsBlazor
            {
                get
                {
                    return isBlazor;
                }
                set
                {
                    isBlazor = value;
                }
            }
            #endregion

            #region bool IsWindowsForm
            public bool IsWindowsForm
            {
                get
                {
                    return isWindowsForm;
                }
                set
                {
                    isWindowsForm = value;
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

            #region int UIControlTemplateId
            public int UIControlTemplateId
            {
                get
                {
                    return uIControlTemplateId;
                }
                set
                {
                    uIControlTemplateId = value;
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
