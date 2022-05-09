

#region using statements

using ApplicationLogicComponent.DataBridge;
using ApplicationLogicComponent.DataOperations;
using ApplicationLogicComponent.Logging;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;

#endregion


namespace ApplicationLogicComponent.Controllers
{

    #region class UIProjectController
    /// <summary>
    /// This class controls a(n) 'UIProject' object.
    /// </summary>
    public class UIProjectController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'UIProjectController' object.
        /// </summary>
        public UIProjectController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateUIProjectParameter
            /// <summary>
            /// This method creates the parameter for a 'UIProject' data operation.
            /// </summary>
            /// <param name='uiproject'>The 'UIProject' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateUIProjectParameter(UIProject uIProject)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = uIProject;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(UIProject tempUIProject)
            /// <summary>
            /// Deletes a 'UIProject' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'UIProject_Delete'.
            /// </summary>
            /// <param name='uiproject'>The 'UIProject' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(UIProject tempUIProject)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteUIProject";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempuIProject exists before attemptintg to delete
                    if(tempUIProject != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteUIProjectMethod = this.AppController.DataBridge.DataOperations.UIProjectMethods.DeleteUIProject;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateUIProjectParameter(tempUIProject);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteUIProjectMethod, parameters);

                        // If return object exists
                        if (returnObject != null)
                        {
                            // Test For True
                            if (returnObject.Boolean.Value == NullableBooleanEnum.True)
                            {
                                // Set Deleted To True
                                deleted = true;
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAll(UIProject tempUIProject)
            /// <summary>
            /// This method fetches a collection of 'UIProject' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'UIProject_FetchAll'.</summary>
            /// <param name='tempUIProject'>A temporary UIProject for passing values.</param>
            /// <returns>A collection of 'UIProject' objects.</returns>
            public List<UIProject> FetchAll(UIProject tempUIProject)
            {
                // Initial value
                List<UIProject> uIProjectList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.UIProjectMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateUIProjectParameter(tempUIProject);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<UIProject> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        uIProjectList = (List<UIProject>) returnObject.ObjectValue;
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return uIProjectList;
            }
            #endregion

            #region Find(UIProject tempUIProject)
            /// <summary>
            /// Finds a 'UIProject' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'UIProject_Find'</param>
            /// </summary>
            /// <param name='tempUIProject'>A temporary UIProject for passing values.</param>
            /// <returns>A 'UIProject' object if found else a null 'UIProject'.</returns>
            public UIProject Find(UIProject tempUIProject)
            {
                // Initial values
                UIProject uIProject = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempUIProject != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.UIProjectMethods.FindUIProject;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateUIProjectParameter(tempUIProject);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as UIProject != null))
                        {
                            // Get ReturnObject
                            uIProject = (UIProject) returnObject.ObjectValue;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return uIProject;
            }
            #endregion

            #region Insert(UIProject uIProject)
            /// <summary>
            /// Insert a 'UIProject' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'UIProject_Insert'.</param>
            /// </summary>
            /// <param name='uIProject'>The 'UIProject' object to insert.</param>
            /// <returns>The id (int) of the new  'UIProject' object that was inserted.</returns>
            public int Insert(UIProject uIProject)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If UIProjectexists
                    if(uIProject != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.UIProjectMethods.InsertUIProject;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateUIProjectParameter(uIProject);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, insertMethod , parameters);

                        // If return object exists
                        if (returnObject != null)
                        {
                            // Set return value
                            newIdentity = returnObject.IntegerValue;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region Save(ref UIProject uIProject)
            /// <summary>
            /// Saves a 'UIProject' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='uIProject'>The 'UIProject' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref UIProject uIProject)
            {
                // Initial value
                bool saved = false;

                // If the uIProject exists.
                if(uIProject != null)
                {
                    // Is this a new UIProject
                    if(uIProject.IsNew)
                    {
                        // Insert new UIProject
                        int newIdentity = this.Insert(uIProject);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            uIProject.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update UIProject
                        saved = this.Update(uIProject);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(UIProject uIProject)
            /// <summary>
            /// This method Updates a 'UIProject' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'UIProject_Update'.</param>
            /// </summary>
            /// <param name='uIProject'>The 'UIProject' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(UIProject uIProject)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(uIProject != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.UIProjectMethods.UpdateUIProject;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateUIProjectParameter(uIProject);
                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, updateMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.Boolean != null) && (returnObject.Boolean.Value == NullableBooleanEnum.True))
                        {
                            // Set saved to true
                            saved = true;
                        }
                    }
                }
                catch (Exception error)
                {
                    // If ErrorProcessor exists
                    if (this.ErrorProcessor != null)
                    {
                        // Log the current error
                        this.ErrorProcessor.LogError(methodName, objectName, error);
                    }
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ErrorProcessor
            public ErrorHandler ErrorProcessor
            {
                get { return errorProcessor; }
                set { errorProcessor = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
