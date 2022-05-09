

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FetchAllUIControlTemplatesStoredProcedure
    /// <summary>
    /// This class is used to FetchAll 'UIControlTemplate' objects.
    /// </summary>
    public class FetchAllUIControlTemplatesStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FetchAllUIControlTemplatesStoredProcedure' object.
        /// </summary>
        public FetchAllUIControlTemplatesStoredProcedure()
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
                this.ProcedureName = "UIControlTemplate_FetchAll";

                // Set tableName
                this.TableName = "UIControlTemplate";
            }
            #endregion

        #endregion

        #region Properties

        #endregion

    }
    #endregion

}
