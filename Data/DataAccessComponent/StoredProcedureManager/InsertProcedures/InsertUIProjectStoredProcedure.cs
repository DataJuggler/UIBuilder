

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertUIProjectStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'UIProject' object.
    /// </summary>
    public class InsertUIProjectStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertUIProjectStoredProcedure' object.
        /// </summary>
        public InsertUIProjectStoredProcedure()
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
                this.ProcedureName = "UIProject_Insert";

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
