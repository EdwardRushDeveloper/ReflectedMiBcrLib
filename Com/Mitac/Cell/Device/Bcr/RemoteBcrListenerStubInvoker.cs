namespace Com.Mitac.Cell.Device.Bcr
{
    using Android.Runtime;
    using System;

    [Register("com/mitac/cell/device/bcr/IRemoteBcrListener$Stub", DoNotGenerateAcw=true)]
    internal class RemoteBcrListenerStubInvoker : RemoteBcrListenerStub
    {
        private static IntPtr id_onScanned_Ljava_lang_String_Ljava_lang_String_I;
        private static IntPtr id_onStatusChanged_I;

        public RemoteBcrListenerStubInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {
        }

        [Register("onScanned", "(Ljava/lang/String;Ljava/lang/String;I)V", "GetOnScanned_Ljava_lang_String_Ljava_lang_String_IHandler")]
        public override unsafe void OnScanned(string p0, string p1, int p2)
        {
            if (id_onScanned_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
            {
                id_onScanned_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID(RemoteBcrListenerStub.class_ref, "onScanned", "(Ljava/lang/String;Ljava/lang/String;I)V");
            }
            IntPtr ptr = JNIEnv.NewString(p0);
            IntPtr ptr2 = JNIEnv.NewString(p1);
            try
            {
                JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 3) * sizeof(JValue))];
                valuePtr[0] = new JValue(ptr);
                valuePtr[1] = new JValue(ptr2);
                valuePtr[2] = new JValue(p2);
                JNIEnv.CallVoidMethod(base.get_Handle(), id_onScanned_Ljava_lang_String_Ljava_lang_String_I, valuePtr);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(ptr);
                JNIEnv.DeleteLocalRef(ptr2);
            }
        }

        [Register("onStatusChanged", "(I)V", "GetOnStatusChanged_IHandler")]
        public override unsafe void OnStatusChanged(int p0)
        {
            if (id_onStatusChanged_I == IntPtr.Zero)
            {
                id_onStatusChanged_I = JNIEnv.GetMethodID(RemoteBcrListenerStub.class_ref, "onStatusChanged", "(I)V");
            }
            try
            {
                JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                valuePtr[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(base.get_Handle(), id_onStatusChanged_I, valuePtr);
            }
            finally
            {
            }
        }

        protected override Type ThresholdType
        {
            get
            {
                return typeof(RemoteBcrListenerStubInvoker);
            }
        }
    }
}

