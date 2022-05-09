

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class UIProject
    [Serializable]
    public partial class UIProject
    {

        #region Private Variables
        #endregion

        #region Constructor
        public UIProject()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public UIProject Clone()
            {
                // Create New Object
                UIProject newUIProject = (UIProject) this.MemberwiseClone();

                // Return Cloned Object
                return newUIProject;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
