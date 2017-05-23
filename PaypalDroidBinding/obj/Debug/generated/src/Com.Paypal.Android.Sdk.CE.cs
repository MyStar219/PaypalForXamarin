using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cE']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/cE", DoNotGenerateAcw=true)]
	public sealed partial class CE : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/cE", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CE); }
		}

		internal CE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a_Lcom_paypal_android_sdk_cG_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cE']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.paypal.android.sdk.cG']]"
		[Register ("a", "(Lcom/paypal/android/sdk/cG;)Ljava/lang/String;", "")]
		public static unsafe string A (global::Com.Paypal.Android.Sdk.CG p0)
		{
			if (id_a_Lcom_paypal_android_sdk_cG_ == IntPtr.Zero)
				id_a_Lcom_paypal_android_sdk_cG_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/paypal/android/sdk/cG;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Lcom_paypal_android_sdk_cG_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cE']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_b_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cE']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;)V", "")]
		public static unsafe void B (string p0)
		{
			if (id_b_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_c_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cE']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("c", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string C (string p0)
		{
			if (id_c_Ljava_lang_String_ == IntPtr.Zero)
				id_c_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_c_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
