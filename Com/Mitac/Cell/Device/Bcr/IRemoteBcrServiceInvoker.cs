namespace Com.Mitac.Cell.Device.Bcr
{
    using Android.OS;
    using Android.Runtime;
    using Java.Lang;
    using System;

    [Register("com/mitac/cell/device/bcr/IRemoteBcrService", DoNotGenerateAcw=true)]
    internal class IRemoteBcrServiceInvoker : Object, IRemoteBcrService, IInterface, IJavaObject, IDisposable
    {
        private static Delegate cb_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
        private static Delegate cb_asBinder;
        private static Delegate cb_get_Ljava_lang_String_;
        private static Delegate cb_getStatus;
        private static Delegate cb_isReady;
        private static Delegate cb_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
        private static Delegate cb_save;
        private static Delegate cb_scan_Z;
        private static Delegate cb_set_Ljava_lang_String_;
        private static Delegate cb_startSettingsActivity;
        private IntPtr class_ref;
        private IntPtr id_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
        private IntPtr id_asBinder;
        private IntPtr id_get_Ljava_lang_String_;
        private IntPtr id_getStatus;
        private IntPtr id_isReady;
        private IntPtr id_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
        private IntPtr id_save;
        private IntPtr id_scan_Z;
        private IntPtr id_set_Ljava_lang_String_;
        private IntPtr id_startSettingsActivity;
        private static IntPtr java_class_ref = JNIEnv.FindClass("com/mitac/cell/device/bcr/IRemoteBcrService");

        public IRemoteBcrServiceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
        {
            IntPtr objectClass = JNIEnv.GetObjectClass(base.get_Handle());
            this.class_ref = JNIEnv.NewGlobalRef(objectClass);
            JNIEnv.DeleteLocalRef(objectClass);
        }

        public unsafe void AddListener(IRemoteBcrListener p0)
        {
            if (this.id_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ == IntPtr.Zero)
            {
                this.id_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ = JNIEnv.GetMethodID(this.class_ref, "addListener", "(Lcom/mitac/cell/device/bcr/IRemoteBcrListener;)V");
            }
            JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
            valuePtr[0] = new JValue(p0);
            JNIEnv.CallVoidMethod(base.get_Handle(), this.id_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_, valuePtr);
        }

        public IBinder AsBinder()
        {
            if (this.id_asBinder == IntPtr.Zero)
            {
                this.id_asBinder = JNIEnv.GetMethodID(this.class_ref, "asBinder", "()Landroid/os/IBinder;");
            }
            return Object.GetObject<IBinder>(JNIEnv.CallObjectMethod(base.get_Handle(), this.id_asBinder), 1);
        }

        protected override void Dispose(bool disposing)
        {
            if (this.class_ref != IntPtr.Zero)
            {
                JNIEnv.DeleteGlobalRef(this.class_ref);
            }
            this.class_ref = IntPtr.Zero;
            base.Dispose(disposing);
        }

        public unsafe string Get(string p0)
        {
            if (this.id_get_Ljava_lang_String_ == IntPtr.Zero)
            {
                this.id_get_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "get", "(Ljava/lang/String;)Ljava/lang/String;");
            }
            IntPtr ptr = JNIEnv.NewString(p0);
            JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
            valuePtr[0] = new JValue(ptr);
            string str = JNIEnv.GetString(JNIEnv.CallObjectMethod(base.get_Handle(), this.id_get_Ljava_lang_String_, valuePtr), 1);
            JNIEnv.DeleteLocalRef(ptr);
            return str;
        }

        private static Delegate GetAddListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_Handler()
        {
            if (cb_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ == null)
            {
                cb_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(IRemoteBcrServiceInvoker.n_AddListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_));
            }
            return cb_addListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
        }

        private static Delegate GetAsBinderHandler()
        {
            if (cb_asBinder == null)
            {
                cb_asBinder = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(IRemoteBcrServiceInvoker.n_AsBinder));
            }
            return cb_asBinder;
        }

        private static Delegate GetGet_Ljava_lang_String_Handler()
        {
            if (cb_get_Ljava_lang_String_ == null)
            {
                cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr, IntPtr>(IRemoteBcrServiceInvoker.n_Get_Ljava_lang_String_));
            }
            return cb_get_Ljava_lang_String_;
        }

        private static Delegate GetGetStatusHandler()
        {
            if (cb_getStatus == null)
            {
                cb_getStatus = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int>(IRemoteBcrServiceInvoker.n_GetStatus));
            }
            return cb_getStatus;
        }

        private static Delegate GetIsReadyHandler()
        {
            if (cb_isReady == null)
            {
                cb_isReady = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, bool>(IRemoteBcrServiceInvoker.n_IsReady));
            }
            return cb_isReady;
        }

        public static IRemoteBcrService GetObject(IntPtr handle, JniHandleOwnership transfer)
        {
            return Object.GetObject<IRemoteBcrService>(handle, transfer);
        }

        private static Delegate GetRemoveListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_Handler()
        {
            if (cb_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ == null)
            {
                cb_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(IRemoteBcrServiceInvoker.n_RemoveListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_));
            }
            return cb_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_;
        }

        private static Delegate GetSaveHandler()
        {
            if (cb_save == null)
            {
                cb_save = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr>(IRemoteBcrServiceInvoker.n_Save));
            }
            return cb_save;
        }

        private static Delegate GetScan_ZHandler()
        {
            if (cb_scan_Z == null)
            {
                cb_scan_Z = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, bool>(IRemoteBcrServiceInvoker.n_Scan_Z));
            }
            return cb_scan_Z;
        }

        private static Delegate GetSet_Ljava_lang_String_Handler()
        {
            if (cb_set_Ljava_lang_String_ == null)
            {
                cb_set_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(IRemoteBcrServiceInvoker.n_Set_Ljava_lang_String_));
            }
            return cb_set_Ljava_lang_String_;
        }

        private static Delegate GetStartSettingsActivityHandler()
        {
            if (cb_startSettingsActivity == null)
            {
                cb_startSettingsActivity = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr>(IRemoteBcrServiceInvoker.n_StartSettingsActivity));
            }
            return cb_startSettingsActivity;
        }

        private static void n_AddListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            IRemoteBcrService service = Object.GetObject<IRemoteBcrService>(jnienv, native__this, 0);
            IRemoteBcrListener listener = Object.GetObject<IRemoteBcrListener>(native_p0, 0);
            service.AddListener(listener);
        }

        private static IntPtr n_AsBinder(IntPtr jnienv, IntPtr native__this)
        {
            return JNIEnv.ToLocalJniHandle(Object.GetObject<IRemoteBcrService>(jnienv, native__this, 0).AsBinder());
        }

        private static IntPtr n_Get_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            IRemoteBcrService service = Object.GetObject<IRemoteBcrService>(jnienv, native__this, 0);
            string str = JNIEnv.GetString(native_p0, 0);
            return JNIEnv.NewString(service.Get(str));
        }

        private static int n_GetStatus(IntPtr jnienv, IntPtr native__this)
        {
            return Object.GetObject<IRemoteBcrService>(jnienv, native__this, 0).Status;
        }

        private static bool n_IsReady(IntPtr jnienv, IntPtr native__this)
        {
            return Object.GetObject<IRemoteBcrService>(jnienv, native__this, 0).IsReady;
        }

        private static void n_RemoveListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            IRemoteBcrService service = Object.GetObject<IRemoteBcrService>(jnienv, native__this, 0);
            IRemoteBcrListener listener = Object.GetObject<IRemoteBcrListener>(native_p0, 0);
            service.RemoveListener(listener);
        }

        private static void n_Save(IntPtr jnienv, IntPtr native__this)
        {
            Object.GetObject<IRemoteBcrService>(jnienv, native__this, 0).Save();
        }

        private static void n_Scan_Z(IntPtr jnienv, IntPtr native__this, bool p0)
        {
            Object.GetObject<IRemoteBcrService>(jnienv, native__this, 0).Scan(p0);
        }

        private static void n_Set_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            IRemoteBcrService service = Object.GetObject<IRemoteBcrService>(jnienv, native__this, 0);
            string str = JNIEnv.GetString(native_p0, 0);
            service.Set(str);
        }

        private static void n_StartSettingsActivity(IntPtr jnienv, IntPtr native__this)
        {
            Object.GetObject<IRemoteBcrService>(jnienv, native__this, 0).StartSettingsActivity();
        }

        public unsafe void RemoveListener(IRemoteBcrListener p0)
        {
            if (this.id_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ == IntPtr.Zero)
            {
                this.id_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_ = JNIEnv.GetMethodID(this.class_ref, "removeListener", "(Lcom/mitac/cell/device/bcr/IRemoteBcrListener;)V");
            }
            JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
            valuePtr[0] = new JValue(p0);
            JNIEnv.CallVoidMethod(base.get_Handle(), this.id_removeListener_Lcom_mitac_cell_device_bcr_IRemoteBcrListener_, valuePtr);
        }

        public void Save()
        {
            if (this.id_save == IntPtr.Zero)
            {
                this.id_save = JNIEnv.GetMethodID(this.class_ref, "save", "()V");
            }
            JNIEnv.CallVoidMethod(base.get_Handle(), this.id_save);
        }

        public unsafe void Scan(bool p0)
        {
            if (this.id_scan_Z == IntPtr.Zero)
            {
                this.id_scan_Z = JNIEnv.GetMethodID(this.class_ref, "scan", "(Z)V");
            }
            JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
            valuePtr[0] = new JValue(p0);
            JNIEnv.CallVoidMethod(base.get_Handle(), this.id_scan_Z, valuePtr);
        }

        public unsafe void Set(string p0)
        {
            if (this.id_set_Ljava_lang_String_ == IntPtr.Zero)
            {
                this.id_set_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "set", "(Ljava/lang/String;)V");
            }
            IntPtr ptr = JNIEnv.NewString(p0);
            JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
            valuePtr[0] = new JValue(ptr);
            JNIEnv.CallVoidMethod(base.get_Handle(), this.id_set_Ljava_lang_String_, valuePtr);
            JNIEnv.DeleteLocalRef(ptr);
        }

        public void StartSettingsActivity()
        {
            if (this.id_startSettingsActivity == IntPtr.Zero)
            {
                this.id_startSettingsActivity = JNIEnv.GetMethodID(this.class_ref, "startSettingsActivity", "()V");
            }
            JNIEnv.CallVoidMethod(base.get_Handle(), this.id_startSettingsActivity);
        }

        private static IntPtr Validate(IntPtr handle)
        {
            if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
            {
                throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance(handle), "com.mitac.cell.device.bcr.IRemoteBcrService"));
            }
            return handle;
        }

        public bool IsReady
        {
            get
            {
                if (this.id_isReady == IntPtr.Zero)
                {
                    this.id_isReady = JNIEnv.GetMethodID(this.class_ref, "isReady", "()Z");
                }
                return JNIEnv.CallBooleanMethod(base.get_Handle(), this.id_isReady);
            }
        }

        public int Status
        {
            get
            {
                if (this.id_getStatus == IntPtr.Zero)
                {
                    this.id_getStatus = JNIEnv.GetMethodID(this.class_ref, "getStatus", "()I");
                }
                return JNIEnv.CallIntMethod(base.get_Handle(), this.id_getStatus);
            }
        }

        protected override IntPtr ThresholdClass
        {
            get
            {
                return this.class_ref;
            }
        }

        protected override Type ThresholdType
        {
            get
            {
                return typeof(IRemoteBcrServiceInvoker);
            }
        }
    }
}

