

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindUIControlDetailStoredProcedure
    /// <summary>
    /// This class is used to Find a 'UIControlDetail' object.
    /// </summary>
    public class FindUIControlDetailStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindUIControlDetailStoredProcedure' object.
        /// </summary>
        public FindUIControlDetailStoredProcedure()
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
                this.ProcedureName = "UIControlDetail_Find";

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
