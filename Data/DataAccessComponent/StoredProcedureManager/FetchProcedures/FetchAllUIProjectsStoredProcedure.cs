

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllUIProjectsStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'UIProject' objects.
    /// </summary>
    public class FetchAllUIProjectsStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllUIProjectsStoredProcedure' object.
        /// </summary>
        public FetchAllUIProjectsStoredProcedure()
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
                this.ProcedureName = "UIProject_FetchAll";

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
