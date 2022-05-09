

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllUIControlDetailsStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'UIControlDetail' objects.
    /// </summary>
    public class FetchAllUIControlDetailsStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllUIControlDetailsStoredProcedure' object.
        /// </summary>
        public FetchAllUIControlDetailsStoredProcedure()
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
                this.ProcedureName = "UIControlDetail_FetchAll";

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
