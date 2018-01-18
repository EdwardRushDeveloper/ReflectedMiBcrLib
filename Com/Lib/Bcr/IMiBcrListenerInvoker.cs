namespace Com.Lib.Bcr
{
    using Android.Runtime;
    using Com.Lib.Bcr.Utils;
    using Java.Lang;
    using System;

    [Register("com/lib/bcr/MiBcrListener", DoNotGenerateAcw=true)]
    internal class IMiBcrListenerInvoker : Object, IMiBcrListener, IJavaObject, IDisposable
    {
        private static Delegate cb_onScanned_Lcom_lib_bcr_utils_BARCODE_TYPE_Ljava_lang_String_I;
        private static Delegate cb_onStatusChanged_I;
        private IntPtr class_ref;
        private IntPtr id_onScanned_Lcom_lib_bcr_utils_BARCODE_TYPE_Ljava_lang_String_I;
        private IntPtr id_onStatusChanged_I;
        private static IntPtr java_class_ref = JNIEnv.FindClass("com/lib/bcr/MiBcrListener");

        public IMiBcrListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
        {
            IntPtr objectClass = JNIEnv.GetObjectClass(base.get_Handle());
            this.class_ref = JNIEnv.NewGlobalRef(objectClass);
            JNIEnv.DeleteLocalRef(objectClass);
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

        public static IMiBcrListener GetObject(IntPtr handle, JniHandleOwnership transfer)
        {
            return Object.GetObject<IMiBcrListener>(handle, transfer);
        }

        private static Delegate GetOnScanned_Lcom_lib_bcr_utils_BARCODE_TYPE_Ljava_lang_String_IHandler()
        {
            if (cb_onScanned_Lcom_lib_bcr_utils_BARCODE_TYPE_Ljava_lang_String_I == null)
            {
                cb_onScanned_Lcom_lib_bcr_utils_BARCODE_TYPE_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr, int>(IMiBcrListenerInvoker.n_OnScanned_Lcom_lib_bcr_utils_BARCODE_TYPE_Ljava_lang_String_I));
            }
            return cb_onScanned_Lcom_lib_bcr_utils_BARCODE_TYPE_Ljava_lang_String_I;
        }

        private static Delegate GetOnStatusChanged_IHandler()
        {
            if (cb_onStatusChanged_I == null)
            {
                cb_onStatusChanged_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, int>(IMiBcrListenerInvoker.n_OnStatusChanged_I));
            }
            return cb_onStatusChanged_I;
        }

        private static void n_OnScanned_Lcom_lib_bcr_utils_BARCODE_TYPE_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
        {
            IMiBcrListener listener = Object.GetObject<IMiBcrListener>(jnienv, native__this, 0);
            BARCODE.TYPE type = Object.GetObject<BARCODE.TYPE>(native_p0, 0);
            string str = JNIEnv.GetString(native_p1, 0);
            listener.OnScanned(type, str, p2);
        }

        private static void n_OnStatusChanged_I(IntPtr jnienv, IntPtr native__this, int p0)
        {
            Object.GetObject<IMiBcrListener>(jnienv, native__this, 0).OnStatusChanged(p0);
        }

        public unsafe void OnScanned(BARCODE.TYPE p0, string p1, int p2)
        {
            if (this.id_onScanned_Lcom_lib_bcr_utils_BARCODE_TYPE_Ljava_lang_String_I == IntPtr.Zero)
            {
                this.id_onScanned_Lcom_lib_bcr_utils_BARCODE_TYPE_Ljava_lang_String_I = JNIEnv.GetMethodID(this.class_ref, "onScanned", "(Lcom/lib/bcr/utils/BARCODE$TYPE;Ljava/lang/String;I)V");
            }
            IntPtr ptr = JNIEnv.NewString(p1);
            JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 3) * sizeof(JValue))];
            valuePtr[0] = new JValue(p0);
            valuePtr[1] = new JValue(ptr);
            valuePtr[2] = new JValue(p2);
            JNIEnv.CallVoidMethod(base.get_Handle(), this.id_onScanned_Lcom_lib_bcr_utils_BARCODE_TYPE_Ljava_lang_String_I, valuePtr);
            JNIEnv.DeleteLocalRef(ptr);
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
                throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance(handle), "com.lib.bcr.MiBcrListener"));
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
                return typeof(IMiBcrListenerInvoker);
            }
        }
    }
}

