

namespace DataAccessComponent.StoredProcedureManager.FetchProcedures
{

    #region class FindUIControlTemplateStoredProcedure
    /// <summary>
    /// This class is used to Find a 'UIControlTemplate' object.
    /// </summary>
    public class FindUIControlTemplateStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FindUIControlTemplateStoredProcedure' object.
        /// </summary>
        public FindUIControlTemplateStoredProcedure()
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
                this.ProcedureName = "UIControlTemplate_Find";

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
