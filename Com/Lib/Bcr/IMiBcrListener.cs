namespace Com.Lib.Bcr
{
    using Android.Runtime;
    using Com.Lib.Bcr.Utils;
    using System;

    [Register("com/lib/bcr/MiBcrListener", "", "Com.Lib.Bcr.IMiBcrListenerInvoker")]
    public interface IMiBcrListener : IJavaObject, IDisposable
    {
        [Register("onScanned", "(Lcom/lib/bcr/utils/BARCODE$TYPE;Ljava/lang/String;I)V", "GetOnScanned_Lcom_lib_bcr_utils_BARCODE_TYPE_Ljava_lang_String_IHandler:Com.Lib.Bcr.IMiBcrListenerInvoker, MiBcrLib")]
        void OnScanned(BARCODE.TYPE p0, string p1, int p2);
        [Register("onStatusChanged", "(I)V", "GetOnStatusChanged_IHandler:Com.Lib.Bcr.IMiBcrListenerInvoker, MiBcrLib")]
        void OnStatusChanged(int p0);
    }
}

