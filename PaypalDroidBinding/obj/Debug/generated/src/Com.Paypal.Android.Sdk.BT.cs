using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='bT']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/bT", DoNotGenerateAcw=true)]
	public sealed partial class BT : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/bT", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BT); }
		}

		internal BT (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a_DLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='bT']/method[@name='a' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(DLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string A (double p0, string p1)
		{
			if (id_a_DLjava_lang_String_ == IntPtr.Zero)
				id_a_DLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(DLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_DLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_a_DLjava_util_Currency_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='bT']/method[@name='a' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='java.util.Currency']]"
		[Register ("a", "(DLjava/util/Currency;)Ljava/lang/String;", "")]
		public static unsafe string A (double p0, global::Java.Util.Currency p1)
		{
			if (id_a_DLjava_util_Currency_ == IntPtr.Zero)
				id_a_DLjava_util_Currency_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(DLjava/util/Currency;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_DLjava_util_Currency_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='bT']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_a_Ljava_math_BigDecimal_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='bT']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.math.BigDecimal'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("a", "(Ljava/math/BigDecimal;Ljava/lang/String;Z)Z", "")]
		public static unsafe bool A (global::Java.Math.BigDecimal p0, string p1, bool p2)
		{
			if (id_a_Ljava_math_BigDecimal_Ljava_lang_String_Z == IntPtr.Zero)
				id_a_Ljava_math_BigDecimal_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/math/BigDecimal;Ljava/lang/String;Z)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Ljava_math_BigDecimal_Ljava_lang_String_Z, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_a_Ljava_util_Locale_DLjava_util_Currency_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='bT']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.util.Locale'] and parameter[2][@type='double'] and parameter[3][@type='java.util.Currency']]"
		[Register ("a", "(Ljava/util/Locale;DLjava/util/Currency;)Ljava/lang/String;", "")]
		public static unsafe string A (global::Java.Util.Locale p0, double p1, global::Java.Util.Currency p2)
		{
			if (id_a_Ljava_util_Locale_DLjava_util_Currency_ == IntPtr.Zero)
				id_a_Ljava_util_Locale_DLjava_util_Currency_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/util/Locale;DLjava/util/Currency;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_util_Locale_DLjava_util_Currency_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_a_Ljava_util_Locale_Ljava_lang_String_DLjava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='bT']/method[@name='a' and count(parameter)=5 and parameter[1][@type='java.util.Locale'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean']]"
		[Register ("a", "(Ljava/util/Locale;Ljava/lang/String;DLjava/lang/String;Z)Ljava/lang/String;", "")]
		public static unsafe string A (global::Java.Util.Locale p0, string p1, double p2, string p3, bool p4)
		{
			if (id_a_Ljava_util_Locale_Ljava_lang_String_DLjava_lang_String_Z == IntPtr.Zero)
				id_a_Ljava_util_Locale_Ljava_lang_String_DLjava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/util/Locale;Ljava/lang/String;DLjava/lang/String;Z)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_util_Locale_Ljava_lang_String_DLjava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
