using DevExpress.XtraEditors;

namespace Sistema.Proctor.WinForm.Helpers;

public class HelperMethods
{
    public static void OnlyDecimals(TextEdit textEdit)
    {
        textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
        textEdit.Properties.Mask.EditMask = @"N4";
        textEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
    }
}