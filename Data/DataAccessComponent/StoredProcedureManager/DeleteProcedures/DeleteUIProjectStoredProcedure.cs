

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteUIProjectStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'UIProject' object.
    /// </summary>
    public class DeleteUIProjectStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteUIProjectStoredProcedure' object.
        /// </summary>
        public DeleteUIProjectStoredProcedure()
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
                this.ProcedureName = "UIProject_Delete";

                // Set tableName
                this.TableName = "UIProject";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
