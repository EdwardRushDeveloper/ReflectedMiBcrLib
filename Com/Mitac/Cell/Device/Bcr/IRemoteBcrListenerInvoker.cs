namespace Com.Mitac.Cell.Device.Bcr
{
    using Android.OS;
    using Android.Runtime;
    using Java.Lang;
    using System;

    [Register("com/mitac/cell/device/bcr/IRemoteBcrListener", DoNotGenerateAcw=true)]
    internal class IRemoteBcrListenerInvoker : Object, IRemoteBcrListener, IInterface, IJavaObject, IDisposable
    {
        private static Delegate cb_asBinder;
        private static Delegate cb_onScanned_Ljava_lang_String_Ljava_lang_String_I;
        private static Delegate cb_onStatusChanged_I;
        private IntPtr class_ref;
        private IntPtr id_asBinder;
        private IntPtr id_onScanned_Ljava_lang_String_Ljava_lang_String_I;
        private IntPtr id_onStatusChanged_I;
        private static IntPtr java_class_ref = JNIEnv.FindClass("com/mitac/cell/device/bcr/IRemoteBcrListener");

        public IRemoteBcrListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
        {
            IntPtr objectClass = JNIEnv.GetObjectClass(base.get_Handle());
            this.class_ref = JNIEnv.NewGlobalRef(objectClass);
            JNIEnv.DeleteLocalRef(objectClass);
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

        private static Delegate GetAsBinderHandler()
        {
            if (cb_asBinder == null)
            {
                cb_asBinder = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(IRemoteBcrListenerInvoker.n_AsBinder));
            }
            return cb_asBinder;
        }

        public static IRemoteBcrListener GetObject(IntPtr handle, JniHandleOwnership transfer)
        {
            return Object.GetObject<IRemoteBcrListener>(handle, transfer);
        }

        private static Delegate GetOnScanned_Ljava_lang_String_Ljava_lang_String_IHandler()
        {
            if (cb_onScanned_Ljava_lang_String_Ljava_lang_String_I == null)
            {
                cb_onScanned_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr, int>(IRemoteBcrListenerInvoker.n_OnScanned_Ljava_lang_String_Ljava_lang_String_I));
            }
            return cb_onScanned_Ljava_lang_String_Ljava_lang_String_I;
        }

        private static Delegate GetOnStatusChanged_IHandler()
        {
            if (cb_onStatusChanged_I == null)
            {
                cb_onStatusChanged_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, int>(IRemoteBcrListenerInvoker.n_OnStatusChanged_I));
            }
            return cb_onStatusChanged_I;
        }

        private static IntPtr n_AsBinder(IntPtr jnienv, IntPtr native__this)
        {
            return JNIEnv.ToLocalJniHandle(Object.GetObject<IRemoteBcrListener>(jnienv, native__this, 0).AsBinder());
        }

        private static void n_OnScanned_Ljava_lang_String_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
        {
            IRemoteBcrListener listener = Object.GetObject<IRemoteBcrListener>(jnienv, native__this, 0);
            string str = JNIEnv.GetString(native_p0, 0);
            string str2 = JNIEnv.GetString(native_p1, 0);
            listener.OnScanned(str, str2, p2);
        }

        private static void n_OnStatusChanged_I(IntPtr jnienv, IntPtr native__this, int p0)
        {
            Object.GetObject<IRemoteBcrListener>(jnienv, native__this, 0).OnStatusChanged(p0);
        }

        public unsafe void OnScanned(string p0, string p1, int p2)
        {
            if (this.id_onScanned_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
            {
                this.id_onScanned_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID(this.class_ref, "onScanned", "(Ljava/lang/String;Ljava/lang/String;I)V");
            }
            IntPtr ptr = JNIEnv.NewString(p0);
            IntPtr ptr2 = JNIEnv.NewString(p1);
            JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 3) * sizeof(JValue))];
            valuePtr[0] = new JValue(ptr);
            valuePtr[1] = new JValue(ptr2);
            valuePtr[2] = new JValue(p2);
            JNIEnv.CallVoidMethod(base.get_Handle(), this.id_onScanned_Ljava_lang_String_Ljava_lang_String_I, valuePtr);
            JNIEnv.DeleteLocalRef(ptr);
            JNIEnv.DeleteLocalRef(ptr2);
        }

        public unsafe void OnStatusChanged(int p0)
        {
            if (this.id_onStatusChanged_I == IntPtr.Zero)
            {
                this.id_onStatusChanged_I = JNIEnv.GetMethodID(this.class_ref, "onStatusChanged", "(I)V");
            }
            JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
            valuePtr[0] = new JValue(p0);
            JNIEnv.CallVoidMethod(base.get_Handle(), this.id_onStatusChanged_I, valuePtr);
        }

        private static IntPtr Validate(IntPtr handle)
        {
            if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
            {
                throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance(handle), "com.mitac.cell.device.bcr.IRemoteBcrListener"));
            }
            return handle;
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
                return typeof(IRemoteBcrListenerInvoker);
            }
        }
    }
}

