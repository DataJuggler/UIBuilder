

namespace DataAccessComponent.StoredProcedureManager.InsertProcedures
{

    #region class InsertUIControlDetailStoredProcedure
    /// <summary>
    /// This class is used to Insert a 'UIControlDetail' object.
    /// </summary>
    public class InsertUIControlDetailStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'InsertUIControlDetailStoredProcedure' object.
        /// </summary>
        public InsertUIControlDetailStoredProcedure()
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
                this.ProcedureName = "UIControlDetail_Insert";

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
