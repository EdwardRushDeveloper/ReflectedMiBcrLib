namespace Com.Lib.Utils
{
    using Android.Runtime;
    using Java.Lang;
    using System;

    [Register("com/lib/utils/McStrings", DoNotGenerateAcw=true)]
    public class McStrings : Object
    {
        private static IntPtr id_ctor;
        private static IntPtr id_isNullOrEmpty_Ljava_lang_String_;
        internal static IntPtr java_class_handle;

        [Register(".ctor", "()V", "")]
        public McStrings() : base(IntPtr.Zero, 0)
        {
            if (base.get_Handle() == IntPtr.Zero)
            {
                try
                {
                    if (base.GetType() != typeof(McStrings))
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

        protected McStrings(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        [Register("isNullOrEmpty", "(Ljava/lang/String;)Z", "")]
        public static unsafe bool IsNullOrEmpty(string p0)
        {
            bool flag3;
            if (id_isNullOrEmpty_Ljava_lang_String_ == IntPtr.Zero)
            {
                id_isNullOrEmpty_Ljava_lang_String_ = JNIEnv.GetStaticMethodID(class_ref, "isNullOrEmpty", "(Ljava/lang/String;)Z");
            }
            IntPtr ptr = JNIEnv.NewString(p0);
            try
            {
                JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                valuePtr[0] = new JValue(ptr);
                flag3 = JNIEnv.CallStaticBooleanMethod(class_ref, id_isNullOrEmpty_Ljava_lang_String_, valuePtr);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(ptr);
            }
            return flag3;
        }

        internal static IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/lib/utils/McStrings", ref java_class_handle);
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
                return typeof(McStrings);
            }
        }
    }
}

