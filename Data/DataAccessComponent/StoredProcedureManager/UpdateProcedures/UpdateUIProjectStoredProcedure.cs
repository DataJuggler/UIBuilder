

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateUIProjectStoredProcedure
    /// <summary>
    /// This class is used to Update a 'UIProject' object.
    /// </summary>
    public class UpdateUIProjectStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateUIProjectStoredProcedure' object.
        /// </summary>
        public UpdateUIProjectStoredProcedure()
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
                this.ProcedureName = "UIProject_Update";

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
