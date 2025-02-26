using System.IO;
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

    public static Image? RecuperarImagen(byte[] imagenBytes)
    {
        switch (imagenBytes.Length)
        {
            case > 0:
            {
                using var ms = new MemoryStream(imagenBytes);
                return Image.FromStream(ms);
            }
            default:
                return null;
        }
    }
}