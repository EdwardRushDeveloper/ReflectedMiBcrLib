namespace Com.Lib.Bcr
{
    using Android.Content;
    using Android.OS;
    using Android.Runtime;
    using Java.Lang;
    using System;

    [Register("com/lib/bcr/McBcrConnection", DoNotGenerateAcw=true)]
    public class McBcrConnection : Object, IServiceConnection, IJavaObject, IDisposable
    {
        private static Delegate cb_bind;
        private static Delegate cb_get_Ljava_lang_String_;
        private static Delegate cb_isReady;
        private static Delegate cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
        private static Delegate cb_onServiceDisconnected_Landroid_content_ComponentName_;
        private static Delegate cb_onStatusChanged_I;
        private static Delegate cb_save;
        private static Delegate cb_scan_Z;
        private static Delegate cb_set_Ljava_lang_String_;
        private static Delegate cb_setListener_Lcom_lib_bcr_MiBcrListener_;
        private static Delegate cb_startSettingsActivity;
        private static Delegate cb_status;
        private static Delegate cb_unbind;
        private static IntPtr id_bind;
        private static IntPtr id_ctor_Landroid_content_Context_;
        private static IntPtr id_get_Ljava_lang_String_;
        private static IntPtr id_isReady;
        private static IntPtr id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
        private static IntPtr id_onServiceDisconnected_Landroid_content_ComponentName_;
        private static IntPtr id_onStatusChanged_I;
        private static IntPtr id_save;
        private static IntPtr id_scan_Z;
        private static IntPtr id_set_Ljava_lang_String_;
        private static IntPtr id_setListener_Lcom_lib_bcr_MiBcrListener_;
        private static IntPtr id_startSettingsActivity;
        private static IntPtr id_status;
        private static IntPtr id_unbind;
        internal static IntPtr java_class_handle;

        [Register(".ctor", "(Landroid/content/Context;)V", "")]
        public unsafe McBcrConnection(Context p0) : base(IntPtr.Zero, 0)
        {
            if (base.get_Handle() == IntPtr.Zero)
            {
                try
                {
                    JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                    valuePtr[0] = new JValue(p0);
                    if (base.GetType() != typeof(McBcrConnection))
                    {
                        base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "(Landroid/content/Context;)V", valuePtr), 1);
                        JNIEnv.FinishCreateInstance(base.get_Handle(), "(Landroid/content/Context;)V", valuePtr);
                    }
                    else
                    {
                        if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
                        {
                            id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID(class_ref, "<init>", "(Landroid/content/Context;)V");
                        }
                        base.SetHandle(JNIEnv.StartCreateInstance(class_ref, id_ctor_Landroid_content_Context_, valuePtr), 1);
                        JNIEnv.FinishCreateInstance(base.get_Handle(), class_ref, id_ctor_Landroid_content_Context_, valuePtr);
                    }
                }
                finally
                {
                }
            }
        }

        protected McBcrConnection(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        private IMiBcrListenerImplementor __CreateIMiBcrListenerImplementor()
        {
            return new IMiBcrListenerImplementor(this);
        }

        [Register("bind", "()V", "GetBindHandler")]
        public virtual void Bind()
        {
            if (id_bind == IntPtr.Zero)
            {
                id_bind = JNIEnv.GetMethodID(class_ref, "bind", "()V");
            }
            try
            {
                if (base.GetType() == this.get_ThresholdType())
                {
                    JNIEnv.CallVoidMethod(base.get_Handle(), id_bind);
                }
                else
                {
                    JNIEnv.CallNonvirtualVoidMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "bind", "()V"));
                }
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

        private static Delegate GetBindHandler()
        {
            if (cb_bind == null)
            {
                cb_bind = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr>(McBcrConnection.n_Bind));
            }
            return cb_bind;
        }

        private static Delegate GetGet_Ljava_lang_String_Handler()
        {
            if (cb_get_Ljava_lang_String_ == null)
            {
                cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr, IntPtr>(McBcrConnection.n_Get_Ljava_lang_String_));
            }
            return cb_get_Ljava_lang_String_;
        }

        private static Delegate GetIsReadyHandler()
        {
            if (cb_isReady == null)
            {
                cb_isReady = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, bool>(McBcrConnection.n_IsReady));
            }
            return cb_isReady;
        }

        private static Delegate GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler()
        {
            if (cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ == null)
            {
                cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(McBcrConnection.n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_));
            }
            return cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
        }

        private static Delegate GetOnServiceDisconnected_Landroid_content_ComponentName_Handler()
        {
            if (cb_onServiceDisconnected_Landroid_content_ComponentName_ == null)
            {
                cb_onServiceDisconnected_Landroid_content_ComponentName_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(McBcrConnection.n_OnServiceDisconnected_Landroid_content_ComponentName_));
            }
            return cb_onServiceDisconnected_Landroid_content_ComponentName_;
        }

        private static Delegate GetOnStatusChanged_IHandler()
        {
            if (cb_onStatusChanged_I == null)
            {
                cb_onStatusChanged_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, int>(McBcrConnection.n_OnStatusChanged_I));
            }
            return cb_onStatusChanged_I;
        }

        private static Delegate GetSaveHandler()
        {
            if (cb_save == null)
            {
                cb_save = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr>(McBcrConnection.n_Save));
            }
            return cb_save;
        }

        private static Delegate GetScan_ZHandler()
        {
            if (cb_scan_Z == null)
            {
                cb_scan_Z = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, bool>(McBcrConnection.n_Scan_Z));
            }
            return cb_scan_Z;
        }

        private static Delegate GetSet_Ljava_lang_String_Handler()
        {
            if (cb_set_Ljava_lang_String_ == null)
            {
                cb_set_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(McBcrConnection.n_Set_Ljava_lang_String_));
            }
            return cb_set_Ljava_lang_String_;
        }

        private static Delegate GetSetListener_Lcom_lib_bcr_MiBcrListener_Handler()
        {
            if (cb_setListener_Lcom_lib_bcr_MiBcrListener_ == null)
            {
                cb_setListener_Lcom_lib_bcr_MiBcrListener_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(McBcrConnection.n_SetListener_Lcom_lib_bcr_MiBcrListener_));
            }
            return cb_setListener_Lcom_lib_bcr_MiBcrListener_;
        }

        private static Delegate GetStartSettingsActivityHandler()
        {
            if (cb_startSettingsActivity == null)
            {
                cb_startSettingsActivity = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr>(McBcrConnection.n_StartSettingsActivity));
            }
            return cb_startSettingsActivity;
        }

        private static Delegate GetStatusHandler()
        {
            if (cb_status == null)
            {
                cb_status = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int>(McBcrConnection.n_Status));
            }
            return cb_status;
        }

        private static Delegate GetUnbindHandler()
        {
            if (cb_unbind == null)
            {
                cb_unbind = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr>(McBcrConnection.n_Unbind));
            }
            return cb_unbind;
        }

        private static void n_Bind(IntPtr jnienv, IntPtr native__this)
        {
            Object.GetObject<McBcrConnection>(jnienv, native__this, 0).Bind();
        }

        private static IntPtr n_Get_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            McBcrConnection connection = Object.GetObject<McBcrConnection>(jnienv, native__this, 0);
            string str = JNIEnv.GetString(native_p0, 0);
            return JNIEnv.NewString(connection.Get(str));
        }

        private static bool n_IsReady(IntPtr jnienv, IntPtr native__this)
        {
            return Object.GetObject<McBcrConnection>(jnienv, native__this, 0).IsReady;
        }

        private static void n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
        {
            McBcrConnection connection = Object.GetObject<McBcrConnection>(jnienv, native__this, 0);
            ComponentName name = Object.GetObject<ComponentName>(native_p0, 0);
            IBinder binder = Object.GetObject<IBinder>(native_p1, 0);
            connection.OnServiceConnected(name, binder);
        }

        private static void n_OnServiceDisconnected_Landroid_content_ComponentName_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            McBcrConnection connection = Object.GetObject<McBcrConnection>(jnienv, native__this, 0);
            ComponentName name = Object.GetObject<ComponentName>(native_p0, 0);
            connection.OnServiceDisconnected(name);
        }

        private static void n_OnStatusChanged_I(IntPtr jnienv, IntPtr native__this, int p0)
        {
            Object.GetObject<McBcrConnection>(jnienv, native__this, 0).OnStatusChanged(p0);
        }

        private static void n_Save(IntPtr jnienv, IntPtr native__this)
        {
            Object.GetObject<McBcrConnection>(jnienv, native__this, 0).Save();
        }

        private static void n_Scan_Z(IntPtr jnienv, IntPtr native__this, bool p0)
        {
            Object.GetObject<McBcrConnection>(jnienv, native__this, 0).Scan(p0);
        }

        private static void n_Set_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            McBcrConnection connection = Object.GetObject<McBcrConnection>(jnienv, native__this, 0);
            string str = JNIEnv.GetString(native_p0, 0);
            connection.Set(str);
        }

        private static void n_SetListener_Lcom_lib_bcr_MiBcrListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            McBcrConnection connection = Object.GetObject<McBcrConnection>(jnienv, native__this, 0);
            IMiBcrListener listener = Object.GetObject<IMiBcrListener>(native_p0, 0);
            connection.SetListener(listener);
        }

        private static void n_StartSettingsActivity(IntPtr jnienv, IntPtr native__this)
        {
            Object.GetObject<McBcrConnection>(jnienv, native__this, 0).StartSettingsActivity();
        }

        private static int n_Status(IntPtr jnienv, IntPtr native__this)
        {
            return Object.GetObject<McBcrConnection>(jnienv, native__this, 0).Status();
        }

        private static void n_Unbind(IntPtr jnienv, IntPtr native__this)
        {
            Object.GetObject<McBcrConnection>(jnienv, native__this, 0).Unbind();
        }

        [Register("onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V", "GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler")]
        public virtual unsafe void OnServiceConnected(ComponentName p0, IBinder p1)
        {
            if (id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ == IntPtr.Zero)
            {
                id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ = JNIEnv.GetMethodID(class_ref, "onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V");
            }
            try
            {
                JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 2) * sizeof(JValue))];
                valuePtr[0] = new JValue(p0);
                valuePtr[1] = new JValue(p1);
                if (base.GetType() == this.get_ThresholdType())
                {
                    JNIEnv.CallVoidMethod(base.get_Handle(), id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_, valuePtr);
                }
                else
                {
                    JNIEnv.CallNonvirtualVoidMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V"), valuePtr);
                }
            }
            finally
            {
            }
        }

        [Register("onServiceDisconnected", "(Landroid/content/ComponentName;)V", "GetOnServiceDisconnected_Landroid_content_ComponentName_Handler")]
        public virtual unsafe void OnServiceDisconnected(ComponentName p0)
        {
            if (id_onServiceDisconnected_Landroid_content_ComponentName_ == IntPtr.Zero)
            {
                id_onServiceDisconnected_Landroid_content_ComponentName_ = JNIEnv.GetMethodID(class_ref, "onServiceDisconnected", "(Landroid/content/ComponentName;)V");
            }
            try
            {
                JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                valuePtr[0] = new JValue(p0);
                if (base.GetType() == this.get_ThresholdType())
                {
                    JNIEnv.CallVoidMethod(base.get_Handle(), id_onServiceDisconnected_Landroid_content_ComponentName_, valuePtr);
                }
                else
                {
                    JNIEnv.CallNonvirtualVoidMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "onServiceDisconnected", "(Landroid/content/ComponentName;)V"), valuePtr);
                }
            }
            finally
            {
            }
        }

        [Register("onStatusChanged", "(I)V", "GetOnStatusChanged_IHandler")]
        public virtual unsafe void OnStatusChanged(int p0)
        {
            if (id_onStatusChanged_I == IntPtr.Zero)
            {
                id_onStatusChanged_I = JNIEnv.GetMethodID(class_ref, "onStatusChanged", "(I)V");
            }
            try
            {
                JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                valuePtr[0] = new JValue(p0);
                if (base.GetType() == this.get_ThresholdType())
                {
                    JNIEnv.CallVoidMethod(base.get_Handle(), id_onStatusChanged_I, valuePtr);
                }
                else
                {
                    JNIEnv.CallNonvirtualVoidMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "onStatusChanged", "(I)V"), valuePtr);
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

        [Register("setListener", "(Lcom/lib/bcr/MiBcrListener;)V", "GetSetListener_Lcom_lib_bcr_MiBcrListener_Handler")]
        public virtual unsafe void SetListener(IMiBcrListener p0)
        {
            if (id_setListener_Lcom_lib_bcr_MiBcrListener_ == IntPtr.Zero)
            {
                id_setListener_Lcom_lib_bcr_MiBcrListener_ = JNIEnv.GetMethodID(class_ref, "setListener", "(Lcom/lib/bcr/MiBcrListener;)V");
            }
            try
            {
                JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                valuePtr[0] = new JValue(p0);
                if (base.GetType() == this.get_ThresholdType())
                {
                    JNIEnv.CallVoidMethod(base.get_Handle(), id_setListener_Lcom_lib_bcr_MiBcrListener_, valuePtr);
                }
                else
                {
                    JNIEnv.CallNonvirtualVoidMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "setListener", "(Lcom/lib/bcr/MiBcrListener;)V"), valuePtr);
                }
            }
            finally
            {
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

        [Register("status", "()I", "GetStatusHandler")]
        public virtual int Status()
        {
            if (id_status == IntPtr.Zero)
            {
                id_status = JNIEnv.GetMethodID(class_ref, "status", "()I");
            }
            try
            {
                if (base.GetType() == this.get_ThresholdType())
                {
                    return JNIEnv.CallIntMethod(base.get_Handle(), id_status);
                }
                return JNIEnv.CallNonvirtualIntMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "status", "()I"));
            }
            finally
            {
            }
        }

        [Register("unbind", "()V", "GetUnbindHandler")]
        public virtual void Unbind()
        {
            if (id_unbind == IntPtr.Zero)
            {
                id_unbind = JNIEnv.GetMethodID(class_ref, "unbind", "()V");
            }
            try
            {
                if (base.GetType() == this.get_ThresholdType())
                {
                    JNIEnv.CallVoidMethod(base.get_Handle(), id_unbind);
                }
                else
                {
                    JNIEnv.CallNonvirtualVoidMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "unbind", "()V"));
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
                return JNIEnv.FindClass("com/lib/bcr/McBcrConnection", ref java_class_handle);
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
                return typeof(McBcrConnection);
            }
        }
    }
}

