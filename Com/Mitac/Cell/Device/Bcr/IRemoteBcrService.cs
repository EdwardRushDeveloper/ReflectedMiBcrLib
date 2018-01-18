namespace Com.Mitac.Cell.Device.Bcr
{
    using Android.OS;
    using Android.Runtime;
    using System;

    [Register("com/mitac/cell/device/bcr/IRemoteBcrService", "", "Com.Mitac.Cell.Device.Bcr.IRemoteBcrServiceInvoker")]
    public interface IRemoteBcrService : IInterface, IJavaObject, IDisposable
    {
        [Register("addListener", "(Lcom/mitac/cell/device/bcr/IRemoteBcrListener;)V", "GetAddListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_Handler:Com.Mitac.Cell.Device.Bcr.IRemoteBcrServiceInvoker, MiBcrLib")]
        void AddListener(IRemoteBcrListener p0);
        [Register("get", "(Ljava/lang/String;)Ljava/lang/String;", "GetGet_Ljava_lang_String_Handler:Com.Mitac.Cell.Device.Bcr.IRemoteBcrServiceInvoker, MiBcrLib")]
        string Get(string p0);
        [Register("removeListener", "(Lcom/mitac/cell/device/bcr/IRemoteBcrListener;)V", "GetRemoveListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_Handler:Com.Mitac.Cell.Device.Bcr.IRemoteBcrServiceInvoker, MiBcrLib")]
        void RemoveListener(IRemoteBcrListener p0);
        [Register("save", "()V", "GetSaveHandler:Com.Mitac.Cell.Device.Bcr.IRemoteBcrServiceInvoker, MiBcrLib")]
        void Save();
        [Register("scan", "(Z)V", "GetScan_ZHandler:Com.Mitac.Cell.Device.Bcr.IRemoteBcrServiceInvoker, MiBcrLib")]
        void Scan(bool p0);
        [Register("set", "(Ljava/lang/String;)V", "GetSet_Ljava_lang_String_Handler:Com.Mitac.Cell.Device.Bcr.IRemoteBcrServiceInvoker, MiBcrLib")]
        void Set(string p0);
        [Register("startSettingsActivity", "()V", "GetStartSettingsActivityHandler:Com.Mitac.Cell.Device.Bcr.IRemoteBcrServiceInvoker, MiBcrLib")]
        void StartSettingsActivity();

        bool IsReady { [Register("isReady", "()Z", "GetIsReadyHandler:Com.Mitac.Cell.Device.Bcr.IRemoteBcrServiceInvoker, MiBcrLib")] get; }

        int Status { [Register("getStatus", "()I", "GetGetStatusHandler:Com.Mitac.Cell.Device.Bcr.IRemoteBcrServiceInvoker, MiBcrLib")] get; }
    }
}

