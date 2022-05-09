

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindUIProjectStoredProcedure
    /// <summary>
    /// This class is used to Find a 'UIProject' object.
    /// </summary>
    public class FindUIProjectStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindUIProjectStoredProcedure' object.
        /// </summary>
        public FindUIProjectStoredProcedure()
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
                this.ProcedureName = "UIProject_Find";

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
