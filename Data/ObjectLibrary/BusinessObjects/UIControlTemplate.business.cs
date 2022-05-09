

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class UIControlTemplate
    [Serializable]
    public partial class UIControlTemplate
    {

        #region Private Variables
        #endregion

        #region Constructor
        public UIControlTemplate()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public UIControlTemplate Clone()
            {
                // Create New Object
                UIControlTemplate newUIControlTemplate = (UIControlTemplate) this.MemberwiseClone();

                // Return Cloned Object
                return newUIControlTemplate;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
