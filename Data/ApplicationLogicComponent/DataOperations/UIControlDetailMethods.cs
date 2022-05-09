

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

    #region class UIControlDetailMethods
    /// <summary>
    /// This class contains methods for modifying a 'UIControlDetail' object.
    /// </summary>
    public class UIControlDetailMethods
    {

        #region Private Variables
        private DataManager dataManager;
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new Creates a new 'UIControlDetailMethods' object.
        /// </summary>
        public UIControlDetailMethods(DataManager dataManagerArg)
        {
            // Save Argument
            this.DataManager = dataManagerArg;
        }
        #endregion

        #region Methods

            #region DeleteUIControlDetail(UIControlDetail)
            /// <summary>
            /// This method deletes a 'UIControlDetail' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'UIControlDetail' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject DeleteUIControlDetail(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Delete StoredProcedure
                    DeleteUIControlDetailStoredProcedure deleteUIControlDetailProc = null;

                    // verify the first parameters is a(n) 'UIControlDetail'.
                    if (parameters[0].ObjectValue as UIControlDetail != null)
                    {
                        // Create UIControlDetail
                        UIControlDetail uIControlDetail = (UIControlDetail) parameters[0].ObjectValue;

                        // verify uIControlDetail exists
                        if(uIControlDetail != null)
                        {
                            // Now create deleteUIControlDetailProc from UIControlDetailWriter
                            // The DataWriter converts the 'UIControlDetail'
                            // to the SqlParameter[] array needed to delete a 'UIControlDetail'.
                            deleteUIControlDetailProc = UIControlDetailWriter.CreateDeleteUIControlDetailStoredProcedure(uIControlDetail);
                        }
                    }

                    // Verify deleteUIControlDetailProc exists
                    if(deleteUIControlDetailProc != null)
                    {
                        // Execute Delete Stored Procedure
                        bool deleted = this.DataManager.UIControlDetailManager.DeleteUIControlDetail(deleteUIControlDetailProc, dataConnector);

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
            /// This method fetches all 'UIControlDetail' objects.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'UIControlDetail' to delete.
            /// <returns>A PolymorphicObject object with all  'UIControlDetails' objects.
            internal PolymorphicObject FetchAll(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                List<UIControlDetail> uIControlDetailListCollection =  null;

                // Create FetchAll StoredProcedure
                FetchAllUIControlDetailsStoredProcedure fetchAllProc = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Get UIControlDetailParameter
                    // Declare Parameter
                    UIControlDetail paramUIControlDetail = null;

                    // verify the first parameters is a(n) 'UIControlDetail'.
                    if (parameters[0].ObjectValue as UIControlDetail != null)
                    {
                        // Get UIControlDetailParameter
                        paramUIControlDetail = (UIControlDetail) parameters[0].ObjectValue;
                    }

                    // Now create FetchAllUIControlDetailsProc from UIControlDetailWriter
                    fetchAllProc = UIControlDetailWriter.CreateFetchAllUIControlDetailsStoredProcedure(paramUIControlDetail);
                }

                // Verify fetchAllProc exists
                if(fetchAllProc!= null)
                {
                    // Execute FetchAll Stored Procedure
                    uIControlDetailListCollection = this.DataManager.UIControlDetailManager.FetchAllUIControlDetails(fetchAllProc, dataConnector);

                    // if dataObjectCollection exists
                    if(uIControlDetailListCollection != null)
                    {
                        // set returnObject.ObjectValue
                        returnObject.ObjectValue = uIControlDetailListCollection;
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

            #region FindUIControlDetail(UIControlDetail)
            /// <summary>
            /// This method finds a 'UIControlDetail' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'UIControlDetail' to delete.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject FindUIControlDetail(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                UIControlDetail uIControlDetail = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Find StoredProcedure
                    FindUIControlDetailStoredProcedure findUIControlDetailProc = null;

                    // verify the first parameters is a 'UIControlDetail'.
                    if (parameters[0].ObjectValue as UIControlDetail != null)
                    {
                        // Get UIControlDetailParameter
                        UIControlDetail paramUIControlDetail = (UIControlDetail) parameters[0].ObjectValue;

                        // verify paramUIControlDetail exists
                        if(paramUIControlDetail != null)
                        {
                            // Now create findUIControlDetailProc from UIControlDetailWriter
                            // The DataWriter converts the 'UIControlDetail'
                            // to the SqlParameter[] array needed to find a 'UIControlDetail'.
                            findUIControlDetailProc = UIControlDetailWriter.CreateFindUIControlDetailStoredProcedure(paramUIControlDetail);
                        }

                        // Verify findUIControlDetailProc exists
                        if(findUIControlDetailProc != null)
                        {
                            // Execute Find Stored Procedure
                            uIControlDetail = this.DataManager.UIControlDetailManager.FindUIControlDetail(findUIControlDetailProc, dataConnector);

                            // if dataObject exists
                            if(uIControlDetail != null)
                            {
                                // set returnObject.ObjectValue
                                returnObject.ObjectValue = uIControlDetail;
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

            #region InsertUIControlDetail (UIControlDetail)
            /// <summary>
            /// This method inserts a 'UIControlDetail' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'UIControlDetail' to insert.
            /// <returns>A PolymorphicObject object with a Boolean value.
            internal PolymorphicObject InsertUIControlDetail(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                UIControlDetail uIControlDetail = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Insert StoredProcedure
                    InsertUIControlDetailStoredProcedure insertUIControlDetailProc = null;

                    // verify the first parameters is a(n) 'UIControlDetail'.
                    if (parameters[0].ObjectValue as UIControlDetail != null)
                    {
                        // Create UIControlDetail Parameter
                        uIControlDetail = (UIControlDetail) parameters[0].ObjectValue;

                        // verify uIControlDetail exists
                        if(uIControlDetail != null)
                        {
                            // Now create insertUIControlDetailProc from UIControlDetailWriter
                            // The DataWriter converts the 'UIControlDetail'
                            // to the SqlParameter[] array needed to insert a 'UIControlDetail'.
                            insertUIControlDetailProc = UIControlDetailWriter.CreateInsertUIControlDetailStoredProcedure(uIControlDetail);
                        }

                        // Verify insertUIControlDetailProc exists
                        if(insertUIControlDetailProc != null)
                        {
                            // Execute Insert Stored Procedure
                            returnObject.IntegerValue = this.DataManager.UIControlDetailManager.InsertUIControlDetail(insertUIControlDetailProc, dataConnector);
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

            #region UpdateUIControlDetail (UIControlDetail)
            /// <summary>
            /// This method updates a 'UIControlDetail' object.
            /// </summary>
            /// <param name='List<PolymorphicObject>'>The 'UIControlDetail' to update.
            /// <returns>A PolymorphicObject object with a value.
            internal PolymorphicObject UpdateUIControlDetail(List<PolymorphicObject> parameters, DataConnector dataConnector)
            {
                // Initial Value
                PolymorphicObject returnObject = new PolymorphicObject();

                // locals
                UIControlDetail uIControlDetail = null;

                // If the data connection is connected
                if ((dataConnector != null) && (dataConnector.Connected == true))
                {
                    // Create Update StoredProcedure
                    UpdateUIControlDetailStoredProcedure updateUIControlDetailProc = null;

                    // verify the first parameters is a(n) 'UIControlDetail'.
                    if (parameters[0].ObjectValue as UIControlDetail != null)
                    {
                        // Create UIControlDetail Parameter
                        uIControlDetail = (UIControlDetail) parameters[0].ObjectValue;

                        // verify uIControlDetail exists
                        if(uIControlDetail != null)
                        {
                            // Now create updateUIControlDetailProc from UIControlDetailWriter
                            // The DataWriter converts the 'UIControlDetail'
                            // to the SqlParameter[] array needed to update a 'UIControlDetail'.
                            updateUIControlDetailProc = UIControlDetailWriter.CreateUpdateUIControlDetailStoredProcedure(uIControlDetail);
                        }

                        // Verify updateUIControlDetailProc exists
                        if(updateUIControlDetailProc != null)
                        {
                            // Execute Update Stored Procedure
                            bool saved = this.DataManager.UIControlDetailManager.UpdateUIControlDetail(updateUIControlDetailProc, dataConnector);

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
