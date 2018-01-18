namespace Com.Lib.Bcr.Utils
{
    using Android.Runtime;
    using Java.Lang;
    using System;

    [Register("com/lib/bcr/utils/BcrStatus", DoNotGenerateAcw=true)]
    public class BcrStatus : Object
    {
        private static IntPtr id_ctor;
        internal static IntPtr java_class_handle;
        [Register("Status_Closed")]
        public const int StatusClosed = 0xe1;
        [Register("Status_DecoderDetectFailed")]
        public const int StatusDecoderDetectFailed = 0x1b9;
        [Register("Status_FirmwareNotMatch")]
        public const int StatusFirmwareNotMatch = 440;
        [Register("Status_NoDecoderFound")]
        public const int StatusNoDecoderFound = 0x19b;
        [Register("Status_NotReady")]
        public const int StatusNotReady = 410;
        [Register("Status_Opening")]
        public const int StatusOpening = 210;
        [Register("Status_Pull_File")]
        public const int StatusPullFile = 0xfb;
        [Register("Status_Push_File")]
        public const int StatusPushFile = 250;
        [Register("Status_Reading")]
        public const int StatusReading = 0xdd;
        [Register("Status_ReadingContinuous")]
        public const int StatusReadingContinuous = 0xe0;
        [Register("Status_Ready")]
        public const int StatusReady = 220;
        [Register("Status_Scanned")]
        public const int StatusScanned = 0xde;
        [Register("Status_ScanStopped")]
        public const int StatusScanStopped = 0xdf;
        [Register("Status_ServiceConnected")]
        public const int StatusServiceConnected = 0xcc;
        [Register("Status_ServiceConnecting")]
        public const int StatusServiceConnecting = 0xcb;
        [Register("Status_ServiceDisconnected")]
        public const int StatusServiceDisconnected = 0xca;
        [Register("Status_ServiceStarted")]
        public const int StatusServiceStarted = 200;
        [Register("Status_ServiceStopped")]
        public const int StatusServiceStopped = 0xc9;
        [Register("Status_SettingChanged")]
        public const int StatusSettingChanged = 240;

        [Register(".ctor", "()V", "")]
        public BcrStatus() : base(IntPtr.Zero, 0)
        {
            if (base.get_Handle() == IntPtr.Zero)
            {
                try
                {
                    if (base.GetType() != typeof(BcrStatus))
                    {
                        base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), 1);
                        JNIEnv.FinishCreateInstance(base.get_Handle(), "()V", Array.Empty<JValue>());
                    }
                    else
                    {
                        if (id_ctor == IntPtr.Zero)
                        {
                            id_ctor = JNIEnv.GetMethodID(class_ref, "<init>", "()V");
                        }
                        base.SetHandle(JNIEnv.StartCreateInstance(class_ref, id_ctor, Array.Empty<JValue>()), 1);
                        JNIEnv.FinishCreateInstance(base.get_Handle(), class_ref, id_ctor, Array.Empty<JValue>());
                    }
                }
                finally
                {
                }
            }
        }

        protected BcrStatus(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        internal static IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/lib/bcr/utils/BcrStatus", ref java_class_handle);
            }
        }

        protected override IntPtr ThresholdClass
        {
            get
            {
                return class_ref;
            }
        }

        protected override Type ThresholdType
        {
            get
            {
                return typeof(BcrStatus);
            }
        }
    }
}

