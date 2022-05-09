

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateUIControlDetailStoredProcedure
    /// <summary>
    /// This class is used to Update a 'UIControlDetail' object.
    /// </summary>
    public class UpdateUIControlDetailStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateUIControlDetailStoredProcedure' object.
        /// </summary>
        public UpdateUIControlDetailStoredProcedure()
        {
            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// Set Procedure Properties
            /// </summary>
            private void Init()
            {
                // Set Properties For This Proc

                // Set ProcedureName
                this.ProcedureName = "UIControlDetail_Update";

                // Set tableName
                this.TableName = "UIControlDetail";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
