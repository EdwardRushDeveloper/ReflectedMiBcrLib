namespace Com.Lib.Bcr
{
    using Android.Runtime;
    using Com.Lib.Bcr.Utils;
    using Java.Lang;
    using System;

    [Register("mono/com/lib/bcr/MiBcrListenerImplementor")]
    internal sealed class IMiBcrListenerImplementor : Object, IMiBcrListener, IJavaObject, IDisposable
    {
        public EventHandler<ScannedEventArgs> OnScannedHandler;
        public EventHandler<StatusChangedEventArgs> OnStatusChangedHandler;
        private object sender;

        public IMiBcrListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/lib/bcr/MiBcrListenerImplementor", "()V", Array.Empty<JValue>()), 1)
        {
            JNIEnv.FinishCreateInstance(base.get_Handle(), "()V", Array.Empty<JValue>());
            this.sender = sender;
        }

        internal static bool __IsEmpty(IMiBcrListenerImplementor value)
        {
            return ((value.OnScannedHandler == null) && (value.OnStatusChangedHandler == null));
        }

        public void OnScanned(BARCODE.TYPE p0, string p1, int p2)
        {
            EventHandler<ScannedEventArgs> onScannedHandler = this.OnScannedHandler;
            if (onScannedHandler > null)
            {
                onScannedHandler(this.sender, new ScannedEventArgs(p0, p1, p2));
            }
        }

        public void OnStatusChanged(int p0)
        {
            EventHandler<StatusChangedEventArgs> onStatusChangedHandler = this.OnStatusChangedHandler;
            if (onStatusChangedHandler > null)
            {
                onStatusChangedHandler(this.sender, new StatusChangedEventArgs(p0));
            }
        }
    }
}

