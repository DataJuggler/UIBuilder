

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

    #region class UIControlDetailController
    /// <summary>
    /// This class controls a(n) 'UIControlDetail' object.
    /// </summary>
    public class UIControlDetailController
    {

        #region Private Variables
        private ErrorHandler errorProcessor;
        private ApplicationController appController;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new 'UIControlDetailController' object.
        /// </summary>
        public UIControlDetailController(ErrorHandler errorProcessorArg, ApplicationController appControllerArg)
        {
            // Save Arguments
            this.ErrorProcessor = errorProcessorArg;
            this.AppController = appControllerArg;
        }
        #endregion

        #region Methods

            #region CreateUIControlDetailParameter
            /// <summary>
            /// This method creates the parameter for a 'UIControlDetail' data operation.
            /// </summary>
            /// <param name='uicontroldetail'>The 'UIControlDetail' to use as the first
            /// parameter (parameters[0]).</param>
            /// <returns>A List<PolymorphicObject> collection.</returns>
            private List<PolymorphicObject> CreateUIControlDetailParameter(UIControlDetail uIControlDetail)
            {
                // Initial Value
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // Create PolymorphicObject to hold the parameter
                PolymorphicObject parameter = new PolymorphicObject();

                // Set parameter.ObjectValue
                parameter.ObjectValue = uIControlDetail;

                // Add userParameter to parameters
                parameters.Add(parameter);

                // return value
                return parameters;
            }
            #endregion

            #region Delete(UIControlDetail tempUIControlDetail)
            /// <summary>
            /// Deletes a 'UIControlDetail' from the database
            /// This method calls the DataBridgeManager to execute the delete using the
            /// procedure 'UIControlDetail_Delete'.
            /// </summary>
            /// <param name='uicontroldetail'>The 'UIControlDetail' to delete.</param>
            /// <returns>True if the delete is successful or false if not.</returns>
            public bool Delete(UIControlDetail tempUIControlDetail)
            {
                // locals
                bool deleted = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "DeleteUIControlDetail";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // verify tempuIControlDetail exists before attemptintg to delete
                    if(tempUIControlDetail != null)
                    {
                        // Create Delegate For DataOperation
                        ApplicationController.DataOperationMethod deleteUIControlDetailMethod = this.AppController.DataBridge.DataOperations.UIControlDetailMethods.DeleteUIControlDetail;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateUIControlDetailParameter(tempUIControlDetail);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, deleteUIControlDetailMethod, parameters);

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

            #region FetchAll(UIControlDetail tempUIControlDetail)
            /// <summary>
            /// This method fetches a collection of 'UIControlDetail' objects.
            /// This method used the DataBridgeManager to execute the fetch all using the
            /// procedure 'UIControlDetail_FetchAll'.</summary>
            /// <param name='tempUIControlDetail'>A temporary UIControlDetail for passing values.</param>
            /// <returns>A collection of 'UIControlDetail' objects.</returns>
            public List<UIControlDetail> FetchAll(UIControlDetail tempUIControlDetail)
            {
                // Initial value
                List<UIControlDetail> uIControlDetailList = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "FetchAll";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // Create DataOperation Method
                    ApplicationController.DataOperationMethod fetchAllMethod = this.AppController.DataBridge.DataOperations.UIControlDetailMethods.FetchAll;

                    // Create parameters for this method
                    List<PolymorphicObject> parameters = CreateUIControlDetailParameter(tempUIControlDetail);

                    // Perform DataOperation
                    PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, fetchAllMethod , parameters);

                    // If return object exists
                    if ((returnObject != null) && (returnObject.ObjectValue as List<UIControlDetail> != null))
                    {
                        // Create Collection From ReturnObject.ObjectValue
                        uIControlDetailList = (List<UIControlDetail>) returnObject.ObjectValue;
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
                return uIControlDetailList;
            }
            #endregion

            #region Find(UIControlDetail tempUIControlDetail)
            /// <summary>
            /// Finds a 'UIControlDetail' object by the primary key.
            /// This method used the DataBridgeManager to execute the 'Find' using the
            /// procedure 'UIControlDetail_Find'</param>
            /// </summary>
            /// <param name='tempUIControlDetail'>A temporary UIControlDetail for passing values.</param>
            /// <returns>A 'UIControlDetail' object if found else a null 'UIControlDetail'.</returns>
            public UIControlDetail Find(UIControlDetail tempUIControlDetail)
            {
                // Initial values
                UIControlDetail uIControlDetail = null;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Find";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If object exists
                    if(tempUIControlDetail != null)
                    {
                        // Create DataOperation
                        ApplicationController.DataOperationMethod findMethod = this.AppController.DataBridge.DataOperations.UIControlDetailMethods.FindUIControlDetail;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateUIControlDetailParameter(tempUIControlDetail);

                        // Perform DataOperation
                        PolymorphicObject returnObject = this.AppController.DataBridge.PerformDataOperation(methodName, objectName, findMethod , parameters);

                        // If return object exists
                        if ((returnObject != null) && (returnObject.ObjectValue as UIControlDetail != null))
                        {
                            // Get ReturnObject
                            uIControlDetail = (UIControlDetail) returnObject.ObjectValue;
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
                return uIControlDetail;
            }
            #endregion

            #region Insert(UIControlDetail uIControlDetail)
            /// <summary>
            /// Insert a 'UIControlDetail' object into the database.
            /// This method uses the DataBridgeManager to execute the 'Insert' using the
            /// procedure 'UIControlDetail_Insert'.</param>
            /// </summary>
            /// <param name='uIControlDetail'>The 'UIControlDetail' object to insert.</param>
            /// <returns>The id (int) of the new  'UIControlDetail' object that was inserted.</returns>
            public int Insert(UIControlDetail uIControlDetail)
            {
                // Initial values
                int newIdentity = -1;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Insert";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    // If UIControlDetailexists
                    if(uIControlDetail != null)
                    {
                        ApplicationController.DataOperationMethod insertMethod = this.AppController.DataBridge.DataOperations.UIControlDetailMethods.InsertUIControlDetail;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateUIControlDetailParameter(uIControlDetail);

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

            #region Save(ref UIControlDetail uIControlDetail)
            /// <summary>
            /// Saves a 'UIControlDetail' object into the database.
            /// This method calls the 'Insert' or 'Update' method.
            /// </summary>
            /// <param name='uIControlDetail'>The 'UIControlDetail' object to save.</param>
            /// <returns>True if successful or false if not.</returns>
            public bool Save(ref UIControlDetail uIControlDetail)
            {
                // Initial value
                bool saved = false;

                // If the uIControlDetail exists.
                if(uIControlDetail != null)
                {
                    // Is this a new UIControlDetail
                    if(uIControlDetail.IsNew)
                    {
                        // Insert new UIControlDetail
                        int newIdentity = this.Insert(uIControlDetail);

                        // if insert was successful
                        if(newIdentity > 0)
                        {
                            // Update Identity
                            uIControlDetail.UpdateIdentity(newIdentity);

                            // Set return value
                            saved = true;
                        }
                    }
                    else
                    {
                        // Update UIControlDetail
                        saved = this.Update(uIControlDetail);
                    }
                }

                // return value
                return saved;
            }
            #endregion

            #region Update(UIControlDetail uIControlDetail)
            /// <summary>
            /// This method Updates a 'UIControlDetail' object in the database.
            /// This method used the DataBridgeManager to execute the 'Update' using the
            /// procedure 'UIControlDetail_Update'.</param>
            /// </summary>
            /// <param name='uIControlDetail'>The 'UIControlDetail' object to update.</param>
            /// <returns>True if successful else false if not.</returns>
            public bool Update(UIControlDetail uIControlDetail)
            {
                // Initial value
                bool saved = false;

                // Get information for calling 'DataBridgeManager.PerformDataOperation' method.
                string methodName = "Update";
                string objectName = "ApplicationLogicComponent.Controllers";

                try
                {
                    if(uIControlDetail != null)
                    {
                        // Create Delegate
                        ApplicationController.DataOperationMethod updateMethod = this.AppController.DataBridge.DataOperations.UIControlDetailMethods.UpdateUIControlDetail;

                        // Create parameters for this method
                        List<PolymorphicObject> parameters = CreateUIControlDetailParameter(uIControlDetail);
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
