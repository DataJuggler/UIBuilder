

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

    #region class UIControlTemplateController
    /// <summary>
    /// This class controls a(n) 'UIControlTemplate' object.
    /// </summary>
    public class UIControlTemplateController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'UIControlTemplateController' object.
        /// </summary>
        public UIControlTemplateController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateUIControlTemplateParameter
            /// <summary>
            /// This method creates the parameter for a 'UIControlTemplate' data operation.
            /// </summary>
            /// <param name='uicontroltemplate'>The 'UIControlTemplate' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateUIControlTemplateParameter(UIControlTemplate uIControlTemplate)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = uIControlTemplate;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(UIControlTemplate tempUIControlTemplate)
            /// <summary>
            /// Deletes a 'UIControlTemplate' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'UIControlTemplate_Delete'.
            /// </summary>
            /// <param name='uicontroltemplate'>The 'UIControlTemplate' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(UIControlTemplate tempUIControlTemplate)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteUIControlTemplate";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempuIControlTemplate exists before attemptintg to delete
                    if(tempUIControlTemplate != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteUIControlTemplateMethod = this.AppController.DataBridge.DataOperations.UIControlTemplateMethods.DeleteUIControlTemplate;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateUIControlTemplateParameter(tempUIControlTemplate);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteUIControlTemplateMethod, parameters);

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

            #region FetchAll(UIControlTemplate tempUIControlTemplate)
            /// <summary>
            /// This method fetches a collection of 'UIControlTemplate' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'UIControlTemplate_FetchAll'.</summary>
            /// <param name='tempUIControlTemplate'>A temporary UIControlTemplate for passing values.</param>
            /// <returns>A collection of 'UIControlTemplate' objects.</returns>
            public List<UIControlTemplate> FetchAll(UIControlTemplate tempUIControlTemplate)
            {
                // Initial value
                List<UIControlTemplate> uIControlTemplateList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.UIControlTemplateMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateUIControlTemplateParameter(tempUIControlTemplate);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<UIControlTemplate> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        uIControlTemplateList = (List<UIControlTemplate>) returnObject.ObjectValue;
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
                return uIControlTemplateList;
            }
            #endregion

            #region Find(UIControlTemplate tempUIControlTemplate)
            /// <summary>
            /// Finds a 'UIControlTemplate' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'UIControlTemplate_Find'</param>
            /// </summary>
            /// <param name='tempUIControlTemplate'>A temporary UIControlTemplate for passing values.</param>
            /// <returns>A 'UIControlTemplate' object if found else a null 'UIControlTemplate'.</returns>
            public UIControlTemplate Find(UIControlTemplate tempUIControlTemplate)
            {
                // Initial values
                UIControlTemplate uIControlTemplate = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempUIControlTemplate != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.UIControlTemplateMethods.FindUIControlTemplate;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateUIControlTemplateParameter(tempUIControlTemplate);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as UIControlTemplate != null))
                        {
                            // Get ReturnObject
                            uIControlTemplate = (UIControlTemplate) returnObject.ObjectValue;
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
                return uIControlTemplate;
            }
            #endregion

            #region Insert(UIControlTemplate uIControlTemplate)
            /// <summary>
            /// Insert a 'UIControlTemplate' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'UIControlTemplate_Insert'.</param>
            /// </summary>
            /// <param name='uIControlTemplate'>The 'UIControlTemplate' object to insert.</param>
            /// <returns>The id (int) of the new  'UIControlTemplate' object that was inserted.</returns>
            public int Insert(UIControlTemplate uIControlTemplate)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If UIControlTemplateexists
                    if(uIControlTemplate != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.UIControlTemplateMethods.InsertUIControlTemplate;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateUIControlTemplateParameter(uIControlTemplate);

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

            #region Save(ref UIControlTemplate uIControlTemplate)
            /// <summary>
            /// Saves a 'UIControlTemplate' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='uIControlTemplate'>The 'UIControlTemplate' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref UIControlTemplate uIControlTemplate)
            {
                // Initial value
                bool saved = false;

                // If the uIControlTemplate exists.
                if(uIControlTemplate != null)
                {
                    // Is this a new UIControlTemplate
                    if(uIControlTemplate.IsNew)
                    {
                        // Insert new UIControlTemplate
                        int newIdentity = this.Insert(uIControlTemplate);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            uIControlTemplate.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update UIControlTemplate
                        saved = this.Update(uIControlTemplate);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(UIControlTemplate uIControlTemplate)
            /// <summary>
            /// This method Updates a 'UIControlTemplate' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'UIControlTemplate_Update'.</param>
            /// </summary>
            /// <param name='uIControlTemplate'>The 'UIControlTemplate' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(UIControlTemplate uIControlTemplate)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(uIControlTemplate != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.UIControlTemplateMethods.UpdateUIControlTemplate;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateUIControlTemplateParameter(uIControlTemplate);
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
