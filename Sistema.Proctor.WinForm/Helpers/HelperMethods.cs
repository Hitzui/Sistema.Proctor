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
    public static decimal ConvertToDecimal(TextEdit? textEdit, decimal valorDefecto = 0)
    {
        if (textEdit == null || string.IsNullOrWhiteSpace(textEdit.Text))
            return valorDefecto;

        return decimal.TryParse(textEdit.Text, out decimal resultado) ? resultado : valorDefecto;
    }

    public static int ConvertToInt(TextEdit? textEdit, int valorDefecto = 0)
    {
        if (textEdit == null || string.IsNullOrWhiteSpace(textEdit.Text))
            return valorDefecto;

        return int.TryParse(textEdit.Text, out int resultado) ? resultado : valorDefecto;
    }
}