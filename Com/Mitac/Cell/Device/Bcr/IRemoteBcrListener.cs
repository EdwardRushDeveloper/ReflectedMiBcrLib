namespace Com.Mitac.Cell.Device.Bcr
{
    using Android.OS;
    using Android.Runtime;
    using System;

    [Register("com/mitac/cell/device/bcr/IRemoteBcrListener", "", "Com.Mitac.Cell.Device.Bcr.IRemoteBcrListenerInvoker")]
    public interface IRemoteBcrListener : IInterface, IJavaObject, IDisposable
    {
        [Register("onScanned", "(Ljava/lang/String;Ljava/lang/String;I)V", "GetOnScanned_Ljava_lang_String_Ljava_lang_String_IHandler:Com.Mitac.Cell.Device.Bcr.IRemoteBcrListenerInvoker, MiBcrLib")]
        void OnScanned(string p0, string p1, int p2);
        [Register("onStatusChanged", "(I)V", "GetOnStatusChanged_IHandler:Com.Mitac.Cell.Device.Bcr.IRemoteBcrListenerInvoker, MiBcrLib")]
        void OnStatusChanged(int p0);
    }
}

