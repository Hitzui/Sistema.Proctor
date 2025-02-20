namespace DevExpress.UITemplates.Collection.Forms.Base {
    using DevExpress.UITemplates.Collection.Utilities;
    using DevExpress.Utils;

    public static class FormAssets {
        // Common Assets
        public static HtmlCssAsset FixedDialog = new FixedDialogHtmlCssAsset();
        // Common Images
        public static SvgImageCollection DefaultHtmlImages {
            get { return DevExpress.UITemplates.Collection.Images.UIElements.SvgImages; }
        }
        //
        sealed class FixedDialogHtmlCssAsset : HtmlCssAsset {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            static FixedDialogHtmlCssAsset() {
                DevExpress.XtraEditors.DirectXForm.RegisterHtmlComponents();
            }
        }
    }
}
