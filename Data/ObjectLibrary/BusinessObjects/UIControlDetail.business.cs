

#region using statements

using ObjectLibrary.Enumerations;
using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class UIControlDetail
    [Serializable]
    public partial class UIControlDetail
    {

        #region Private Variables
        #endregion

        #region Constructor
        public UIControlDetail()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public UIControlDetail Clone()
            {
                // Create New Object
                UIControlDetail newUIControlDetail = (UIControlDetail) this.MemberwiseClone();

                // Return Cloned Object
                return newUIControlDetail;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
