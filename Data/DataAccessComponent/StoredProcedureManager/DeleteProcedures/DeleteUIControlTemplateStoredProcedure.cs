

namespace DataAccessComponent.StoredProcedureManager.DeleteProcedures
{

    #region class DeleteUIControlTemplateStoredProcedure
    /// <summary>
    /// This class is used to Delete a 'UIControlTemplate' object.
    /// </summary>
    public class DeleteUIControlTemplateStoredProcedure : StoredProcedure
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'DeleteUIControlTemplateStoredProcedure' object.
        /// </summary>
        public DeleteUIControlTemplateStoredProcedure()
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
                this.ProcedureName = "UIControlTemplate_Delete";

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
