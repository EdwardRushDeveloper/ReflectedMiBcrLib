namespace Com.Mitac.Cell.Device.Bcr
{
    using Android.OS;
    using Android.Runtime;
    using Java.Lang;
    using System;

    [Register("com/mitac/cell/device/bcr/IRemoteBcrService$Stub", DoNotGenerateAcw=true)]
    public abstract class RemoteBcrServiceStub : Binder, IRemoteBcrService, IInterface, IJavaObject, IDisposable
    {
        private static Delegate cb_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
        private static Delegate cb_asBinder;
        private static Delegate cb_get_Ljava_lang_String_;
        private static Delegate cb_getStatus;
        private static Delegate cb_isReady;
        private static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
        private static Delegate cb_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
        private static Delegate cb_save;
        private static Delegate cb_scan_Z;
        private static Delegate cb_set_Ljava_lang_String_;
        private static Delegate cb_startSettingsActivity;
        private static IntPtr id_asBinder;
        private static IntPtr id_asInterface_Landroid_os_IBinder_;
        private static IntPtr id_ctor;
        private static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
        internal static IntPtr java_class_handle;

        [Register(".ctor", "()V", "")]
        public RemoteBcrServiceStub() : base(IntPtr.Zero, 0)
        {
            if (base.get_Handle() == IntPtr.Zero)
            {
                try
                {
                    if (base.GetType() != typeof(RemoteBcrServiceStub))
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

        protected RemoteBcrServiceStub(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        [Register("addListener", "(Lcom/mitac/cell/device/bcr/IRemoteBcrListener;)V", "GetAddListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_Handler")]
        public abstract void AddListener(IRemoteBcrListener p0);
        [Register("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
        public virtual IBinder AsBinder()
        {
            if (id_asBinder == IntPtr.Zero)
            {
                id_asBinder = JNIEnv.GetMethodID(class_ref, "asBinder", "()Landroid/os/IBinder;");
            }
            try
            {
                if (base.GetType() == this.get_ThresholdType())
                {
                    return Object.GetObject<IBinder>(JNIEnv.CallObjectMethod(base.get_Handle(), id_asBinder), 1);
                }
                return Object.GetObject<IBinder>(JNIEnv.CallNonvirtualObjectMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "asBinder", "()Landroid/os/IBinder;")), 1);
            }
            finally
            {
            }
        }

        [Register("asInterface", "(Landroid/os/IBinder;)Lcom/mitac/cell/device/bcr/IRemoteBcrService;", "")]
        public static unsafe IRemoteBcrService AsInterface(IBinder p0)
        {
            if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
            {
                id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID(class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/mitac/cell/device/bcr/IRemoteBcrService;");
            }
            try
            {
                JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                valuePtr[0] = new JValue(p0);
                return Object.GetObject<IRemoteBcrService>(JNIEnv.CallStaticObjectMethod(class_ref, id_asInterface_Landroid_os_IBinder_, valuePtr), 1);
            }
            finally
            {
            }
        }

        [Register("get", "(Ljava/lang/String;)Ljava/lang/String;", "GetGet_Ljava_lang_String_Handler")]
        public abstract string Get(string p0);
        private static Delegate GetAddListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_Handler()
        {
            if (cb_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ == null)
            {
                cb_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(RemoteBcrServiceStub.n_AddListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_));
            }
            return cb_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
        }

        private static Delegate GetAsBinderHandler()
        {
            if (cb_asBinder == null)
            {
                cb_asBinder = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(RemoteBcrServiceStub.n_AsBinder));
            }
            return cb_asBinder;
        }

        private static Delegate GetGet_Ljava_lang_String_Handler()
        {
            if (cb_get_Ljava_lang_String_ == null)
            {
                cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr, IntPtr>(RemoteBcrServiceStub.n_Get_Ljava_lang_String_));
            }
            return cb_get_Ljava_lang_String_;
        }

        private static Delegate GetGetStatusHandler()
        {
            if (cb_getStatus == null)
            {
                cb_getStatus = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int>(RemoteBcrServiceStub.n_GetStatus));
            }
            return cb_getStatus;
        }

        private static Delegate GetIsReadyHandler()
        {
            if (cb_isReady == null)
            {
                cb_isReady = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, bool>(RemoteBcrServiceStub.n_IsReady));
            }
            return cb_isReady;
        }

        private static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler()
        {
            if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
            {
                cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>(RemoteBcrServiceStub.n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I));
            }
            return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
        }

        private static Delegate GetRemoveListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_Handler()
        {
            if (cb_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ == null)
            {
                cb_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(RemoteBcrServiceStub.n_RemoveListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_));
            }
            return cb_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
        }

        private static Delegate GetSaveHandler()
        {
            if (cb_save == null)
            {
                cb_save = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr>(RemoteBcrServiceStub.n_Save));
            }
            return cb_save;
        }

        private static Delegate GetScan_ZHandler()
        {
            if (cb_scan_Z == null)
            {
                cb_scan_Z = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, bool>(RemoteBcrServiceStub.n_Scan_Z));
            }
            return cb_scan_Z;
        }

        private static Delegate GetSet_Ljava_lang_String_Handler()
        {
            if (cb_set_Ljava_lang_String_ == null)
            {
                cb_set_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(RemoteBcrServiceStub.n_Set_Ljava_lang_String_));
            }
            return cb_set_Ljava_lang_String_;
        }

        private static Delegate GetStartSettingsActivityHandler()
        {
            if (cb_startSettingsActivity == null)
            {
                cb_startSettingsActivity = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr>(RemoteBcrServiceStub.n_StartSettingsActivity));
            }
            return cb_startSettingsActivity;
        }

        private static void n_AddListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            RemoteBcrServiceStub stub = Object.GetObject<RemoteBcrServiceStub>(jnienv, native__this, 0);
            IRemoteBcrListener listener = Object.GetObject<IRemoteBcrListener>(native_p0, 0);
            stub.AddListener(listener);
        }

        private static IntPtr n_AsBinder(IntPtr jnienv, IntPtr native__this)
        {
            return JNIEnv.ToLocalJniHandle(Object.GetObject<RemoteBcrServiceStub>(jnienv, native__this, 0).AsBinder());
        }

        private static IntPtr n_Get_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            RemoteBcrServiceStub stub = Object.GetObject<RemoteBcrServiceStub>(jnienv, native__this, 0);
            string str = JNIEnv.GetString(native_p0, 0);
            return JNIEnv.NewString(stub.Get(str));
        }

        private static int n_GetStatus(IntPtr jnienv, IntPtr native__this)
        {
            return Object.GetObject<RemoteBcrServiceStub>(jnienv, native__this, 0).Status;
        }

        private static bool n_IsReady(IntPtr jnienv, IntPtr native__this)
        {
            return Object.GetObject<RemoteBcrServiceStub>(jnienv, native__this, 0).IsReady;
        }

        private static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
        {
            RemoteBcrServiceStub stub = Object.GetObject<RemoteBcrServiceStub>(jnienv, native__this, 0);
            Parcel parcel = Object.GetObject<Parcel>(native_p1, 0);
            Parcel parcel2 = Object.GetObject<Parcel>(native_p2, 0);
            return stub.OnTransact(p0, parcel, parcel2, p3);
        }

        private static void n_RemoveListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            RemoteBcrServiceStub stub = Object.GetObject<RemoteBcrServiceStub>(jnienv, native__this, 0);
            IRemoteBcrListener listener = Object.GetObject<IRemoteBcrListener>(native_p0, 0);
            stub.RemoveListener(listener);
        }

        private static void n_Save(IntPtr jnienv, IntPtr native__this)
        {
            Object.GetObject<RemoteBcrServiceStub>(jnienv, native__this, 0).Save();
        }

        private static void n_Scan_Z(IntPtr jnienv, IntPtr native__this, bool p0)
        {
            Object.GetObject<RemoteBcrServiceStub>(jnienv, native__this, 0).Scan(p0);
        }

        private static void n_Set_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            RemoteBcrServiceStub stub = Object.GetObject<RemoteBcrServiceStub>(jnienv, native__this, 0);
            string str = JNIEnv.GetString(native_p0, 0);
            stub.Set(str);
        }

        private static void n_StartSettingsActivity(IntPtr jnienv, IntPtr native__this)
        {
            Object.GetObject<RemoteBcrServiceStub>(jnienv, native__this, 0).StartSettingsActivity();
        }

        [Register("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
        public virtual unsafe bool OnTransact(int p0, Parcel p1, Parcel p2, int p3)
        {
            if (id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == IntPtr.Zero)
            {
                id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID(class_ref, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
            }
            try
            {
                bool flag2;
                JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 4) * sizeof(JValue))];
                valuePtr[0] = new JValue(p0);
                valuePtr[1] = new JValue(p1);
                valuePtr[2] = new JValue(p2);
                valuePtr[3] = new JValue(p3);
                if (base.GetType() == this.get_ThresholdType())
                {
                    flag2 = JNIEnv.CallBooleanMethod(base.get_Handle(), id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I, valuePtr);
                }
                else
                {
                    flag2 = JNIEnv.CallNonvirtualBooleanMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z"), valuePtr);
                }
                return flag2;
            }
            finally
            {
            }
        }

        [Register("removeListener", "(Lcom/mitac/cell/device/bcr/IRemoteBcrListener;)V", "GetRemoveListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_Handler")]
        public abstract void RemoveListener(IRemoteBcrListener p0);
        [Register("save", "()V", "GetSaveHandler")]
        public abstract void Save();
        [Register("scan", "(Z)V", "GetScan_ZHandler")]
        public abstract void Scan(bool p0);
        [Register("set", "(Ljava/lang/String;)V", "GetSet_Ljava_lang_String_Handler")]
        public abstract void Set(string p0);
        [Register("startSettingsActivity", "()V", "GetStartSettingsActivityHandler")]
        public abstract void StartSettingsActivity();

        internal static IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/mitac/cell/device/bcr/IRemoteBcrService$Stub", ref java_class_handle);
            }
        }

        public abstract bool IsReady { [Register("isReady", "()Z", "GetIsReadyHandler")] get; }

        public abstract int Status { [Register("getStatus", "()I", "GetGetStatusHandler")] get; }

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
                return typeof(RemoteBcrServiceStub);
            }
        }

        [Register("com/mitac/cell/device/bcr/IRemoteBcrService$Stub$Proxy", DoNotGenerateAcw=true)]
        public class Proxy : Object, IRemoteBcrService, IInterface, IJavaObject, IDisposable
        {
            private static Delegate cb_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
            private static Delegate cb_asBinder;
            private static Delegate cb_get_Ljava_lang_String_;
            private static Delegate cb_getInterfaceDescriptor;
            private static Delegate cb_getStatus;
            private static Delegate cb_isReady;
            private static Delegate cb_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
            private static Delegate cb_save;
            private static Delegate cb_scan_Z;
            private static Delegate cb_set_Ljava_lang_String_;
            private static Delegate cb_startSettingsActivity;
            private static IntPtr id_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
            private static IntPtr id_asBinder;
            private static IntPtr id_get_Ljava_lang_String_;
            private static IntPtr id_getInterfaceDescriptor;
            private static IntPtr id_getStatus;
            private static IntPtr id_isReady;
            private static IntPtr id_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
            private static IntPtr id_save;
            private static IntPtr id_scan_Z;
            private static IntPtr id_set_Ljava_lang_String_;
            private static IntPtr id_startSettingsActivity;
            internal static IntPtr java_class_handle;

            protected Proxy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
            {
            }

            [Register("addListener", "(Lcom/mitac/cell/device/bcr/IRemoteBcrListener;)V", "GetAddListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_Handler")]
            public virtual unsafe void AddListener(IRemoteBcrListener p0)
            {
                if (id_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ == IntPtr.Zero)
                {
                    id_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ = JNIEnv.GetMethodID(class_ref, "addListener", "(Lcom/mitac/cell/device/bcr/IRemoteBcrListener;)V");
                }
                try
                {
                    JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                    valuePtr[0] = new JValue(p0);
                    if (base.GetType() == this.get_ThresholdType())
                    {
                        JNIEnv.CallVoidMethod(base.get_Handle(), id_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_, valuePtr);
                    }
                    else
                    {
                        JNIEnv.CallNonvirtualVoidMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "addListener", "(Lcom/mitac/cell/device/bcr/IRemoteBcrListener;)V"), valuePtr);
                    }
                }
                finally
                {
                }
            }

            [Register("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
            public virtual IBinder AsBinder()
            {
                if (id_asBinder == IntPtr.Zero)
                {
                    id_asBinder = JNIEnv.GetMethodID(class_ref, "asBinder", "()Landroid/os/IBinder;");
                }
                try
                {
                    if (base.GetType() == this.get_ThresholdType())
                    {
                        return Object.GetObject<IBinder>(JNIEnv.CallObjectMethod(base.get_Handle(), id_asBinder), 1);
                    }
                    return Object.GetObject<IBinder>(JNIEnv.CallNonvirtualObjectMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "asBinder", "()Landroid/os/IBinder;")), 1);
                }
                finally
                {
                }
            }

            [Register("get", "(Ljava/lang/String;)Ljava/lang/String;", "GetGet_Ljava_lang_String_Handler")]
            public virtual unsafe string Get(string p0)
            {
                string str2;
                if (id_get_Ljava_lang_String_ == IntPtr.Zero)
                {
                    id_get_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "get", "(Ljava/lang/String;)Ljava/lang/String;");
                }
                IntPtr ptr = JNIEnv.NewString(p0);
                try
                {
                    string str;
                    JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                    valuePtr[0] = new JValue(ptr);
                    if (base.GetType() == this.get_ThresholdType())
                    {
                        str = JNIEnv.GetString(JNIEnv.CallObjectMethod(base.get_Handle(), id_get_Ljava_lang_String_, valuePtr), 1);
                    }
                    else
                    {
                        str = JNIEnv.GetString(JNIEnv.CallNonvirtualObjectMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "get", "(Ljava/lang/String;)Ljava/lang/String;"), valuePtr), 1);
                    }
                    str2 = str;
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(ptr);
                }
                return str2;
            }

            private static Delegate GetAddListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_Handler()
            {
                if (cb_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ == null)
                {
                    cb_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(RemoteBcrServiceStub.Proxy.n_AddListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_));
                }
                return cb_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
            }

            private static Delegate GetAsBinderHandler()
            {
                if (cb_asBinder == null)
                {
                    cb_asBinder = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(RemoteBcrServiceStub.Proxy.n_AsBinder));
                }
                return cb_asBinder;
            }

            private static Delegate GetGet_Ljava_lang_String_Handler()
            {
                if (cb_get_Ljava_lang_String_ == null)
                {
                    cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr, IntPtr>(RemoteBcrServiceStub.Proxy.n_Get_Ljava_lang_String_));
                }
                return cb_get_Ljava_lang_String_;
            }

            private static Delegate GetGetInterfaceDescriptorHandler()
            {
                if (cb_getInterfaceDescriptor == null)
                {
                    cb_getInterfaceDescriptor = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(RemoteBcrServiceStub.Proxy.n_GetInterfaceDescriptor));
                }
                return cb_getInterfaceDescriptor;
            }

            private static Delegate GetGetStatusHandler()
            {
                if (cb_getStatus == null)
                {
                    cb_getStatus = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int>(RemoteBcrServiceStub.Proxy.n_GetStatus));
                }
                return cb_getStatus;
            }

            private static Delegate GetIsReadyHandler()
            {
                if (cb_isReady == null)
                {
                    cb_isReady = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, bool>(RemoteBcrServiceStub.Proxy.n_IsReady));
                }
                return cb_isReady;
            }

            private static Delegate GetRemoveListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_Handler()
            {
                if (cb_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ == null)
                {
                    cb_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(RemoteBcrServiceStub.Proxy.n_RemoveListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_));
                }
                return cb_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
            }

            private static Delegate GetSaveHandler()
            {
                if (cb_save == null)
                {
                    cb_save = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr>(RemoteBcrServiceStub.Proxy.n_Save));
                }
                return cb_save;
            }

            private static Delegate GetScan_ZHandler()
            {
                if (cb_scan_Z == null)
                {
                    cb_scan_Z = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, bool>(RemoteBcrServiceStub.Proxy.n_Scan_Z));
                }
                return cb_scan_Z;
            }

            private static Delegate GetSet_Ljava_lang_String_Handler()
            {
                if (cb_set_Ljava_lang_String_ == null)
                {
                    cb_set_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(RemoteBcrServiceStub.Proxy.n_Set_Ljava_lang_String_));
                }
                return cb_set_Ljava_lang_String_;
            }

            private static Delegate GetStartSettingsActivityHandler()
            {
                if (cb_startSettingsActivity == null)
                {
                    cb_startSettingsActivity = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr>(RemoteBcrServiceStub.Proxy.n_StartSettingsActivity));
                }
                return cb_startSettingsActivity;
            }

            private static void n_AddListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                RemoteBcrServiceStub.Proxy proxy = Object.GetObject<RemoteBcrServiceStub.Proxy>(jnienv, native__this, 0);
                IRemoteBcrListener listener = Object.GetObject<IRemoteBcrListener>(native_p0, 0);
                proxy.AddListener(listener);
            }

            private static IntPtr n_AsBinder(IntPtr jnienv, IntPtr native__this)
            {
                return JNIEnv.ToLocalJniHandle(Object.GetObject<RemoteBcrServiceStub.Proxy>(jnienv, native__this, 0).AsBinder());
            }

            private static IntPtr n_Get_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                RemoteBcrServiceStub.Proxy proxy = Object.GetObject<RemoteBcrServiceStub.Proxy>(jnienv, native__this, 0);
                string str = JNIEnv.GetString(native_p0, 0);
                return JNIEnv.NewString(proxy.Get(str));
            }

            private static IntPtr n_GetInterfaceDescriptor(IntPtr jnienv, IntPtr native__this)
            {
                return JNIEnv.NewString(Object.GetObject<RemoteBcrServiceStub.Proxy>(jnienv, native__this, 0).InterfaceDescriptor);
            }

            private static int n_GetStatus(IntPtr jnienv, IntPtr native__this)
            {
                return Object.GetObject<RemoteBcrServiceStub.Proxy>(jnienv, native__this, 0).Status;
            }

            private static bool n_IsReady(IntPtr jnienv, IntPtr native__this)
            {
                return Object.GetObject<RemoteBcrServiceStub.Proxy>(jnienv, native__this, 0).IsReady;
            }

            private static void n_RemoveListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                RemoteBcrServiceStub.Proxy proxy = Object.GetObject<RemoteBcrServiceStub.Proxy>(jnienv, native__this, 0);
                IRemoteBcrListener listener = Object.GetObject<IRemoteBcrListener>(native_p0, 0);
                proxy.RemoveListener(listener);
            }

            private static void n_Save(IntPtr jnienv, IntPtr native__this)
            {
                Object.GetObject<RemoteBcrServiceStub.Proxy>(jnienv, native__this, 0).Save();
            }

            private static void n_Scan_Z(IntPtr jnienv, IntPtr native__this, bool p0)
            {
                Object.GetObject<RemoteBcrServiceStub.Proxy>(jnienv, native__this, 0).Scan(p0);
            }

            private static void n_Set_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                RemoteBcrServiceStub.Proxy proxy = Object.GetObject<RemoteBcrServiceStub.Proxy>(jnienv, native__this, 0);
                string str = JNIEnv.GetString(native_p0, 0);
                proxy.Set(str);
            }

            private static void n_StartSettingsActivity(IntPtr jnienv, IntPtr native__this)
            {
                Object.GetObject<RemoteBcrServiceStub.Proxy>(jnienv, native__this, 0).StartSettingsActivity();
            }

            [Register("removeListener", "(Lcom/mitac/cell/device/bcr/IRemoteBcrListener;)V", "GetRemoveListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_Handler")]
            public virtual unsafe void RemoveListener(IRemoteBcrListener p0)
            {
                if (id_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ == IntPtr.Zero)
                {
                    id_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ = JNIEnv.GetMethodID(class_ref, "removeListener", "(Lcom/mitac/cell/device/bcr/IRemoteBcrListener;)V");
                }
                try
                {
                    JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                    valuePtr[0] = new JValue(p0);
                    if (base.GetType() == this.get_ThresholdType())
                    {
                        JNIEnv.CallVoidMethod(base.get_Handle(), id_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_, valuePtr);
                    }
                    else
                    {
                        JNIEnv.CallNonvirtualVoidMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "removeListener", "(Lcom/mitac/cell/device/bcr/IRemoteBcrListener;)V"), valuePtr);
                    }
                }
                finally
                {
                }
            }

            [Register("save", "()V", "GetSaveHandler")]
            public virtual void Save()
            {
                if (id_save == IntPtr.Zero)
                {
                    id_save = JNIEnv.GetMethodID(class_ref, "save", "()V");
                }
                try
                {
                    if (base.GetType() == this.get_ThresholdType())
                    {
                        JNIEnv.CallVoidMethod(base.get_Handle(), id_save);
                    }
                    else
                    {
                        JNIEnv.CallNonvirtualVoidMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "save", "()V"));
                    }
                }
                finally
                {
                }
            }

            [Register("scan", "(Z)V", "GetScan_ZHandler")]
            public virtual unsafe void Scan(bool p0)
            {
                if (id_scan_Z == IntPtr.Zero)
                {
                    id_scan_Z = JNIEnv.GetMethodID(class_ref, "scan", "(Z)V");
                }
                try
                {
                    JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                    valuePtr[0] = new JValue(p0);
                    if (base.GetType() == this.get_ThresholdType())
                    {
                        JNIEnv.CallVoidMethod(base.get_Handle(), id_scan_Z, valuePtr);
                    }
                    else
                    {
                        JNIEnv.CallNonvirtualVoidMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "scan", "(Z)V"), valuePtr);
                    }
                }
                finally
                {
                }
            }

            [Register("set", "(Ljava/lang/String;)V", "GetSet_Ljava_lang_String_Handler")]
            public virtual unsafe void Set(string p0)
            {
                if (id_set_Ljava_lang_String_ == IntPtr.Zero)
                {
                    id_set_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "set", "(Ljava/lang/String;)V");
                }
                IntPtr ptr = JNIEnv.NewString(p0);
                try
                {
                    JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                    valuePtr[0] = new JValue(ptr);
                    if (base.GetType() == this.get_ThresholdType())
                    {
                        JNIEnv.CallVoidMethod(base.get_Handle(), id_set_Ljava_lang_String_, valuePtr);
                    }
                    else
                    {
                        JNIEnv.CallNonvirtualVoidMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "set", "(Ljava/lang/String;)V"), valuePtr);
                    }
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(ptr);
                }
            }

            [Register("startSettingsActivity", "()V", "GetStartSettingsActivityHandler")]
            public virtual void StartSettingsActivity()
            {
                if (id_startSettingsActivity == IntPtr.Zero)
                {
                    id_startSettingsActivity = JNIEnv.GetMethodID(class_ref, "startSettingsActivity", "()V");
                }
                try
                {
                    if (base.GetType() == this.get_ThresholdType())
                    {
                        JNIEnv.CallVoidMethod(base.get_Handle(), id_startSettingsActivity);
                    }
                    else
                    {
                        JNIEnv.CallNonvirtualVoidMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "startSettingsActivity", "()V"));
                    }
                }
                finally
                {
                }
            }

            internal static IntPtr class_ref
            {
                get
                {
                    return JNIEnv.FindClass("com/mitac/cell/device/bcr/IRemoteBcrService$Stub$Proxy", ref java_class_handle);
                }
            }

            public virtual string InterfaceDescriptor
            {
                [Register("getInterfaceDescriptor", "()Ljava/lang/String;", "GetGetInterfaceDescriptorHandler")]
                get
                {
                    if (id_getInterfaceDescriptor == IntPtr.Zero)
                    {
                        id_getInterfaceDescriptor = JNIEnv.GetMethodID(class_ref, "getInterfaceDescriptor", "()Ljava/lang/String;");
                    }
                    try
                    {
                        if (base.GetType() == this.get_ThresholdType())
                        {
                            return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.get_Handle(), id_getInterfaceDescriptor), 1);
                        }
                        return JNIEnv.GetString(JNIEnv.CallNonvirtualObjectMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "getInterfaceDescriptor", "()Ljava/lang/String;")), 1);
                    }
                    finally
                    {
                    }
                }
            }

            public virtual bool IsReady
            {
                [Register("isReady", "()Z", "GetIsReadyHandler")]
                get
                {
                    if (id_isReady == IntPtr.Zero)
                    {
                        id_isReady = JNIEnv.GetMethodID(class_ref, "isReady", "()Z");
                    }
                    try
                    {
                        if (base.GetType() == this.get_ThresholdType())
                        {
                            return JNIEnv.CallBooleanMethod(base.get_Handle(), id_isReady);
                        }
                        return JNIEnv.CallNonvirtualBooleanMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "isReady", "()Z"));
                    }
                    finally
                    {
                    }
                }
            }

            public virtual int Status
            {
                [Register("getStatus", "()I", "GetGetStatusHandler")]
                get
                {
                    if (id_getStatus == IntPtr.Zero)
                    {
                        id_getStatus = JNIEnv.GetMethodID(class_ref, "getStatus", "()I");
                    }
                    try
                    {
                        if (base.GetType() == this.get_ThresholdType())
                        {
                            return JNIEnv.CallIntMethod(base.get_Handle(), id_getStatus);
                        }
                        return JNIEnv.CallNonvirtualIntMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "getStatus", "()I"));
                    }
                    finally
                    {
                    }
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
                    return typeof(RemoteBcrServiceStub.Proxy);
                }
            }
        }
    }
}

