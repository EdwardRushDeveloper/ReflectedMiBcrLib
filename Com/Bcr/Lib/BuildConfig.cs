namespace Com.Bcr.Lib
{
    using Android.Runtime;
    using Java.Lang;
    using System;

    [Register("com/bcr/lib/BuildConfig", DoNotGenerateAcw=true)]
    public sealed class BuildConfig : Object
    {
        [Register("APPLICATION_ID")]
        public const string ApplicationId = "com.bcr.lib";
        [Register("BUILD_TYPE")]
        public const string BuildType = "release";
        [Register("DEBUG")]
        public const bool Debug = false;
        [Register("FLAVOR")]
        public const string Flavor = "";
        private static IntPtr id_ctor;
        internal static IntPtr java_class_handle;
        [Register("VERSION_CODE")]
        public const int VersionCode = 0x65;
        [Register("VERSION_NAME")]
        public const string VersionName = "1.0.1";

        [Register(".ctor", "()V", "")]
        public BuildConfig() : base(IntPtr.Zero, 0)
        {
            if (base.get_Handle() == IntPtr.Zero)
            {
                try
                {
                    if (base.GetType() != typeof(BuildConfig))
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

        internal BuildConfig(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        internal static IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/bcr/lib/BuildConfig", ref java_class_handle);
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
                return typeof(BuildConfig);
            }
        }
    }
}

