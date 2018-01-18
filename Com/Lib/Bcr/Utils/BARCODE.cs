namespace Com.Lib.Bcr.Utils
{
    using Android.Content;
    using Android.Runtime;
    using Java.Lang;
    using System;

    [Register("com/lib/bcr/utils/BARCODE", DoNotGenerateAcw=true)]
    public class BARCODE : Object
    {
        private static IntPtr id_ctor;
        internal static IntPtr java_class_handle;

        [Register(".ctor", "()V", "")]
        public BARCODE() : base(IntPtr.Zero, 0)
        {
            if (base.get_Handle() == IntPtr.Zero)
            {
                try
                {
                    if (base.GetType() != typeof(BARCODE))
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

        protected BARCODE(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        internal static IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/lib/bcr/utils/BARCODE", ref java_class_handle);
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
                return typeof(BARCODE);
            }
        }

        [Register("com/lib/bcr/utils/BARCODE$TYPE", DoNotGenerateAcw=true)]
        public sealed class TYPE : Enum
        {
            private static IntPtr ALL_1D_jfieldId;
            private static IntPtr ALL_2D_jfieldId;
            private static IntPtr ALL_EXCLUDE_ADDON_jfieldId;
            private static IntPtr ALL_jfieldId;
            private static IntPtr AUSTRALIAN_POSTAL_jfieldId;
            private static IntPtr AZTEC_jfieldId;
            private static IntPtr AZTEC_RUNES_jfieldId;
            private static IntPtr BOOKLAND_jfieldId;
            private static IntPtr BRITISH_POSTAL_jfieldId;
            private static IntPtr CANADIAN_POSTAL_jfieldId;
            private static IntPtr CCA_EAN128_jfieldId;
            private static IntPtr CCA_EAN13_jfieldId;
            private static IntPtr CCA_EAN8_jfieldId;
            private static IntPtr CCA_GS1_DATABAR_14_jfieldId;
            private static IntPtr CCA_GS1_DATABAR_EXPANDED_jfieldId;
            private static IntPtr CCA_GS1_DATABAR_LIMITED_jfieldId;
            private static IntPtr CCA_RSS_EXP_jfieldId;
            private static IntPtr CCA_RSS_LTD_jfieldId;
            private static IntPtr CCA_RSS14_jfieldId;
            private static IntPtr CCA_UPC_A_jfieldId;
            private static IntPtr CCA_UPC_E_jfieldId;
            private static IntPtr CCB_EAN128_jfieldId;
            private static IntPtr CCB_EAN13_jfieldId;
            private static IntPtr CCB_EAN8_jfieldId;
            private static IntPtr CCB_GS1_DATABAR_14_jfieldId;
            private static IntPtr CCB_GS1_DATABAR_EXPANDED_jfieldId;
            private static IntPtr CCB_GS1_DATABAR_LIMITED_jfieldId;
            private static IntPtr CCB_RSS_EXP_jfieldId;
            private static IntPtr CCB_RSS_LTD_jfieldId;
            private static IntPtr CCB_RSS14_jfieldId;
            private static IntPtr CCB_UPCA_jfieldId;
            private static IntPtr CCB_UPCE_jfieldId;
            private static IntPtr CCC_EAN128_jfieldId;
            private static IntPtr CHINESE_POST_jfieldId;
            private static IntPtr CHINESE_SENSIBLE_jfieldId;
            private static IntPtr CODABAR_ABC_jfieldId;
            private static IntPtr CODABAR_CX_jfieldId;
            private static IntPtr CODABAR_jfieldId;
            private static IntPtr CODABLOCK_A_jfieldId;
            private static IntPtr CODABLOCK_F_jfieldId;
            private static IntPtr CODE_11_jfieldId;
            private static IntPtr CODE_11_ONE_CHECKDIGIT_jfieldId;
            private static IntPtr CODE_11_TWO_CHECKDIGITS_jfieldId;
            private static IntPtr CODE_128_jfieldId;
            private static IntPtr CODE_16K_jfieldId;
            private static IntPtr CODE_2OF5_jfieldId;
            private static IntPtr CODE_32_jfieldId;
            private static IntPtr CODE_39_FULL_ASCII_jfieldId;
            private static IntPtr CODE_39_jfieldId;
            private static IntPtr CODE_49_jfieldId;
            private static IntPtr CODE_93_jfieldId;
            private static IntPtr CODE_93I_jfieldId;
            private static IntPtr COMPOSITE_CC_A_jfieldId;
            private static IntPtr COMPOSITE_CC_AB_jfieldId;
            private static IntPtr COMPOSITE_CC_B_jfieldId;
            private static IntPtr COMPOSITE_CC_C_jfieldId;
            private static IntPtr COMPOSITE_CODE_A_jfieldId;
            private static IntPtr COMPOSITE_CODE_B_jfieldId;
            private static IntPtr COMPOSITE_CODE_C_jfieldId;
            private static IntPtr COMPOSITE_jfieldId;
            private static IntPtr COMPOSITE_TLC_39_jfieldId;
            private static IntPtr COUPON_CODE_jfieldId;
            private static IntPtr CUECODE_jfieldId;
            private static IntPtr DATA_MATRIX_ECC140_jfieldId;
            private static IntPtr DATA_MATRIX_ECC200_jfieldId;
            private static IntPtr DATA_MATRIX_jfieldId;
            private static IntPtr DISCRETE_2OF5_jfieldId;
            private static IntPtr EAN_128_jfieldId;
            private static IntPtr EAN_13_ADDON_2_jfieldId;
            private static IntPtr EAN_13_ADDON_5_jfieldId;
            private static IntPtr EAN_13_ADDON_jfieldId;
            private static IntPtr EAN_13_jfieldId;
            private static IntPtr EAN_8_ADDON_2_jfieldId;
            private static IntPtr EAN_8_ADDON_5_jfieldId;
            private static IntPtr EAN_8_ADDON_jfieldId;
            private static IntPtr EAN_8_jfieldId;
            private static IntPtr EAN_ADDON_2_jfieldId;
            private static IntPtr EAN_ADDON_5_jfieldId;
            private static IntPtr EAN_jfieldId;
            private static IntPtr EAN_PREFIX_378_jfieldId;
            private static IntPtr EAN_PREFIX_434_jfieldId;
            private static IntPtr GO_CODE_jfieldId;
            private static IntPtr GS1_128_jfieldId;
            private static IntPtr GS1_DATABAR_14_jfieldId;
            private static IntPtr GS1_DATABAR_COUPON_jfieldId;
            private static IntPtr GS1_DATABAR_EXPANDED_jfieldId;
            private static IntPtr GS1_DATABAR_jfieldId;
            private static IntPtr GS1_DATABAR_LIMITED_jfieldId;
            private static IntPtr IATA_jfieldId;
            private static IntPtr id_get_Ljava_lang_String_;
            private static IntPtr id_name_Landroid_content_Context_;
            private static IntPtr id_valueOf_Ljava_lang_String_;
            private static IntPtr id_values;
            private static IntPtr INDUSTRIAL_2OF5_jfieldId;
            private static IntPtr INFO_MAIL_jfieldId;
            private static IntPtr INTELLIGENT_MAIL_jfieldId;
            private static IntPtr INTERLEAVED_2OF5_jfieldId;
            private static IntPtr ISBN_jfieldId;
            private static IntPtr ISBT_128_CON_jfieldId;
            private static IntPtr ISBT_128_jfieldId;
            private static IntPtr ISMN_jfieldId;
            private static IntPtr ISSN_jfieldId;
            private static IntPtr IT_PHARM_jfieldId;
            private static IntPtr JAPANESE_POSTAL_jfieldId;
            internal static IntPtr java_class_handle;
            private static IntPtr KIX_CODE_jfieldId;
            private static IntPtr KOREAN_POST_jfieldId;
            private static IntPtr MACRO_MICRO_PDF_jfieldId;
            private static IntPtr MACRO_PDF_jfieldId;
            private static IntPtr MACRO_QR_jfieldId;
            private static IntPtr MATRIX_2OF5_jfieldId;
            private static IntPtr MATRIX_3OF5_jfieldId;
            private static IntPtr MATRIX_POST_jfieldId;
            private static IntPtr MAXICODE_jfieldId;
            private static IntPtr MICRO_PDF_CCA_jfieldId;
            private static IntPtr MICRO_PDF_jfieldId;
            private static IntPtr MICRO_QR_jfieldId;
            private static IntPtr MSI_PLESSEY_jfieldId;
            private static IntPtr NEC_2OF5_jfieldId;
            private static IntPtr NW_7_jfieldId;
            private static IntPtr OCR_jfieldId;
            private static IntPtr ONE_CODE_jfieldId;
            private static IntPtr PDF417_jfieldId;
            private static IntPtr PHARMACODE_jfieldId;
            private static IntPtr POSI_CODE_jfieldId;
            private static IntPtr POSTAL_4I_jfieldId;
            private static IntPtr QR_CODE_jfieldId;
            private static IntPtr resId_jfieldId;
            private static IntPtr ROYAL_MAIL_jfieldId;
            private static IntPtr S_CODE_jfieldId;
            private static IntPtr SCANLET_jfieldId;
            private static IntPtr SIGNATURE_CAPTURE_jfieldId;
            private static IntPtr TELEPEN_jfieldId;
            private static IntPtr TLC_39_jfieldId;
            private static IntPtr TRIOPTIC_jfieldId;
            private static IntPtr UK_PLESSEY_jfieldId;
            private static IntPtr UK_POSTAL_jfieldId;
            private static IntPtr UNKNOWN_jfieldId;
            private static IntPtr UPC_A_ADDON_2_jfieldId;
            private static IntPtr UPC_A_ADDON_5_jfieldId;
            private static IntPtr UPC_A_ADDON_jfieldId;
            private static IntPtr UPC_A_jfieldId;
            private static IntPtr UPC_ADDON_2_jfieldId;
            private static IntPtr UPC_ADDON_5_jfieldId;
            private static IntPtr UPC_D_jfieldId;
            private static IntPtr UPC_E_ADDON_2_jfieldId;
            private static IntPtr UPC_E_ADDON_5_jfieldId;
            private static IntPtr UPC_E_ADDON_jfieldId;
            private static IntPtr UPC_E_jfieldId;
            private static IntPtr UPC_E0_ADDON_2_jfieldId;
            private static IntPtr UPC_E0_ADDON_5_jfieldId;
            private static IntPtr UPC_E0_jfieldId;
            private static IntPtr UPC_E1_ADDON_5_jfieldId;
            private static IntPtr UPC_E1_jfieldId;
            private static IntPtr UPC_EAN_jfieldId;
            private static IntPtr UPC_EAN13_E0_ADDON_jfieldId;
            private static IntPtr UPC_EAN13_E0_jfieldId;
            private static IntPtr UPC_jfieldId;
            private static IntPtr UPU_4STATE_jfieldId;
            private static IntPtr UPU_FICS_POSTAL_jfieldId;
            private static IntPtr UPU_ID_TAG_POSTAL_jfieldId;
            private static IntPtr US_PLANET_jfieldId;
            private static IntPtr US_POSTNET_jfieldId;
            private static IntPtr USPS_4CB_jfieldId;

            internal TYPE(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
            {
            }

            [Register("get", "(Ljava/lang/String;)Lcom/lib/bcr/utils/BARCODE$TYPE;", "")]
            public static unsafe BARCODE.TYPE Get(string p0)
            {
                BARCODE.TYPE type2;
                if (id_get_Ljava_lang_String_ == IntPtr.Zero)
                {
                    id_get_Ljava_lang_String_ = JNIEnv.GetStaticMethodID(class_ref, "get", "(Ljava/lang/String;)Lcom/lib/bcr/utils/BARCODE$TYPE;");
                }
                IntPtr ptr = JNIEnv.NewString(p0);
                try
                {
                    JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                    valuePtr[0] = new JValue(ptr);
                    type2 = Object.GetObject<BARCODE.TYPE>(JNIEnv.CallStaticObjectMethod(class_ref, id_get_Ljava_lang_String_, valuePtr), 1);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(ptr);
                }
                return type2;
            }

            [Register("name", "(Landroid/content/Context;)Ljava/lang/String;", "")]
            public unsafe string Name(Context p0)
            {
                if (id_name_Landroid_content_Context_ == IntPtr.Zero)
                {
                    id_name_Landroid_content_Context_ = JNIEnv.GetMethodID(class_ref, "name", "(Landroid/content/Context;)Ljava/lang/String;");
                }
                try
                {
                    JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                    valuePtr[0] = new JValue(p0);
                    return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.get_Handle(), id_name_Landroid_content_Context_, valuePtr), 1);
                }
                finally
                {
                }
            }

            [Register("valueOf", "(Ljava/lang/String;)Lcom/lib/bcr/utils/BARCODE$TYPE;", "")]
            public static unsafe BARCODE.TYPE ValueOf(string p0)
            {
                BARCODE.TYPE type2;
                if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
                {
                    id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID(class_ref, "valueOf", "(Ljava/lang/String;)Lcom/lib/bcr/utils/BARCODE$TYPE;");
                }
                IntPtr ptr = JNIEnv.NewString(p0);
                try
                {
                    JValue* valuePtr = (JValue*) stackalloc byte[(((IntPtr) 1) * sizeof(JValue))];
                    valuePtr[0] = new JValue(ptr);
                    type2 = Object.GetObject<BARCODE.TYPE>(JNIEnv.CallStaticObjectMethod(class_ref, id_valueOf_Ljava_lang_String_, valuePtr), 1);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(ptr);
                }
                return type2;
            }

            [Register("values", "()[Lcom/lib/bcr/utils/BARCODE$TYPE;", "")]
            public static BARCODE.TYPE[] Values()
            {
                if (id_values == IntPtr.Zero)
                {
                    id_values = JNIEnv.GetStaticMethodID(class_ref, "values", "()[Lcom/lib/bcr/utils/BARCODE$TYPE;");
                }
                try
                {
                    return (BARCODE.TYPE[]) JNIEnv.GetArray(JNIEnv.CallStaticObjectMethod(class_ref, id_values), 1, typeof(BARCODE.TYPE));
                }
                finally
                {
                }
            }

            [Register("ALL")]
            public static BARCODE.TYPE All
            {
                get
                {
                    if (ALL_jfieldId == IntPtr.Zero)
                    {
                        ALL_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ALL", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, ALL_jfieldId), 1);
                }
            }

            [Register("ALL_1D")]
            public static BARCODE.TYPE All1d
            {
                get
                {
                    if (ALL_1D_jfieldId == IntPtr.Zero)
                    {
                        ALL_1D_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ALL_1D", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, ALL_1D_jfieldId), 1);
                }
            }

            [Register("ALL_2D")]
            public static BARCODE.TYPE All2d
            {
                get
                {
                    if (ALL_2D_jfieldId == IntPtr.Zero)
                    {
                        ALL_2D_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ALL_2D", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, ALL_2D_jfieldId), 1);
                }
            }

            [Register("ALL_EXCLUDE_ADDON")]
            public static BARCODE.TYPE AllExcludeAddon
            {
                get
                {
                    if (ALL_EXCLUDE_ADDON_jfieldId == IntPtr.Zero)
                    {
                        ALL_EXCLUDE_ADDON_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ALL_EXCLUDE_ADDON", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, ALL_EXCLUDE_ADDON_jfieldId), 1);
                }
            }

            [Register("AUSTRALIAN_POSTAL")]
            public static BARCODE.TYPE AustralianPostal
            {
                get
                {
                    if (AUSTRALIAN_POSTAL_jfieldId == IntPtr.Zero)
                    {
                        AUSTRALIAN_POSTAL_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "AUSTRALIAN_POSTAL", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, AUSTRALIAN_POSTAL_jfieldId), 1);
                }
            }

            [Register("AZTEC")]
            public static BARCODE.TYPE Aztec
            {
                get
                {
                    if (AZTEC_jfieldId == IntPtr.Zero)
                    {
                        AZTEC_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "AZTEC", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, AZTEC_jfieldId), 1);
                }
            }

            [Register("AZTEC_RUNES")]
            public static BARCODE.TYPE AztecRunes
            {
                get
                {
                    if (AZTEC_RUNES_jfieldId == IntPtr.Zero)
                    {
                        AZTEC_RUNES_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "AZTEC_RUNES", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, AZTEC_RUNES_jfieldId), 1);
                }
            }

            [Register("BOOKLAND")]
            public static BARCODE.TYPE Bookland
            {
                get
                {
                    if (BOOKLAND_jfieldId == IntPtr.Zero)
                    {
                        BOOKLAND_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "BOOKLAND", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, BOOKLAND_jfieldId), 1);
                }
            }

            [Register("BRITISH_POSTAL")]
            public static BARCODE.TYPE BritishPostal
            {
                get
                {
                    if (BRITISH_POSTAL_jfieldId == IntPtr.Zero)
                    {
                        BRITISH_POSTAL_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "BRITISH_POSTAL", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, BRITISH_POSTAL_jfieldId), 1);
                }
            }

            [Register("CANADIAN_POSTAL")]
            public static BARCODE.TYPE CanadianPostal
            {
                get
                {
                    if (CANADIAN_POSTAL_jfieldId == IntPtr.Zero)
                    {
                        CANADIAN_POSTAL_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CANADIAN_POSTAL", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CANADIAN_POSTAL_jfieldId), 1);
                }
            }

            [Register("CCA_EAN128")]
            public static BARCODE.TYPE CcaEan128
            {
                get
                {
                    if (CCA_EAN128_jfieldId == IntPtr.Zero)
                    {
                        CCA_EAN128_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCA_EAN128", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCA_EAN128_jfieldId), 1);
                }
            }

            [Register("CCA_EAN13")]
            public static BARCODE.TYPE CcaEan13
            {
                get
                {
                    if (CCA_EAN13_jfieldId == IntPtr.Zero)
                    {
                        CCA_EAN13_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCA_EAN13", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCA_EAN13_jfieldId), 1);
                }
            }

            [Register("CCA_EAN8")]
            public static BARCODE.TYPE CcaEan8
            {
                get
                {
                    if (CCA_EAN8_jfieldId == IntPtr.Zero)
                    {
                        CCA_EAN8_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCA_EAN8", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCA_EAN8_jfieldId), 1);
                }
            }

            [Register("CCA_GS1_DATABAR_14")]
            public static BARCODE.TYPE CcaGs1Databar14
            {
                get
                {
                    if (CCA_GS1_DATABAR_14_jfieldId == IntPtr.Zero)
                    {
                        CCA_GS1_DATABAR_14_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCA_GS1_DATABAR_14", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCA_GS1_DATABAR_14_jfieldId), 1);
                }
            }

            [Register("CCA_GS1_DATABAR_EXPANDED")]
            public static BARCODE.TYPE CcaGs1DatabarExpanded
            {
                get
                {
                    if (CCA_GS1_DATABAR_EXPANDED_jfieldId == IntPtr.Zero)
                    {
                        CCA_GS1_DATABAR_EXPANDED_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCA_GS1_DATABAR_EXPANDED", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCA_GS1_DATABAR_EXPANDED_jfieldId), 1);
                }
            }

            [Register("CCA_GS1_DATABAR_LIMITED")]
            public static BARCODE.TYPE CcaGs1DatabarLimited
            {
                get
                {
                    if (CCA_GS1_DATABAR_LIMITED_jfieldId == IntPtr.Zero)
                    {
                        CCA_GS1_DATABAR_LIMITED_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCA_GS1_DATABAR_LIMITED", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCA_GS1_DATABAR_LIMITED_jfieldId), 1);
                }
            }

            [Register("CCA_RSS14")]
            public static BARCODE.TYPE CcaRss14
            {
                get
                {
                    if (CCA_RSS14_jfieldId == IntPtr.Zero)
                    {
                        CCA_RSS14_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCA_RSS14", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCA_RSS14_jfieldId), 1);
                }
            }

            [Register("CCA_RSS_EXP")]
            public static BARCODE.TYPE CcaRssExp
            {
                get
                {
                    if (CCA_RSS_EXP_jfieldId == IntPtr.Zero)
                    {
                        CCA_RSS_EXP_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCA_RSS_EXP", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCA_RSS_EXP_jfieldId), 1);
                }
            }

            [Register("CCA_RSS_LTD")]
            public static BARCODE.TYPE CcaRssLtd
            {
                get
                {
                    if (CCA_RSS_LTD_jfieldId == IntPtr.Zero)
                    {
                        CCA_RSS_LTD_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCA_RSS_LTD", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCA_RSS_LTD_jfieldId), 1);
                }
            }

            [Register("CCA_UPC_A")]
            public static BARCODE.TYPE CcaUpcA
            {
                get
                {
                    if (CCA_UPC_A_jfieldId == IntPtr.Zero)
                    {
                        CCA_UPC_A_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCA_UPC_A", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCA_UPC_A_jfieldId), 1);
                }
            }

            [Register("CCA_UPC_E")]
            public static BARCODE.TYPE CcaUpcE
            {
                get
                {
                    if (CCA_UPC_E_jfieldId == IntPtr.Zero)
                    {
                        CCA_UPC_E_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCA_UPC_E", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCA_UPC_E_jfieldId), 1);
                }
            }

            [Register("CCB_EAN128")]
            public static BARCODE.TYPE CcbEan128
            {
                get
                {
                    if (CCB_EAN128_jfieldId == IntPtr.Zero)
                    {
                        CCB_EAN128_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCB_EAN128", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCB_EAN128_jfieldId), 1);
                }
            }

            [Register("CCB_EAN13")]
            public static BARCODE.TYPE CcbEan13
            {
                get
                {
                    if (CCB_EAN13_jfieldId == IntPtr.Zero)
                    {
                        CCB_EAN13_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCB_EAN13", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCB_EAN13_jfieldId), 1);
                }
            }

            [Register("CCB_EAN8")]
            public static BARCODE.TYPE CcbEan8
            {
                get
                {
                    if (CCB_EAN8_jfieldId == IntPtr.Zero)
                    {
                        CCB_EAN8_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCB_EAN8", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCB_EAN8_jfieldId), 1);
                }
            }

            [Register("CCB_GS1_DATABAR_14")]
            public static BARCODE.TYPE CcbGs1Databar14
            {
                get
                {
                    if (CCB_GS1_DATABAR_14_jfieldId == IntPtr.Zero)
                    {
                        CCB_GS1_DATABAR_14_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCB_GS1_DATABAR_14", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCB_GS1_DATABAR_14_jfieldId), 1);
                }
            }

            [Register("CCB_GS1_DATABAR_EXPANDED")]
            public static BARCODE.TYPE CcbGs1DatabarExpanded
            {
                get
                {
                    if (CCB_GS1_DATABAR_EXPANDED_jfieldId == IntPtr.Zero)
                    {
                        CCB_GS1_DATABAR_EXPANDED_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCB_GS1_DATABAR_EXPANDED", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCB_GS1_DATABAR_EXPANDED_jfieldId), 1);
                }
            }

            [Register("CCB_GS1_DATABAR_LIMITED")]
            public static BARCODE.TYPE CcbGs1DatabarLimited
            {
                get
                {
                    if (CCB_GS1_DATABAR_LIMITED_jfieldId == IntPtr.Zero)
                    {
                        CCB_GS1_DATABAR_LIMITED_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCB_GS1_DATABAR_LIMITED", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCB_GS1_DATABAR_LIMITED_jfieldId), 1);
                }
            }

            [Register("CCB_RSS14")]
            public static BARCODE.TYPE CcbRss14
            {
                get
                {
                    if (CCB_RSS14_jfieldId == IntPtr.Zero)
                    {
                        CCB_RSS14_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCB_RSS14", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCB_RSS14_jfieldId), 1);
                }
            }

            [Register("CCB_RSS_EXP")]
            public static BARCODE.TYPE CcbRssExp
            {
                get
                {
                    if (CCB_RSS_EXP_jfieldId == IntPtr.Zero)
                    {
                        CCB_RSS_EXP_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCB_RSS_EXP", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCB_RSS_EXP_jfieldId), 1);
                }
            }

            [Register("CCB_RSS_LTD")]
            public static BARCODE.TYPE CcbRssLtd
            {
                get
                {
                    if (CCB_RSS_LTD_jfieldId == IntPtr.Zero)
                    {
                        CCB_RSS_LTD_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCB_RSS_LTD", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCB_RSS_LTD_jfieldId), 1);
                }
            }

            [Register("CCB_UPCA")]
            public static BARCODE.TYPE CcbUpca
            {
                get
                {
                    if (CCB_UPCA_jfieldId == IntPtr.Zero)
                    {
                        CCB_UPCA_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCB_UPCA", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCB_UPCA_jfieldId), 1);
                }
            }

            [Register("CCB_UPCE")]
            public static BARCODE.TYPE CcbUpce
            {
                get
                {
                    if (CCB_UPCE_jfieldId == IntPtr.Zero)
                    {
                        CCB_UPCE_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCB_UPCE", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCB_UPCE_jfieldId), 1);
                }
            }

            [Register("CCC_EAN128")]
            public static BARCODE.TYPE CccEan128
            {
                get
                {
                    if (CCC_EAN128_jfieldId == IntPtr.Zero)
                    {
                        CCC_EAN128_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CCC_EAN128", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CCC_EAN128_jfieldId), 1);
                }
            }

            [Register("CHINESE_POST")]
            public static BARCODE.TYPE ChinesePost
            {
                get
                {
                    if (CHINESE_POST_jfieldId == IntPtr.Zero)
                    {
                        CHINESE_POST_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CHINESE_POST", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CHINESE_POST_jfieldId), 1);
                }
            }

            [Register("CHINESE_SENSIBLE")]
            public static BARCODE.TYPE ChineseSensible
            {
                get
                {
                    if (CHINESE_SENSIBLE_jfieldId == IntPtr.Zero)
                    {
                        CHINESE_SENSIBLE_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CHINESE_SENSIBLE", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CHINESE_SENSIBLE_jfieldId), 1);
                }
            }

            internal static IntPtr class_ref
            {
                get
                {
                    return JNIEnv.FindClass("com/lib/bcr/utils/BARCODE$TYPE", ref java_class_handle);
                }
            }

            [Register("CODABAR")]
            public static BARCODE.TYPE Codabar
            {
                get
                {
                    if (CODABAR_jfieldId == IntPtr.Zero)
                    {
                        CODABAR_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CODABAR", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CODABAR_jfieldId), 1);
                }
            }

            [Register("CODABAR_ABC")]
            public static BARCODE.TYPE CodabarAbc
            {
                get
                {
                    if (CODABAR_ABC_jfieldId == IntPtr.Zero)
                    {
                        CODABAR_ABC_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CODABAR_ABC", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CODABAR_ABC_jfieldId), 1);
                }
            }

            [Register("CODABAR_CX")]
            public static BARCODE.TYPE CodabarCx
            {
                get
                {
                    if (CODABAR_CX_jfieldId == IntPtr.Zero)
                    {
                        CODABAR_CX_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CODABAR_CX", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CODABAR_CX_jfieldId), 1);
                }
            }

            [Register("CODABLOCK_A")]
            public static BARCODE.TYPE CodablockA
            {
                get
                {
                    if (CODABLOCK_A_jfieldId == IntPtr.Zero)
                    {
                        CODABLOCK_A_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CODABLOCK_A", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CODABLOCK_A_jfieldId), 1);
                }
            }

            [Register("CODABLOCK_F")]
            public static BARCODE.TYPE CodablockF
            {
                get
                {
                    if (CODABLOCK_F_jfieldId == IntPtr.Zero)
                    {
                        CODABLOCK_F_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CODABLOCK_F", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CODABLOCK_F_jfieldId), 1);
                }
            }

            [Register("CODE_11")]
            public static BARCODE.TYPE Code11
            {
                get
                {
                    if (CODE_11_jfieldId == IntPtr.Zero)
                    {
                        CODE_11_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CODE_11", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CODE_11_jfieldId), 1);
                }
            }

            [Register("CODE_11_ONE_CHECKDIGIT")]
            public static BARCODE.TYPE Code11OneCheckdigit
            {
                get
                {
                    if (CODE_11_ONE_CHECKDIGIT_jfieldId == IntPtr.Zero)
                    {
                        CODE_11_ONE_CHECKDIGIT_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CODE_11_ONE_CHECKDIGIT", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CODE_11_ONE_CHECKDIGIT_jfieldId), 1);
                }
            }

            [Register("CODE_11_TWO_CHECKDIGITS")]
            public static BARCODE.TYPE Code11TwoCheckdigits
            {
                get
                {
                    if (CODE_11_TWO_CHECKDIGITS_jfieldId == IntPtr.Zero)
                    {
                        CODE_11_TWO_CHECKDIGITS_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CODE_11_TWO_CHECKDIGITS", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CODE_11_TWO_CHECKDIGITS_jfieldId), 1);
                }
            }

            [Register("CODE_128")]
            public static BARCODE.TYPE Code128
            {
                get
                {
                    if (CODE_128_jfieldId == IntPtr.Zero)
                    {
                        CODE_128_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CODE_128", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CODE_128_jfieldId), 1);
                }
            }

            [Register("CODE_16K")]
            public static BARCODE.TYPE Code16k
            {
                get
                {
                    if (CODE_16K_jfieldId == IntPtr.Zero)
                    {
                        CODE_16K_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CODE_16K", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CODE_16K_jfieldId), 1);
                }
            }

            [Register("CODE_2OF5")]
            public static BARCODE.TYPE Code2of5
            {
                get
                {
                    if (CODE_2OF5_jfieldId == IntPtr.Zero)
                    {
                        CODE_2OF5_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CODE_2OF5", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CODE_2OF5_jfieldId), 1);
                }
            }

            [Register("CODE_32")]
            public static BARCODE.TYPE Code32
            {
                get
                {
                    if (CODE_32_jfieldId == IntPtr.Zero)
                    {
                        CODE_32_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CODE_32", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CODE_32_jfieldId), 1);
                }
            }

            [Register("CODE_39")]
            public static BARCODE.TYPE Code39
            {
                get
                {
                    if (CODE_39_jfieldId == IntPtr.Zero)
                    {
                        CODE_39_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CODE_39", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CODE_39_jfieldId), 1);
                }
            }

            [Register("CODE_39_FULL_ASCII")]
            public static BARCODE.TYPE Code39FullAscii
            {
                get
                {
                    if (CODE_39_FULL_ASCII_jfieldId == IntPtr.Zero)
                    {
                        CODE_39_FULL_ASCII_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CODE_39_FULL_ASCII", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CODE_39_FULL_ASCII_jfieldId), 1);
                }
            }

            [Register("CODE_49")]
            public static BARCODE.TYPE Code49
            {
                get
                {
                    if (CODE_49_jfieldId == IntPtr.Zero)
                    {
                        CODE_49_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CODE_49", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CODE_49_jfieldId), 1);
                }
            }

            [Register("CODE_93")]
            public static BARCODE.TYPE Code93
            {
                get
                {
                    if (CODE_93_jfieldId == IntPtr.Zero)
                    {
                        CODE_93_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CODE_93", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CODE_93_jfieldId), 1);
                }
            }

            [Register("CODE_93I")]
            public static BARCODE.TYPE Code93i
            {
                get
                {
                    if (CODE_93I_jfieldId == IntPtr.Zero)
                    {
                        CODE_93I_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CODE_93I", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CODE_93I_jfieldId), 1);
                }
            }

            [Register("COMPOSITE")]
            public static BARCODE.TYPE Composite
            {
                get
                {
                    if (COMPOSITE_jfieldId == IntPtr.Zero)
                    {
                        COMPOSITE_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "COMPOSITE", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, COMPOSITE_jfieldId), 1);
                }
            }

            [Register("COMPOSITE_CC_A")]
            public static BARCODE.TYPE CompositeCcA
            {
                get
                {
                    if (COMPOSITE_CC_A_jfieldId == IntPtr.Zero)
                    {
                        COMPOSITE_CC_A_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "COMPOSITE_CC_A", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, COMPOSITE_CC_A_jfieldId), 1);
                }
            }

            [Register("COMPOSITE_CC_AB")]
            public static BARCODE.TYPE CompositeCcAb
            {
                get
                {
                    if (COMPOSITE_CC_AB_jfieldId == IntPtr.Zero)
                    {
                        COMPOSITE_CC_AB_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "COMPOSITE_CC_AB", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, COMPOSITE_CC_AB_jfieldId), 1);
                }
            }

            [Register("COMPOSITE_CC_B")]
            public static BARCODE.TYPE CompositeCcB
            {
                get
                {
                    if (COMPOSITE_CC_B_jfieldId == IntPtr.Zero)
                    {
                        COMPOSITE_CC_B_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "COMPOSITE_CC_B", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, COMPOSITE_CC_B_jfieldId), 1);
                }
            }

            [Register("COMPOSITE_CC_C")]
            public static BARCODE.TYPE CompositeCcC
            {
                get
                {
                    if (COMPOSITE_CC_C_jfieldId == IntPtr.Zero)
                    {
                        COMPOSITE_CC_C_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "COMPOSITE_CC_C", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, COMPOSITE_CC_C_jfieldId), 1);
                }
            }

            [Register("COMPOSITE_CODE_A")]
            public static BARCODE.TYPE CompositeCodeA
            {
                get
                {
                    if (COMPOSITE_CODE_A_jfieldId == IntPtr.Zero)
                    {
                        COMPOSITE_CODE_A_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "COMPOSITE_CODE_A", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, COMPOSITE_CODE_A_jfieldId), 1);
                }
            }

            [Register("COMPOSITE_CODE_B")]
            public static BARCODE.TYPE CompositeCodeB
            {
                get
                {
                    if (COMPOSITE_CODE_B_jfieldId == IntPtr.Zero)
                    {
                        COMPOSITE_CODE_B_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "COMPOSITE_CODE_B", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, COMPOSITE_CODE_B_jfieldId), 1);
                }
            }

            [Register("COMPOSITE_CODE_C")]
            public static BARCODE.TYPE CompositeCodeC
            {
                get
                {
                    if (COMPOSITE_CODE_C_jfieldId == IntPtr.Zero)
                    {
                        COMPOSITE_CODE_C_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "COMPOSITE_CODE_C", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, COMPOSITE_CODE_C_jfieldId), 1);
                }
            }

            [Register("COMPOSITE_TLC_39")]
            public static BARCODE.TYPE CompositeTlc39
            {
                get
                {
                    if (COMPOSITE_TLC_39_jfieldId == IntPtr.Zero)
                    {
                        COMPOSITE_TLC_39_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "COMPOSITE_TLC_39", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, COMPOSITE_TLC_39_jfieldId), 1);
                }
            }

            [Register("COUPON_CODE")]
            public static BARCODE.TYPE CouponCode
            {
                get
                {
                    if (COUPON_CODE_jfieldId == IntPtr.Zero)
                    {
                        COUPON_CODE_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "COUPON_CODE", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, COUPON_CODE_jfieldId), 1);
                }
            }

            [Register("CUECODE")]
            public static BARCODE.TYPE Cuecode
            {
                get
                {
                    if (CUECODE_jfieldId == IntPtr.Zero)
                    {
                        CUECODE_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "CUECODE", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, CUECODE_jfieldId), 1);
                }
            }

            [Register("DATA_MATRIX")]
            public static BARCODE.TYPE DataMatrix
            {
                get
                {
                    if (DATA_MATRIX_jfieldId == IntPtr.Zero)
                    {
                        DATA_MATRIX_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "DATA_MATRIX", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, DATA_MATRIX_jfieldId), 1);
                }
            }

            [Register("DATA_MATRIX_ECC140")]
            public static BARCODE.TYPE DataMatrixEcc140
            {
                get
                {
                    if (DATA_MATRIX_ECC140_jfieldId == IntPtr.Zero)
                    {
                        DATA_MATRIX_ECC140_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "DATA_MATRIX_ECC140", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, DATA_MATRIX_ECC140_jfieldId), 1);
                }
            }

            [Register("DATA_MATRIX_ECC200")]
            public static BARCODE.TYPE DataMatrixEcc200
            {
                get
                {
                    if (DATA_MATRIX_ECC200_jfieldId == IntPtr.Zero)
                    {
                        DATA_MATRIX_ECC200_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "DATA_MATRIX_ECC200", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, DATA_MATRIX_ECC200_jfieldId), 1);
                }
            }

            [Register("DISCRETE_2OF5")]
            public static BARCODE.TYPE Discrete2of5
            {
                get
                {
                    if (DISCRETE_2OF5_jfieldId == IntPtr.Zero)
                    {
                        DISCRETE_2OF5_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "DISCRETE_2OF5", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, DISCRETE_2OF5_jfieldId), 1);
                }
            }

            [Register("EAN")]
            public static BARCODE.TYPE Ean
            {
                get
                {
                    if (EAN_jfieldId == IntPtr.Zero)
                    {
                        EAN_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "EAN", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, EAN_jfieldId), 1);
                }
            }

            [Register("EAN_128")]
            public static BARCODE.TYPE Ean128
            {
                get
                {
                    if (EAN_128_jfieldId == IntPtr.Zero)
                    {
                        EAN_128_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "EAN_128", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, EAN_128_jfieldId), 1);
                }
            }

            [Register("EAN_13")]
            public static BARCODE.TYPE Ean13
            {
                get
                {
                    if (EAN_13_jfieldId == IntPtr.Zero)
                    {
                        EAN_13_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "EAN_13", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, EAN_13_jfieldId), 1);
                }
            }

            [Register("EAN_13_ADDON")]
            public static BARCODE.TYPE Ean13Addon
            {
                get
                {
                    if (EAN_13_ADDON_jfieldId == IntPtr.Zero)
                    {
                        EAN_13_ADDON_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "EAN_13_ADDON", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, EAN_13_ADDON_jfieldId), 1);
                }
            }

            [Register("EAN_13_ADDON_2")]
            public static BARCODE.TYPE Ean13Addon2
            {
                get
                {
                    if (EAN_13_ADDON_2_jfieldId == IntPtr.Zero)
                    {
                        EAN_13_ADDON_2_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "EAN_13_ADDON_2", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, EAN_13_ADDON_2_jfieldId), 1);
                }
            }

            [Register("EAN_13_ADDON_5")]
            public static BARCODE.TYPE Ean13Addon5
            {
                get
                {
                    if (EAN_13_ADDON_5_jfieldId == IntPtr.Zero)
                    {
                        EAN_13_ADDON_5_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "EAN_13_ADDON_5", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, EAN_13_ADDON_5_jfieldId), 1);
                }
            }

            [Register("EAN_8")]
            public static BARCODE.TYPE Ean8
            {
                get
                {
                    if (EAN_8_jfieldId == IntPtr.Zero)
                    {
                        EAN_8_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "EAN_8", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, EAN_8_jfieldId), 1);
                }
            }

            [Register("EAN_8_ADDON")]
            public static BARCODE.TYPE Ean8Addon
            {
                get
                {
                    if (EAN_8_ADDON_jfieldId == IntPtr.Zero)
                    {
                        EAN_8_ADDON_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "EAN_8_ADDON", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, EAN_8_ADDON_jfieldId), 1);
                }
            }

            [Register("EAN_8_ADDON_2")]
            public static BARCODE.TYPE Ean8Addon2
            {
                get
                {
                    if (EAN_8_ADDON_2_jfieldId == IntPtr.Zero)
                    {
                        EAN_8_ADDON_2_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "EAN_8_ADDON_2", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, EAN_8_ADDON_2_jfieldId), 1);
                }
            }

            [Register("EAN_8_ADDON_5")]
            public static BARCODE.TYPE Ean8Addon5
            {
                get
                {
                    if (EAN_8_ADDON_5_jfieldId == IntPtr.Zero)
                    {
                        EAN_8_ADDON_5_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "EAN_8_ADDON_5", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, EAN_8_ADDON_5_jfieldId), 1);
                }
            }

            [Register("EAN_ADDON_2")]
            public static BARCODE.TYPE EanAddon2
            {
                get
                {
                    if (EAN_ADDON_2_jfieldId == IntPtr.Zero)
                    {
                        EAN_ADDON_2_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "EAN_ADDON_2", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, EAN_ADDON_2_jfieldId), 1);
                }
            }

            [Register("EAN_ADDON_5")]
            public static BARCODE.TYPE EanAddon5
            {
                get
                {
                    if (EAN_ADDON_5_jfieldId == IntPtr.Zero)
                    {
                        EAN_ADDON_5_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "EAN_ADDON_5", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, EAN_ADDON_5_jfieldId), 1);
                }
            }

            [Register("EAN_PREFIX_378")]
            public static BARCODE.TYPE EanPrefix378
            {
                get
                {
                    if (EAN_PREFIX_378_jfieldId == IntPtr.Zero)
                    {
                        EAN_PREFIX_378_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "EAN_PREFIX_378", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, EAN_PREFIX_378_jfieldId), 1);
                }
            }

            [Register("EAN_PREFIX_434")]
            public static BARCODE.TYPE EanPrefix434
            {
                get
                {
                    if (EAN_PREFIX_434_jfieldId == IntPtr.Zero)
                    {
                        EAN_PREFIX_434_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "EAN_PREFIX_434", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, EAN_PREFIX_434_jfieldId), 1);
                }
            }

            [Register("GO_CODE")]
            public static BARCODE.TYPE GoCode
            {
                get
                {
                    if (GO_CODE_jfieldId == IntPtr.Zero)
                    {
                        GO_CODE_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "GO_CODE", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, GO_CODE_jfieldId), 1);
                }
            }

            [Register("GS1_128")]
            public static BARCODE.TYPE Gs1128
            {
                get
                {
                    if (GS1_128_jfieldId == IntPtr.Zero)
                    {
                        GS1_128_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "GS1_128", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, GS1_128_jfieldId), 1);
                }
            }

            [Register("GS1_DATABAR")]
            public static BARCODE.TYPE Gs1Databar
            {
                get
                {
                    if (GS1_DATABAR_jfieldId == IntPtr.Zero)
                    {
                        GS1_DATABAR_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "GS1_DATABAR", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, GS1_DATABAR_jfieldId), 1);
                }
            }

            [Register("GS1_DATABAR_14")]
            public static BARCODE.TYPE Gs1Databar14
            {
                get
                {
                    if (GS1_DATABAR_14_jfieldId == IntPtr.Zero)
                    {
                        GS1_DATABAR_14_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "GS1_DATABAR_14", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, GS1_DATABAR_14_jfieldId), 1);
                }
            }

            [Register("GS1_DATABAR_COUPON")]
            public static BARCODE.TYPE Gs1DatabarCoupon
            {
                get
                {
                    if (GS1_DATABAR_COUPON_jfieldId == IntPtr.Zero)
                    {
                        GS1_DATABAR_COUPON_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "GS1_DATABAR_COUPON", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, GS1_DATABAR_COUPON_jfieldId), 1);
                }
            }

            [Register("GS1_DATABAR_EXPANDED")]
            public static BARCODE.TYPE Gs1DatabarExpanded
            {
                get
                {
                    if (GS1_DATABAR_EXPANDED_jfieldId == IntPtr.Zero)
                    {
                        GS1_DATABAR_EXPANDED_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "GS1_DATABAR_EXPANDED", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, GS1_DATABAR_EXPANDED_jfieldId), 1);
                }
            }

            [Register("GS1_DATABAR_LIMITED")]
            public static BARCODE.TYPE Gs1DatabarLimited
            {
                get
                {
                    if (GS1_DATABAR_LIMITED_jfieldId == IntPtr.Zero)
                    {
                        GS1_DATABAR_LIMITED_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "GS1_DATABAR_LIMITED", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, GS1_DATABAR_LIMITED_jfieldId), 1);
                }
            }

            [Register("IATA")]
            public static BARCODE.TYPE Iata
            {
                get
                {
                    if (IATA_jfieldId == IntPtr.Zero)
                    {
                        IATA_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "IATA", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, IATA_jfieldId), 1);
                }
            }

            [Register("INDUSTRIAL_2OF5")]
            public static BARCODE.TYPE Industrial2of5
            {
                get
                {
                    if (INDUSTRIAL_2OF5_jfieldId == IntPtr.Zero)
                    {
                        INDUSTRIAL_2OF5_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "INDUSTRIAL_2OF5", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, INDUSTRIAL_2OF5_jfieldId), 1);
                }
            }

            [Register("INFO_MAIL")]
            public static BARCODE.TYPE InfoMail
            {
                get
                {
                    if (INFO_MAIL_jfieldId == IntPtr.Zero)
                    {
                        INFO_MAIL_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "INFO_MAIL", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, INFO_MAIL_jfieldId), 1);
                }
            }

            [Register("INTELLIGENT_MAIL")]
            public static BARCODE.TYPE IntelligentMail
            {
                get
                {
                    if (INTELLIGENT_MAIL_jfieldId == IntPtr.Zero)
                    {
                        INTELLIGENT_MAIL_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "INTELLIGENT_MAIL", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, INTELLIGENT_MAIL_jfieldId), 1);
                }
            }

            [Register("INTERLEAVED_2OF5")]
            public static BARCODE.TYPE Interleaved2of5
            {
                get
                {
                    if (INTERLEAVED_2OF5_jfieldId == IntPtr.Zero)
                    {
                        INTERLEAVED_2OF5_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "INTERLEAVED_2OF5", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, INTERLEAVED_2OF5_jfieldId), 1);
                }
            }

            [Register("ISBN")]
            public static BARCODE.TYPE Isbn
            {
                get
                {
                    if (ISBN_jfieldId == IntPtr.Zero)
                    {
                        ISBN_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ISBN", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, ISBN_jfieldId), 1);
                }
            }

            [Register("ISBT_128")]
            public static BARCODE.TYPE Isbt128
            {
                get
                {
                    if (ISBT_128_jfieldId == IntPtr.Zero)
                    {
                        ISBT_128_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ISBT_128", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, ISBT_128_jfieldId), 1);
                }
            }

            [Register("ISBT_128_CON")]
            public static BARCODE.TYPE Isbt128Con
            {
                get
                {
                    if (ISBT_128_CON_jfieldId == IntPtr.Zero)
                    {
                        ISBT_128_CON_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ISBT_128_CON", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, ISBT_128_CON_jfieldId), 1);
                }
            }

            [Register("ISMN")]
            public static BARCODE.TYPE Ismn
            {
                get
                {
                    if (ISMN_jfieldId == IntPtr.Zero)
                    {
                        ISMN_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ISMN", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, ISMN_jfieldId), 1);
                }
            }

            [Register("ISSN")]
            public static BARCODE.TYPE Issn
            {
                get
                {
                    if (ISSN_jfieldId == IntPtr.Zero)
                    {
                        ISSN_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ISSN", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, ISSN_jfieldId), 1);
                }
            }

            [Register("IT_PHARM")]
            public static BARCODE.TYPE ItPharm
            {
                get
                {
                    if (IT_PHARM_jfieldId == IntPtr.Zero)
                    {
                        IT_PHARM_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "IT_PHARM", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, IT_PHARM_jfieldId), 1);
                }
            }

            [Register("JAPANESE_POSTAL")]
            public static BARCODE.TYPE JapanesePostal
            {
                get
                {
                    if (JAPANESE_POSTAL_jfieldId == IntPtr.Zero)
                    {
                        JAPANESE_POSTAL_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "JAPANESE_POSTAL", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, JAPANESE_POSTAL_jfieldId), 1);
                }
            }

            [Register("KIX_CODE")]
            public static BARCODE.TYPE KixCode
            {
                get
                {
                    if (KIX_CODE_jfieldId == IntPtr.Zero)
                    {
                        KIX_CODE_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "KIX_CODE", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, KIX_CODE_jfieldId), 1);
                }
            }

            [Register("KOREAN_POST")]
            public static BARCODE.TYPE KoreanPost
            {
                get
                {
                    if (KOREAN_POST_jfieldId == IntPtr.Zero)
                    {
                        KOREAN_POST_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "KOREAN_POST", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, KOREAN_POST_jfieldId), 1);
                }
            }

            [Register("MACRO_MICRO_PDF")]
            public static BARCODE.TYPE MacroMicroPdf
            {
                get
                {
                    if (MACRO_MICRO_PDF_jfieldId == IntPtr.Zero)
                    {
                        MACRO_MICRO_PDF_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "MACRO_MICRO_PDF", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, MACRO_MICRO_PDF_jfieldId), 1);
                }
            }

            [Register("MACRO_PDF")]
            public static BARCODE.TYPE MacroPdf
            {
                get
                {
                    if (MACRO_PDF_jfieldId == IntPtr.Zero)
                    {
                        MACRO_PDF_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "MACRO_PDF", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, MACRO_PDF_jfieldId), 1);
                }
            }

            [Register("MACRO_QR")]
            public static BARCODE.TYPE MacroQr
            {
                get
                {
                    if (MACRO_QR_jfieldId == IntPtr.Zero)
                    {
                        MACRO_QR_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "MACRO_QR", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, MACRO_QR_jfieldId), 1);
                }
            }

            [Register("MATRIX_2OF5")]
            public static BARCODE.TYPE Matrix2of5
            {
                get
                {
                    if (MATRIX_2OF5_jfieldId == IntPtr.Zero)
                    {
                        MATRIX_2OF5_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "MATRIX_2OF5", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, MATRIX_2OF5_jfieldId), 1);
                }
            }

            [Register("MATRIX_3OF5")]
            public static BARCODE.TYPE Matrix3of5
            {
                get
                {
                    if (MATRIX_3OF5_jfieldId == IntPtr.Zero)
                    {
                        MATRIX_3OF5_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "MATRIX_3OF5", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, MATRIX_3OF5_jfieldId), 1);
                }
            }

            [Register("MATRIX_POST")]
            public static BARCODE.TYPE MatrixPost
            {
                get
                {
                    if (MATRIX_POST_jfieldId == IntPtr.Zero)
                    {
                        MATRIX_POST_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "MATRIX_POST", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, MATRIX_POST_jfieldId), 1);
                }
            }

            [Register("MAXICODE")]
            public static BARCODE.TYPE Maxicode
            {
                get
                {
                    if (MAXICODE_jfieldId == IntPtr.Zero)
                    {
                        MAXICODE_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "MAXICODE", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, MAXICODE_jfieldId), 1);
                }
            }

            [Register("MICRO_PDF")]
            public static BARCODE.TYPE MicroPdf
            {
                get
                {
                    if (MICRO_PDF_jfieldId == IntPtr.Zero)
                    {
                        MICRO_PDF_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "MICRO_PDF", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, MICRO_PDF_jfieldId), 1);
                }
            }

            [Register("MICRO_PDF_CCA")]
            public static BARCODE.TYPE MicroPdfCca
            {
                get
                {
                    if (MICRO_PDF_CCA_jfieldId == IntPtr.Zero)
                    {
                        MICRO_PDF_CCA_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "MICRO_PDF_CCA", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, MICRO_PDF_CCA_jfieldId), 1);
                }
            }

            [Register("MICRO_QR")]
            public static BARCODE.TYPE MicroQr
            {
                get
                {
                    if (MICRO_QR_jfieldId == IntPtr.Zero)
                    {
                        MICRO_QR_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "MICRO_QR", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, MICRO_QR_jfieldId), 1);
                }
            }

            [Register("MSI_PLESSEY")]
            public static BARCODE.TYPE MsiPlessey
            {
                get
                {
                    if (MSI_PLESSEY_jfieldId == IntPtr.Zero)
                    {
                        MSI_PLESSEY_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "MSI_PLESSEY", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, MSI_PLESSEY_jfieldId), 1);
                }
            }

            [Register("NEC_2OF5")]
            public static BARCODE.TYPE Nec2of5
            {
                get
                {
                    if (NEC_2OF5_jfieldId == IntPtr.Zero)
                    {
                        NEC_2OF5_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "NEC_2OF5", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, NEC_2OF5_jfieldId), 1);
                }
            }

            [Register("NW_7")]
            public static BARCODE.TYPE Nw7
            {
                get
                {
                    if (NW_7_jfieldId == IntPtr.Zero)
                    {
                        NW_7_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "NW_7", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, NW_7_jfieldId), 1);
                }
            }

            [Register("OCR")]
            public static BARCODE.TYPE Ocr
            {
                get
                {
                    if (OCR_jfieldId == IntPtr.Zero)
                    {
                        OCR_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "OCR", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, OCR_jfieldId), 1);
                }
            }

            [Register("ONE_CODE")]
            public static BARCODE.TYPE OneCode
            {
                get
                {
                    if (ONE_CODE_jfieldId == IntPtr.Zero)
                    {
                        ONE_CODE_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ONE_CODE", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, ONE_CODE_jfieldId), 1);
                }
            }

            [Register("PDF417")]
            public static BARCODE.TYPE Pdf417
            {
                get
                {
                    if (PDF417_jfieldId == IntPtr.Zero)
                    {
                        PDF417_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "PDF417", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, PDF417_jfieldId), 1);
                }
            }

            [Register("PHARMACODE")]
            public static BARCODE.TYPE Pharmacode
            {
                get
                {
                    if (PHARMACODE_jfieldId == IntPtr.Zero)
                    {
                        PHARMACODE_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "PHARMACODE", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, PHARMACODE_jfieldId), 1);
                }
            }

            [Register("POSI_CODE")]
            public static BARCODE.TYPE PosiCode
            {
                get
                {
                    if (POSI_CODE_jfieldId == IntPtr.Zero)
                    {
                        POSI_CODE_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "POSI_CODE", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, POSI_CODE_jfieldId), 1);
                }
            }

            [Register("POSTAL_4I")]
            public static BARCODE.TYPE Postal4i
            {
                get
                {
                    if (POSTAL_4I_jfieldId == IntPtr.Zero)
                    {
                        POSTAL_4I_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "POSTAL_4I", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, POSTAL_4I_jfieldId), 1);
                }
            }

            [Register("QR_CODE")]
            public static BARCODE.TYPE QrCode
            {
                get
                {
                    if (QR_CODE_jfieldId == IntPtr.Zero)
                    {
                        QR_CODE_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "QR_CODE", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, QR_CODE_jfieldId), 1);
                }
            }

            [Register("resId")]
            public int ResId
            {
                get
                {
                    if (resId_jfieldId == IntPtr.Zero)
                    {
                        resId_jfieldId = JNIEnv.GetFieldID(class_ref, "resId", "I");
                    }
                    return JNIEnv.GetIntField(base.get_Handle(), resId_jfieldId);
                }
                set
                {
                    if (resId_jfieldId == IntPtr.Zero)
                    {
                        resId_jfieldId = JNIEnv.GetFieldID(class_ref, "resId", "I");
                    }
                    try
                    {
                        JNIEnv.SetField(base.get_Handle(), resId_jfieldId, value);
                    }
                    finally
                    {
                    }
                }
            }

            [Register("ROYAL_MAIL")]
            public static BARCODE.TYPE RoyalMail
            {
                get
                {
                    if (ROYAL_MAIL_jfieldId == IntPtr.Zero)
                    {
                        ROYAL_MAIL_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "ROYAL_MAIL", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, ROYAL_MAIL_jfieldId), 1);
                }
            }

            [Register("SCANLET")]
            public static BARCODE.TYPE Scanlet
            {
                get
                {
                    if (SCANLET_jfieldId == IntPtr.Zero)
                    {
                        SCANLET_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "SCANLET", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, SCANLET_jfieldId), 1);
                }
            }

            [Register("S_CODE")]
            public static BARCODE.TYPE SCode
            {
                get
                {
                    if (S_CODE_jfieldId == IntPtr.Zero)
                    {
                        S_CODE_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "S_CODE", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, S_CODE_jfieldId), 1);
                }
            }

            [Register("SIGNATURE_CAPTURE")]
            public static BARCODE.TYPE SignatureCapture
            {
                get
                {
                    if (SIGNATURE_CAPTURE_jfieldId == IntPtr.Zero)
                    {
                        SIGNATURE_CAPTURE_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "SIGNATURE_CAPTURE", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, SIGNATURE_CAPTURE_jfieldId), 1);
                }
            }

            [Register("TELEPEN")]
            public static BARCODE.TYPE Telepen
            {
                get
                {
                    if (TELEPEN_jfieldId == IntPtr.Zero)
                    {
                        TELEPEN_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "TELEPEN", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, TELEPEN_jfieldId), 1);
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
                    return typeof(BARCODE.TYPE);
                }
            }

            [Register("TLC_39")]
            public static BARCODE.TYPE Tlc39
            {
                get
                {
                    if (TLC_39_jfieldId == IntPtr.Zero)
                    {
                        TLC_39_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "TLC_39", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, TLC_39_jfieldId), 1);
                }
            }

            [Register("TRIOPTIC")]
            public static BARCODE.TYPE Trioptic
            {
                get
                {
                    if (TRIOPTIC_jfieldId == IntPtr.Zero)
                    {
                        TRIOPTIC_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "TRIOPTIC", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, TRIOPTIC_jfieldId), 1);
                }
            }

            [Register("UK_PLESSEY")]
            public static BARCODE.TYPE UkPlessey
            {
                get
                {
                    if (UK_PLESSEY_jfieldId == IntPtr.Zero)
                    {
                        UK_PLESSEY_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UK_PLESSEY", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UK_PLESSEY_jfieldId), 1);
                }
            }

            [Register("UK_POSTAL")]
            public static BARCODE.TYPE UkPostal
            {
                get
                {
                    if (UK_POSTAL_jfieldId == IntPtr.Zero)
                    {
                        UK_POSTAL_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UK_POSTAL", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UK_POSTAL_jfieldId), 1);
                }
            }

            [Register("UNKNOWN")]
            public static BARCODE.TYPE Unknown
            {
                get
                {
                    if (UNKNOWN_jfieldId == IntPtr.Zero)
                    {
                        UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UNKNOWN", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UNKNOWN_jfieldId), 1);
                }
            }

            [Register("UPC")]
            public static BARCODE.TYPE Upc
            {
                get
                {
                    if (UPC_jfieldId == IntPtr.Zero)
                    {
                        UPC_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_jfieldId), 1);
                }
            }

            [Register("UPC_A")]
            public static BARCODE.TYPE UpcA
            {
                get
                {
                    if (UPC_A_jfieldId == IntPtr.Zero)
                    {
                        UPC_A_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_A", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_A_jfieldId), 1);
                }
            }

            [Register("UPC_A_ADDON")]
            public static BARCODE.TYPE UpcAAddon
            {
                get
                {
                    if (UPC_A_ADDON_jfieldId == IntPtr.Zero)
                    {
                        UPC_A_ADDON_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_A_ADDON", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_A_ADDON_jfieldId), 1);
                }
            }

            [Register("UPC_A_ADDON_2")]
            public static BARCODE.TYPE UpcAAddon2
            {
                get
                {
                    if (UPC_A_ADDON_2_jfieldId == IntPtr.Zero)
                    {
                        UPC_A_ADDON_2_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_A_ADDON_2", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_A_ADDON_2_jfieldId), 1);
                }
            }

            [Register("UPC_A_ADDON_5")]
            public static BARCODE.TYPE UpcAAddon5
            {
                get
                {
                    if (UPC_A_ADDON_5_jfieldId == IntPtr.Zero)
                    {
                        UPC_A_ADDON_5_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_A_ADDON_5", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_A_ADDON_5_jfieldId), 1);
                }
            }

            [Register("UPC_ADDON_2")]
            public static BARCODE.TYPE UpcAddon2
            {
                get
                {
                    if (UPC_ADDON_2_jfieldId == IntPtr.Zero)
                    {
                        UPC_ADDON_2_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_ADDON_2", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_ADDON_2_jfieldId), 1);
                }
            }

            [Register("UPC_ADDON_5")]
            public static BARCODE.TYPE UpcAddon5
            {
                get
                {
                    if (UPC_ADDON_5_jfieldId == IntPtr.Zero)
                    {
                        UPC_ADDON_5_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_ADDON_5", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_ADDON_5_jfieldId), 1);
                }
            }

            [Register("UPC_D")]
            public static BARCODE.TYPE UpcD
            {
                get
                {
                    if (UPC_D_jfieldId == IntPtr.Zero)
                    {
                        UPC_D_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_D", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_D_jfieldId), 1);
                }
            }

            [Register("UPC_E")]
            public static BARCODE.TYPE UpcE
            {
                get
                {
                    if (UPC_E_jfieldId == IntPtr.Zero)
                    {
                        UPC_E_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_E", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_E_jfieldId), 1);
                }
            }

            [Register("UPC_E0")]
            public static BARCODE.TYPE UpcE0
            {
                get
                {
                    if (UPC_E0_jfieldId == IntPtr.Zero)
                    {
                        UPC_E0_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_E0", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_E0_jfieldId), 1);
                }
            }

            [Register("UPC_E0_ADDON_2")]
            public static BARCODE.TYPE UpcE0Addon2
            {
                get
                {
                    if (UPC_E0_ADDON_2_jfieldId == IntPtr.Zero)
                    {
                        UPC_E0_ADDON_2_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_E0_ADDON_2", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_E0_ADDON_2_jfieldId), 1);
                }
            }

            [Register("UPC_E0_ADDON_5")]
            public static BARCODE.TYPE UpcE0Addon5
            {
                get
                {
                    if (UPC_E0_ADDON_5_jfieldId == IntPtr.Zero)
                    {
                        UPC_E0_ADDON_5_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_E0_ADDON_5", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_E0_ADDON_5_jfieldId), 1);
                }
            }

            [Register("UPC_E1")]
            public static BARCODE.TYPE UpcE1
            {
                get
                {
                    if (UPC_E1_jfieldId == IntPtr.Zero)
                    {
                        UPC_E1_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_E1", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_E1_jfieldId), 1);
                }
            }

            [Register("UPC_E1_ADDON_5")]
            public static BARCODE.TYPE UpcE1Addon5
            {
                get
                {
                    if (UPC_E1_ADDON_5_jfieldId == IntPtr.Zero)
                    {
                        UPC_E1_ADDON_5_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_E1_ADDON_5", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_E1_ADDON_5_jfieldId), 1);
                }
            }

            [Register("UPC_E_ADDON")]
            public static BARCODE.TYPE UpcEAddon
            {
                get
                {
                    if (UPC_E_ADDON_jfieldId == IntPtr.Zero)
                    {
                        UPC_E_ADDON_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_E_ADDON", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_E_ADDON_jfieldId), 1);
                }
            }

            [Register("UPC_E_ADDON_2")]
            public static BARCODE.TYPE UpcEAddon2
            {
                get
                {
                    if (UPC_E_ADDON_2_jfieldId == IntPtr.Zero)
                    {
                        UPC_E_ADDON_2_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_E_ADDON_2", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_E_ADDON_2_jfieldId), 1);
                }
            }

            [Register("UPC_E_ADDON_5")]
            public static BARCODE.TYPE UpcEAddon5
            {
                get
                {
                    if (UPC_E_ADDON_5_jfieldId == IntPtr.Zero)
                    {
                        UPC_E_ADDON_5_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_E_ADDON_5", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_E_ADDON_5_jfieldId), 1);
                }
            }

            [Register("UPC_EAN")]
            public static BARCODE.TYPE UpcEan
            {
                get
                {
                    if (UPC_EAN_jfieldId == IntPtr.Zero)
                    {
                        UPC_EAN_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_EAN", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_EAN_jfieldId), 1);
                }
            }

            [Register("UPC_EAN13_E0")]
            public static BARCODE.TYPE UpcEan13E0
            {
                get
                {
                    if (UPC_EAN13_E0_jfieldId == IntPtr.Zero)
                    {
                        UPC_EAN13_E0_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_EAN13_E0", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_EAN13_E0_jfieldId), 1);
                }
            }

            [Register("UPC_EAN13_E0_ADDON")]
            public static BARCODE.TYPE UpcEan13E0Addon
            {
                get
                {
                    if (UPC_EAN13_E0_ADDON_jfieldId == IntPtr.Zero)
                    {
                        UPC_EAN13_E0_ADDON_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPC_EAN13_E0_ADDON", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPC_EAN13_E0_ADDON_jfieldId), 1);
                }
            }

            [Register("UPU_4STATE")]
            public static BARCODE.TYPE Upu4state
            {
                get
                {
                    if (UPU_4STATE_jfieldId == IntPtr.Zero)
                    {
                        UPU_4STATE_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPU_4STATE", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPU_4STATE_jfieldId), 1);
                }
            }

            [Register("UPU_FICS_POSTAL")]
            public static BARCODE.TYPE UpuFicsPostal
            {
                get
                {
                    if (UPU_FICS_POSTAL_jfieldId == IntPtr.Zero)
                    {
                        UPU_FICS_POSTAL_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPU_FICS_POSTAL", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPU_FICS_POSTAL_jfieldId), 1);
                }
            }

            [Register("UPU_ID_TAG_POSTAL")]
            public static BARCODE.TYPE UpuIdTagPostal
            {
                get
                {
                    if (UPU_ID_TAG_POSTAL_jfieldId == IntPtr.Zero)
                    {
                        UPU_ID_TAG_POSTAL_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "UPU_ID_TAG_POSTAL", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, UPU_ID_TAG_POSTAL_jfieldId), 1);
                }
            }

            [Register("US_PLANET")]
            public static BARCODE.TYPE UsPlanet
            {
                get
                {
                    if (US_PLANET_jfieldId == IntPtr.Zero)
                    {
                        US_PLANET_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "US_PLANET", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, US_PLANET_jfieldId), 1);
                }
            }

            [Register("US_POSTNET")]
            public static BARCODE.TYPE UsPostnet
            {
                get
                {
                    if (US_POSTNET_jfieldId == IntPtr.Zero)
                    {
                        US_POSTNET_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "US_POSTNET", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, US_POSTNET_jfieldId), 1);
                }
            }

            [Register("USPS_4CB")]
            public static BARCODE.TYPE Usps4cb
            {
                get
                {
                    if (USPS_4CB_jfieldId == IntPtr.Zero)
                    {
                        USPS_4CB_jfieldId = JNIEnv.GetStaticFieldID(class_ref, "USPS_4CB", "Lcom/lib/bcr/utils/BARCODE$TYPE;");
                    }
                    return Object.GetObject<BARCODE.TYPE>(JNIEnv.GetStaticObjectField(class_ref, USPS_4CB_jfieldId), 1);
                }
            }
        }
    }
}

