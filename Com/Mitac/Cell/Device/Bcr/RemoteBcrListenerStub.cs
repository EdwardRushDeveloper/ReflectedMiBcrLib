namespace Com.Mitac.Cell.Device.Bcr
{
    using Android.OS;
    using Android.Runtime;
    using Java.Lang;
    using System;

    [Register("com/mitac/cell/device/bcr/IRemoteBcrListener$Stub", DoNotGenerateAcw=true)]
    public abstract class RemoteBcrListenerStub : Binder, IRemoteBcrListener, IInterface, IJavaObject, IDisposable
    {
        private static Delegate cb_asBinder;
        private static Delegate cb_onScanned_Ljava_lang_String_Ljava_lang_String_I;
        private static Delegate cb_onStatusChanged_I;
        private static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
        private static IntPtr id_asBinder;
        private static IntPtr id_asInterface_Landroid_os_IBinder_;
        private static IntPtr id_ctor;
        private static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
        internal static IntPtr java_class_handle;

        [Register(".ctor", "()V", "")]
        public RemoteBcrListenerStub() : base(IntPtr.Zero, 0)
        {
            if (base.get_Handle() == IntPtr.Zero)
            {
                try
                {
                    if (base.GetType() != typeof(RemoteBcrListenerStub))
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

        protected RemoteBcrListenerStub(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
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

        [Register("asInterface", "(Landroid/os/IBinder;)Lcom/mitac/cell/device/bcr/IRemoteBcrListener;", "")]
        public static unsafe IRemoteBcrListener AsInterface(IBinder p0)
        {
            if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
            {
                id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID(class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/mitac/cell/device/bcr/IRemoteBcrListener;");
            }
            try
            {
                JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                valuePtr[0] = new JValue(p0);
                return Object.GetObject<IRemoteBcrListener>(JNIEnv.CallStaticObjectMethod(class_ref, id_asInterface_Landroid_os_IBinder_, valuePtr), 1);
            }
            finally
            {
            }
        }

        private static Delegate GetAsBinderHandler()
        {
            if (cb_asBinder == null)
            {
                cb_asBinder = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(RemoteBcrListenerStub.n_AsBinder));
            }
            return cb_asBinder;
        }

        private static Delegate GetOnScanned_Ljava_lang_String_Ljava_lang_String_IHandler()
        {
            if (cb_onScanned_Ljava_lang_String_Ljava_lang_String_I == null)
            {
                cb_onScanned_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr, int>(RemoteBcrListenerStub.n_OnScanned_Ljava_lang_String_Ljava_lang_String_I));
            }
            return cb_onScanned_Ljava_lang_String_Ljava_lang_String_I;
        }

        private static Delegate GetOnStatusChanged_IHandler()
        {
            if (cb_onStatusChanged_I == null)
            {
                cb_onStatusChanged_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, int>(RemoteBcrListenerStub.n_OnStatusChanged_I));
            }
            return cb_onStatusChanged_I;
        }

        private static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler()
        {
            if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
            {
                cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>(RemoteBcrListenerStub.n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I));
            }
            return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
        }

        private static IntPtr n_AsBinder(IntPtr jnienv, IntPtr native__this)
        {
            return JNIEnv.ToLocalJniHandle(Object.GetObject<RemoteBcrListenerStub>(jnienv, native__this, 0).AsBinder());
        }

        private static void n_OnScanned_Ljava_lang_String_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
        {
            RemoteBcrListenerStub stub = Object.GetObject<RemoteBcrListenerStub>(jnienv, native__this, 0);
            string str = JNIEnv.GetString(native_p0, 0);
            string str2 = JNIEnv.GetString(native_p1, 0);
            stub.OnScanned(str, str2, p2);
        }

        private static void n_OnStatusChanged_I(IntPtr jnienv, IntPtr native__this, int p0)
        {
            Object.GetObject<RemoteBcrListenerStub>(jnienv, native__this, 0).OnStatusChanged(p0);
        }

        private static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
        {
            RemoteBcrListenerStub stub = Object.GetObject<RemoteBcrListenerStub>(jnienv, native__this, 0);
            Parcel parcel = Object.GetObject<Parcel>(native_p1, 0);
            Parcel parcel2 = Object.GetObject<Parcel>(native_p2, 0);
            return stub.OnTransact(p0, parcel, parcel2, p3);
        }

        [Register("onScanned", "(Ljava/lang/String;Ljava/lang/String;I)V", "GetOnScanned_Ljava_lang_String_Ljava_lang_String_IHandler")]
        public abstract void OnScanned(string p0, string p1, int p2);
        [Register("onStatusChanged", "(I)V", "GetOnStatusChanged_IHandler")]
        public abstract void OnStatusChanged(int p0);
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

        internal static IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/mitac/cell/device/bcr/IRemoteBcrListener$Stub", ref java_class_handle);
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
                return typeof(RemoteBcrListenerStub);
            }
        }

        [Register("com/mitac/cell/device/bcr/IRemoteBcrListener$Stub$Proxy", DoNotGenerateAcw=true)]
        public class Proxy : Object, IRemoteBcrListener, IInterface, IJavaObject, IDisposable
        {
            private static Delegate cb_asBinder;
            private static Delegate cb_getInterfaceDescriptor;
            private static Delegate cb_onScanned_Ljava_lang_String_Ljava_lang_String_I;
            private static Delegate cb_onStatusChanged_I;
            private static IntPtr id_asBinder;
            private static IntPtr id_getInterfaceDescriptor;
            private static IntPtr id_onScanned_Ljava_lang_String_Ljava_lang_String_I;
            private static IntPtr id_onStatusChanged_I;
            internal static IntPtr java_class_handle;

            protected Proxy(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
            {
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

            private static Delegate GetAsBinderHandler()
            {
                if (cb_asBinder == null)
                {
                    cb_asBinder = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(RemoteBcrListenerStub.Proxy.n_AsBinder));
                }
                return cb_asBinder;
            }

            private static Delegate GetGetInterfaceDescriptorHandler()
            {
                if (cb_getInterfaceDescriptor == null)
                {
                    cb_getInterfaceDescriptor = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(RemoteBcrListenerStub.Proxy.n_GetInterfaceDescriptor));
                }
                return cb_getInterfaceDescriptor;
            }

            private static Delegate GetOnScanned_Ljava_lang_String_Ljava_lang_String_IHandler()
            {
                if (cb_onScanned_Ljava_lang_String_Ljava_lang_String_I == null)
                {
                    cb_onScanned_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr, int>(RemoteBcrListenerStub.Proxy.n_OnScanned_Ljava_lang_String_Ljava_lang_String_I));
                }
                return cb_onScanned_Ljava_lang_String_Ljava_lang_String_I;
            }

            private static Delegate GetOnStatusChanged_IHandler()
            {
                if (cb_onStatusChanged_I == null)
                {
                    cb_onStatusChanged_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, int>(RemoteBcrListenerStub.Proxy.n_OnStatusChanged_I));
                }
                return cb_onStatusChanged_I;
            }

            private static IntPtr n_AsBinder(IntPtr jnienv, IntPtr native__this)
            {
                return JNIEnv.ToLocalJniHandle(Object.GetObject<RemoteBcrListenerStub.Proxy>(jnienv, native__this, 0).AsBinder());
            }

            private static IntPtr n_GetInterfaceDescriptor(IntPtr jnienv, IntPtr native__this)
            {
                return JNIEnv.NewString(Object.GetObject<RemoteBcrListenerStub.Proxy>(jnienv, native__this, 0).InterfaceDescriptor);
            }

            private static void n_OnScanned_Ljava_lang_String_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
            {
                RemoteBcrListenerStub.Proxy proxy = Object.GetObject<RemoteBcrListenerStub.Proxy>(jnienv, native__this, 0);
                string str = JNIEnv.GetString(native_p0, 0);
                string str2 = JNIEnv.GetString(native_p1, 0);
                proxy.OnScanned(str, str2, p2);
            }

            private static void n_OnStatusChanged_I(IntPtr jnienv, IntPtr native__this, int p0)
            {
                Object.GetObject<RemoteBcrListenerStub.Proxy>(jnienv, native__this, 0).OnStatusChanged(p0);
            }

            [Register("onScanned", "(Ljava/lang/String;Ljava/lang/String;I)V", "GetOnScanned_Ljava_lang_String_Ljava_lang_String_IHandler")]
            public virtual unsafe void OnScanned(string p0, string p1, int p2)
            {
                if (id_onScanned_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
                {
                    id_onScanned_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID(class_ref, "onScanned", "(Ljava/lang/String;Ljava/lang/String;I)V");
                }
                IntPtr ptr = JNIEnv.NewString(p0);
                IntPtr ptr2 = JNIEnv.NewString(p1);
                try
                {
                    JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 3) * sizeof(JValue))];
                    valuePtr[0] = new JValue(ptr);
                    valuePtr[1] = new JValue(ptr2);
                    valuePtr[2] = new JValue(p2);
                    if (base.GetType() == this.get_ThresholdType())
                    {
                        JNIEnv.CallVoidMethod(base.get_Handle(), id_onScanned_Ljava_lang_String_Ljava_lang_String_I, valuePtr);
                    }
                    else
                    {
                        JNIEnv.CallNonvirtualVoidMethod(base.get_Handle(), this.get_ThresholdClass(), JNIEnv.GetMethodID(this.get_ThresholdClass(), "onScanned", "(Ljava/lang/String;Ljava/lang/String;I)V"), valuePtr);
                    }
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(ptr);
                    JNIEnv.DeleteLocalRef(ptr2);
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

            internal static IntPtr class_ref
            {
                get
                {
                    return JNIEnv.FindClass("com/mitac/cell/device/bcr/IRemoteBcrListener$Stub$Proxy", ref java_class_handle);
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
                    return typeof(RemoteBcrListenerStub.Proxy);
                }
            }
        }
    }
}

