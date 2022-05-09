

#region using statements



#endregion

namespace UIBuilder.Objects
{

    #region class Form
    /// <summary>
    /// A form represents a WindowsForm.
    /// </summary>
    public class Form
    {
        
        #region Private Variables
        private FormTypeEnum formTypeEnum;        
        #endregion

        #region Properties

            #region FormTypeEnum
            /// <summary>
            /// This property gets or sets the value for 'FormTypeEnum'.
            /// </summary>
            public FormTypeEnum FormTypeEnum
            {
                get { return formTypeEnum; }
                set { formTypeEnum = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
