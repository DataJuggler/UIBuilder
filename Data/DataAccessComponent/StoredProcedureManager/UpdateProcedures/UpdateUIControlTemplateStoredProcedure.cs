

namespace DataAccessComponent.StoredProcedureManager.UpdateProcedures
{

    #region class UpdateUIControlTemplateStoredProcedure
    /// <summary>
    /// This class is used to Update a 'UIControlTemplate' object.
    /// </summary>
    public class UpdateUIControlTemplateStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UpdateUIControlTemplateStoredProcedure' object.
        /// </summary>
        public UpdateUIControlTemplateStoredProcedure()
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
                this.ProcedureName = "UIControlTemplate_Update";

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
