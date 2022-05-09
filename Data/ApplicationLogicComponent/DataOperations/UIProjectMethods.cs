

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

    #region class UIProjectMethods
    /// <summary>
    /// This class contains methods for modifying a 'UIProject' object.
    /// </summary>
    public class UIProjectMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'UIProjectMethods' object.
        /// </summary>
        public UIProjectMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteUIProject(UIProject)
            /// <summary>
            /// This method deletes a 'UIProject' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'UIProject' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteUIProject(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteUIProjectStoredProcedure deleteUIProjectProc = null;

                    // verify the first parameters is a(n) 'UIProject'.
                    if (parameters[0].ObjectValue as UIProject != null)
                    {
                        // Create UIProject
                        UIProject uIProject = (UIProject) parameters[0].ObjectValue;

                        // verify uIProject exists
                        if(uIProject != null)
                        {
                            // Now create deleteUIProjectProc from UIProjectWriter
                            // The DataWriter converts the 'UIProject'
                            // to the SqlParameter[] array needed to delete a 'UIProject'.
                            deleteUIProjectProc = UIProjectWriter.CreateDeleteUIProjectStoredProcedure(uIProject);
                        }
                    }

                    // Verify deleteUIProjectProc exists
                    if(deleteUIProjectProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.UIProjectManager.DeleteUIProject(deleteUIProjectProc, dataConnector);

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
            /// This method fetches all 'UIProject' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'UIProject' to delete.
            /// <returns>A PolymorphicObject object with all  'UIProjects' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<UIProject> uIProjectListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllUIProjectsStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get UIProjectParameter
                    // Declare Parameter
                    UIProject paramUIProject = null;

                    // verify the first parameters is a(n) 'UIProject'.
                    if (parameters[0].ObjectValue as UIProject != null)
                    {
                        // Get UIProjectParameter
                        paramUIProject = (UIProject) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllUIProjectsProc from UIProjectWriter
                    fetchAllProc = UIProjectWriter.CreateFetchAllUIProjectsStoredProcedure(paramUIProject);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    uIProjectListCollection = this.DataManager.UIProjectManager.FetchAllUIProjects(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(uIProjectListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = uIProjectListCollection;
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

            #region FindUIProject(UIProject)
            /// <summary>
            /// This method finds a 'UIProject' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'UIProject' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindUIProject(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                UIProject uIProject = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindUIProjectStoredProcedure findUIProjectProc = null;

                    // verify the first parameters is a 'UIProject'.
                    if (parameters[0].ObjectValue as UIProject != null)
                    {
                        // Get UIProjectParameter
                        UIProject paramUIProject = (UIProject) parameters[0].ObjectValue;

                        // verify paramUIProject exists
                        if(paramUIProject != null)
                        {
                            // Now create findUIProjectProc from UIProjectWriter
                            // The DataWriter converts the 'UIProject'
                            // to the SqlParameter[] array needed to find a 'UIProject'.
                            findUIProjectProc = UIProjectWriter.CreateFindUIProjectStoredProcedure(paramUIProject);
                        }

                        // Verify findUIProjectProc exists
                        if(findUIProjectProc != null)
                        {
                            // Execute Find Stored Procedure
                            uIProject = this.DataManager.UIProjectManager.FindUIProject(findUIProjectProc, dataConnector);

                            // if dataObject exists
                            if(uIProject != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = uIProject;
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

            #region InsertUIProject (UIProject)
            /// <summary>
            /// This method inserts a 'UIProject' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'UIProject' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertUIProject(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                UIProject uIProject = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertUIProjectStoredProcedure insertUIProjectProc = null;

                    // verify the first parameters is a(n) 'UIProject'.
                    if (parameters[0].ObjectValue as UIProject != null)
                    {
                        // Create UIProject Parameter
                        uIProject = (UIProject) parameters[0].ObjectValue;

                        // verify uIProject exists
                        if(uIProject != null)
                        {
                            // Now create insertUIProjectProc from UIProjectWriter
                            // The DataWriter converts the 'UIProject'
                            // to the SqlParameter[] array needed to insert a 'UIProject'.
                            insertUIProjectProc = UIProjectWriter.CreateInsertUIProjectStoredProcedure(uIProject);
                        }

                        // Verify insertUIProjectProc exists
                        if(insertUIProjectProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.UIProjectManager.InsertUIProject(insertUIProjectProc, dataConnector);
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

            #region UpdateUIProject (UIProject)
            /// <summary>
            /// This method updates a 'UIProject' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'UIProject' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateUIProject(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                UIProject uIProject = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateUIProjectStoredProcedure updateUIProjectProc = null;

                    // verify the first parameters is a(n) 'UIProject'.
                    if (parameters[0].ObjectValue as UIProject != null)
                    {
                        // Create UIProject Parameter
                        uIProject = (UIProject) parameters[0].ObjectValue;

                        // verify uIProject exists
                        if(uIProject != null)
                        {
                            // Now create updateUIProjectProc from UIProjectWriter
                            // The DataWriter converts the 'UIProject'
                            // to the SqlParameter[] array needed to update a 'UIProject'.
                            updateUIProjectProc = UIProjectWriter.CreateUpdateUIProjectStoredProcedure(uIProject);
                        }

                        // Verify updateUIProjectProc exists
                        if(updateUIProjectProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.UIProjectManager.UpdateUIProject(updateUIProjectProc, dataConnector);

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
