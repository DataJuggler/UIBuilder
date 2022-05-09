

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class UIControlDetail
    public partial class UIControlDetail
    {

        #region Private Variables
        private int id;
        private int indent;
        private int lineNumber;
        private string lineText;
        private int uIControlId;
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

            #region int Indent
            public int Indent
            {
                get
                {
                    return indent;
                }
                set
                {
                    indent = value;
                }
            }
            #endregion

            #region int LineNumber
            public int LineNumber
            {
                get
                {
                    return lineNumber;
                }
                set
                {
                    lineNumber = value;
                }
            }
            #endregion

            #region string LineText
            public string LineText
            {
                get
                {
                    return lineText;
                }
                set
                {
                    lineText = value;
                }
            }
            #endregion

            #region int UIControlId
            public int UIControlId
            {
                get
                {
                    return uIControlId;
                }
                set
                {
                    uIControlId = value;
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
