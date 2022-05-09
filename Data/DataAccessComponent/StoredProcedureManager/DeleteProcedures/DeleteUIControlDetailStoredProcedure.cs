

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteUIControlDetailStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'UIControlDetail' object.
    /// </summary>
    public class DeleteUIControlDetailStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteUIControlDetailStoredProcedure' object.
        /// </summary>
        public DeleteUIControlDetailStoredProcedure()
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
                this.ProcedureName = "UIControlDetail_Delete";

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
