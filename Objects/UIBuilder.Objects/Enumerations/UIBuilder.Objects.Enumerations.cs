
namespace UIBuilder.Objects.Enumerations
{

    #region FormTypeEnum : int
    /// <summary>
    /// This is the type of Form
    /// </summary>
    public enum FormTypeEnum : int
    {
        StartUpForm = 0,
        Modal = 1,
        NonModal = 2,
        Child = 3
    }
    #endregion

    #region ControlTypeEnum : int
    /// <summary>
    /// This enumeration is the type of control that will be created
    /// </summary>
    public enum ControlTypeEnum : int
    {
        Unknown = 0,
        LabelTextBox = 1,
        LabelTextBoxBrowserFile = 2,
        LabelTextBoxBrowserFolder = 3,
        LabelComboBox = 4,
        LabelCheckBox = 5,
        Button = 6,
        ListEditor = 100,
        SaveCancel = 1000
    }
    #endregion

}
