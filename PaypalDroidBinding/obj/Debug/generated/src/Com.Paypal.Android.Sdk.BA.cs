using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='bA']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/bA", DoNotGenerateAcw=true)]
	public sealed partial class BA : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/bA", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BA); }
		}

		internal BA (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='bA']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/paypal/android/sdk/bB;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.BB A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Lcom/paypal/android/sdk/bB;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.BB> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_a_Lcom_paypal_android_sdk_bB_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='bA']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.paypal.android.sdk.bB']]"
		[Register ("a", "(Lcom/paypal/android/sdk/bB;)V", "")]
		public unsafe void A (global::Com.Paypal.Android.Sdk.BB p0)
		{
			if (id_a_Lcom_paypal_android_sdk_bB_ == IntPtr.Zero)
				id_a_Lcom_paypal_android_sdk_bB_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/paypal/android/sdk/bB;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Lcom_paypal_android_sdk_bB_, __args);
			} finally {
			}
		}

		static IntPtr id_a_Lcom_paypal_android_sdk_bF_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='bA']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.paypal.android.sdk.bF'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Lcom/paypal/android/sdk/bF;Ljava/lang/String;)V", "")]
		public unsafe void A (global::Com.Paypal.Android.Sdk.BF p0, string p1)
		{
			if (id_a_Lcom_paypal_android_sdk_bF_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Lcom_paypal_android_sdk_bF_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/paypal/android/sdk/bF;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Lcom_paypal_android_sdk_bF_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='bA']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)Lcom/paypal/android/sdk/bF;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.BF A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)Lcom/paypal/android/sdk/bF;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.BF __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.BF> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='bA']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "")]
		public unsafe void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_b);
			} finally {
			}
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='bA']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "")]
		public unsafe void C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_c);
			} finally {
			}
		}

	}
}
