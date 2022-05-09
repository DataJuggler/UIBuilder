

#region using statements

using ApplicationLogicComponent.DataBridge;
using DataAccessComponent.DataManager;
using DataAccessComponent.DataManager.Writers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.DataOperations
{

    #region class UIControlTemplateMethods
    /// <summary>
    /// This class contains methods for modifying a 'UIControlTemplate' object.
    /// </summary>
    public class UIControlTemplateMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'UIControlTemplateMethods' object.
        /// </summary>
        public UIControlTemplateMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteUIControlTemplate(UIControlTemplate)
            /// <summary>
            /// This method deletes a 'UIControlTemplate' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'UIControlTemplate' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteUIControlTemplate(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteUIControlTemplateStoredProcedure deleteUIControlTemplateProc = null;

                    // verify the first parameters is a(n) 'UIControlTemplate'.
                    if (parameters[0].ObjectValue as UIControlTemplate != null)
                    {
                        // Create UIControlTemplate
                        UIControlTemplate uIControlTemplate = (UIControlTemplate) parameters[0].ObjectValue;

                        // verify uIControlTemplate exists
                        if(uIControlTemplate != null)
                        {
                            // Now create deleteUIControlTemplateProc from UIControlTemplateWriter
                            // The DataWriter converts the 'UIControlTemplate'
                            // to the SqlParameter[] array needed to delete a 'UIControlTemplate'.
                            deleteUIControlTemplateProc = UIControlTemplateWriter.CreateDeleteUIControlTemplateStoredProcedure(uIControlTemplate);
                        }
                    }

                    // Verify deleteUIControlTemplateProc exists
                    if(deleteUIControlTemplateProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.UIControlTemplateManager.DeleteUIControlTemplate(deleteUIControlTemplateProc, dataConnector);

                        // Create returnObject.Boolean
                        returnObject.Boolean = new NullableBoolean();

                        // If delete was successful
                        if(deleted)
                        {
                            // Set returnObject.Boolean.Value to true
                            returnObject.Boolean.Value = NullableBooleanEnum.True;
                        }
                        else
                        {
                            // Set returnObject.Boolean.Value to false
                            returnObject.Boolean.Value = NullableBooleanEnum.False;
                        }
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

            #region FetchAll()
            /// <summary>
            /// This method fetches all 'UIControlTemplate' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'UIControlTemplate' to delete.
            /// <returns>A PolymorphicObject object with all  'UIControlTemplates' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<UIControlTemplate> uIControlTemplateListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllUIControlTemplatesStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get UIControlTemplateParameter
                    // Declare Parameter
                    UIControlTemplate paramUIControlTemplate = null;

                    // verify the first parameters is a(n) 'UIControlTemplate'.
                    if (parameters[0].ObjectValue as UIControlTemplate != null)
                    {
                        // Get UIControlTemplateParameter
                        paramUIControlTemplate = (UIControlTemplate) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllUIControlTemplatesProc from UIControlTemplateWriter
                    fetchAllProc = UIControlTemplateWriter.CreateFetchAllUIControlTemplatesStoredProcedure(paramUIControlTemplate);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    uIControlTemplateListCollection = this.DataManager.UIControlTemplateManager.FetchAllUIControlTemplates(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(uIControlTemplateListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = uIControlTemplateListCollection;
                    }
                }
                else
                {
                    // Raise Error Data Connection Not Available
                    throw new Exception("The database connection is not available.");
                }

                // return value
                return returnObject;
            }
            #endregion

            #region FindUIControlTemplate(UIControlTemplate)
            /// <summary>
            /// This method finds a 'UIControlTemplate' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'UIControlTemplate' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindUIControlTemplate(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                UIControlTemplate uIControlTemplate = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindUIControlTemplateStoredProcedure findUIControlTemplateProc = null;

                    // verify the first parameters is a 'UIControlTemplate'.
                    if (parameters[0].ObjectValue as UIControlTemplate != null)
                    {
                        // Get UIControlTemplateParameter
                        UIControlTemplate paramUIControlTemplate = (UIControlTemplate) parameters[0].ObjectValue;

                        // verify paramUIControlTemplate exists
                        if(paramUIControlTemplate != null)
                        {
                            // Now create findUIControlTemplateProc from UIControlTemplateWriter
                            // The DataWriter converts the 'UIControlTemplate'
                            // to the SqlParameter[] array needed to find a 'UIControlTemplate'.
                            findUIControlTemplateProc = UIControlTemplateWriter.CreateFindUIControlTemplateStoredProcedure(paramUIControlTemplate);
                        }

                        // Verify findUIControlTemplateProc exists
                        if(findUIControlTemplateProc != null)
                        {
                            // Execute Find Stored Procedure
                            uIControlTemplate = this.DataManager.UIControlTemplateManager.FindUIControlTemplate(findUIControlTemplateProc, dataConnector);

                            // if dataObject exists
                            if(uIControlTemplate != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = uIControlTemplate;
                            }
                        }
                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region InsertUIControlTemplate (UIControlTemplate)
            /// <summary>
            /// This method inserts a 'UIControlTemplate' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'UIControlTemplate' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertUIControlTemplate(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                UIControlTemplate uIControlTemplate = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertUIControlTemplateStoredProcedure insertUIControlTemplateProc = null;

                    // verify the first parameters is a(n) 'UIControlTemplate'.
                    if (parameters[0].ObjectValue as UIControlTemplate != null)
                    {
                        // Create UIControlTemplate Parameter
                        uIControlTemplate = (UIControlTemplate) parameters[0].ObjectValue;

                        // verify uIControlTemplate exists
                        if(uIControlTemplate != null)
                        {
                            // Now create insertUIControlTemplateProc from UIControlTemplateWriter
                            // The DataWriter converts the 'UIControlTemplate'
                            // to the SqlParameter[] array needed to insert a 'UIControlTemplate'.
                            insertUIControlTemplateProc = UIControlTemplateWriter.CreateInsertUIControlTemplateStoredProcedure(uIControlTemplate);
                        }

                        // Verify insertUIControlTemplateProc exists
                        if(insertUIControlTemplateProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.UIControlTemplateManager.InsertUIControlTemplate(insertUIControlTemplateProc, dataConnector);
                        }

                    }
                    else
                    {
                        // Raise Error Data Connection Not Available
                        throw new Exception("The database connection is not available.");
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

            #region UpdateUIControlTemplate (UIControlTemplate)
            /// <summary>
            /// This method updates a 'UIControlTemplate' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'UIControlTemplate' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateUIControlTemplate(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                UIControlTemplate uIControlTemplate = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateUIControlTemplateStoredProcedure updateUIControlTemplateProc = null;

                    // verify the first parameters is a(n) 'UIControlTemplate'.
                    if (parameters[0].ObjectValue as UIControlTemplate != null)
                    {
                        // Create UIControlTemplate Parameter
                        uIControlTemplate = (UIControlTemplate) parameters[0].ObjectValue;

                        // verify uIControlTemplate exists
                        if(uIControlTemplate != null)
                        {
                            // Now create updateUIControlTemplateProc from UIControlTemplateWriter
                            // The DataWriter converts the 'UIControlTemplate'
                            // to the SqlParameter[] array needed to update a 'UIControlTemplate'.
                            updateUIControlTemplateProc = UIControlTemplateWriter.CreateUpdateUIControlTemplateStoredProcedure(uIControlTemplate);
                        }

                        // Verify updateUIControlTemplateProc exists
                        if(updateUIControlTemplateProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.UIControlTemplateManager.UpdateUIControlTemplate(updateUIControlTemplateProc, dataConnector);

                            // Create returnObject.Boolean
                            returnObject.Boolean = new NullableBoolean();

                            // If save was successful
                            if(saved)
                            {
                                // Set returnObject.Boolean.Value to true
                                returnObject.Boolean.Value = NullableBooleanEnum.True;
                            }
                            else
                            {
                                // Set returnObject.Boolean.Value to false
                                returnObject.Boolean.Value = NullableBooleanEnum.False;
                            }
                        }
                        else
                        {
                            // Raise Error Data Connection Not Available
                            throw new Exception("The database connection is not available.");
                        }
                    }
                }

                // return value
                return returnObject;
            }
            #endregion

        #endregion

        #region Properties

            #region DataManager 
            public DataManager DataManager 
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
