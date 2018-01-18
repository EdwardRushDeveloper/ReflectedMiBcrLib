namespace Com.Mitac.Cell.Device.Bcr
{
    using Android.Runtime;
    using System;

    [Register("com/mitac/cell/device/bcr/IRemoteBcrService$Stub", DoNotGenerateAcw=true)]
    internal class RemoteBcrServiceStubInvoker : RemoteBcrServiceStub
    {
        private static IntPtr id_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
        private static IntPtr id_get_Ljava_lang_String_;
        private static IntPtr id_getStatus;
        private static IntPtr id_isReady;
        private static IntPtr id_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
        private static IntPtr id_save;
        private static IntPtr id_scan_Z;
        private static IntPtr id_set_Ljava_lang_String_;
        private static IntPtr id_startSettingsActivity;

        public RemoteBcrServiceStubInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {
        }

        [Register("addListener", "(Lcom/mitac/cell/device/bcr/IRemoteBcrListener;)V", "GetAddListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_Handler")]
        public override unsafe void AddListener(IRemoteBcrListener p0)
        {
            if (id_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ == IntPtr.Zero)
            {
                id_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ = JNIEnv.GetMethodID(RemoteBcrServiceStub.class_ref, "addListener", "(Lcom/mitac/cell/device/bcr/IRemoteBcrListener;)V");
            }
            try
            {
                JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                valuePtr[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(base.get_Handle(), id_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_, valuePtr);
            }
            finally
            {
            }
        }

        [Register("get", "(Ljava/lang/String;)Ljava/lang/String;", "GetGet_Ljava_lang_String_Handler")]
        public override unsafe string Get(string p0)
        {
            string str2;
            if (id_get_Ljava_lang_String_ == IntPtr.Zero)
            {
                id_get_Ljava_lang_String_ = JNIEnv.GetMethodID(RemoteBcrServiceStub.class_ref, "get", "(Ljava/lang/String;)Ljava/lang/String;");
            }
            IntPtr ptr = JNIEnv.NewString(p0);
            try
            {
                JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                valuePtr[0] = new JValue(ptr);
                str2 = JNIEnv.GetString(JNIEnv.CallObjectMethod(base.get_Handle(), id_get_Ljava_lang_String_, valuePtr), 1);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(ptr);
            }
            return str2;
        }

        [Register("removeListener", "(Lcom/mitac/cell/device/bcr/IRemoteBcrListener;)V", "GetRemoveListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_Handler")]
        public override unsafe void RemoveListener(IRemoteBcrListener p0)
        {
            if (id_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ == IntPtr.Zero)
            {
                id_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ = JNIEnv.GetMethodID(RemoteBcrServiceStub.class_ref, "removeListener", "(Lcom/mitac/cell/device/bcr/IRemoteBcrListener;)V");
            }
            try
            {
                JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                valuePtr[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(base.get_Handle(), id_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_, valuePtr);
            }
            finally
            {
            }
        }

        [Register("save", "()V", "GetSaveHandler")]
        public override void Save()
        {
            if (id_save == IntPtr.Zero)
            {
                id_save = JNIEnv.GetMethodID(RemoteBcrServiceStub.class_ref, "save", "()V");
            }
            try
            {
                JNIEnv.CallVoidMethod(base.get_Handle(), id_save);
            }
            finally
            {
            }
        }

        [Register("scan", "(Z)V", "GetScan_ZHandler")]
        public override unsafe void Scan(bool p0)
        {
            if (id_scan_Z == IntPtr.Zero)
            {
                id_scan_Z = JNIEnv.GetMethodID(RemoteBcrServiceStub.class_ref, "scan", "(Z)V");
            }
            try
            {
                JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                valuePtr[0] = new JValue(p0);
                JNIEnv.CallVoidMethod(base.get_Handle(), id_scan_Z, valuePtr);
            }
            finally
            {
            }
        }

        [Register("set", "(Ljava/lang/String;)V", "GetSet_Ljava_lang_String_Handler")]
        public override unsafe void Set(string p0)
        {
            if (id_set_Ljava_lang_String_ == IntPtr.Zero)
            {
                id_set_Ljava_lang_String_ = JNIEnv.GetMethodID(RemoteBcrServiceStub.class_ref, "set", "(Ljava/lang/String;)V");
            }
            IntPtr ptr = JNIEnv.NewString(p0);
            try
            {
                JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                valuePtr[0] = new JValue(ptr);
                JNIEnv.CallVoidMethod(base.get_Handle(), id_set_Ljava_lang_String_, valuePtr);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(ptr);
            }
        }

        [Register("startSettingsActivity", "()V", "GetStartSettingsActivityHandler")]
        public override void StartSettingsActivity()
        {
            if (id_startSettingsActivity == IntPtr.Zero)
            {
                id_startSettingsActivity = JNIEnv.GetMethodID(RemoteBcrServiceStub.class_ref, "startSettingsActivity", "()V");
            }
            try
            {
                JNIEnv.CallVoidMethod(base.get_Handle(), id_startSettingsActivity);
            }
            finally
            {
            }
        }

        public override bool IsReady
        {
            [Register("isReady", "()Z", "GetIsReadyHandler")]
            get
            {
                if (id_isReady == IntPtr.Zero)
                {
                    id_isReady = JNIEnv.GetMethodID(RemoteBcrServiceStub.class_ref, "isReady", "()Z");
                }
                try
                {
                    return JNIEnv.CallBooleanMethod(base.get_Handle(), id_isReady);
                }
                finally
                {
                }
            }
        }

        public override int Status
        {
            [Register("getStatus", "()I", "GetGetStatusHandler")]
            get
            {
                if (id_getStatus == IntPtr.Zero)
                {
                    id_getStatus = JNIEnv.GetMethodID(RemoteBcrServiceStub.class_ref, "getStatus", "()I");
                }
                try
                {
                    return JNIEnv.CallIntMethod(base.get_Handle(), id_getStatus);
                }
                finally
                {
                }
            }
        }

        protected override Type ThresholdType
        {
            get
            {
                return typeof(RemoteBcrServiceStubInvoker);
            }
        }
    }
}

