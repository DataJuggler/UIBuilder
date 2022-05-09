

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class UIField
    [Serializable]
    public partial class UIField
    {

        #region Private Variables
        #endregion

        #region Constructor
        public UIField()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public UIField Clone()
            {
                // Create New Object
                UIField newUIField = (UIField) this.MemberwiseClone();

                // Return Cloned Object
                return newUIField;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
