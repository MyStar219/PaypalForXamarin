using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Q']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/Q", DoNotGenerateAcw=true)]
	public partial class Q : global::Com.Paypal.Android.Sdk.T {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/Q", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Q); }
		}

		protected Q (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Q']/constructor[@name='Q' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Q ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Q)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_a_Ljava_lang_String_Lcom_paypal_android_sdk_R_Lcom_paypal_android_sdk_S_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Q']/method[@name='a' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.paypal.android.sdk.R'] and parameter[3][@type='com.paypal.android.sdk.S'] and parameter[4][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Lcom/paypal/android/sdk/R;Lcom/paypal/android/sdk/S;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public unsafe global::Android.Content.Intent A (string p0, global::Com.Paypal.Android.Sdk.R p1, global::Com.Paypal.Android.Sdk.S p2, string p3)
		{
			if (id_a_Ljava_lang_String_Lcom_paypal_android_sdk_R_Lcom_paypal_android_sdk_S_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Lcom_paypal_android_sdk_R_Lcom_paypal_android_sdk_S_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Lcom/paypal/android/sdk/R;Lcom/paypal/android/sdk/S;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a_Ljava_lang_String_Lcom_paypal_android_sdk_R_Lcom_paypal_android_sdk_S_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_b_Ljava_lang_String_Lcom_paypal_android_sdk_R_Lcom_paypal_android_sdk_S_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Q']/method[@name='b' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.paypal.android.sdk.R'] and parameter[3][@type='com.paypal.android.sdk.S'] and parameter[4][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;Lcom/paypal/android/sdk/R;Lcom/paypal/android/sdk/S;Ljava/lang/String;)Landroid/content/Intent;", "")]
		public unsafe global::Android.Content.Intent B (string p0, global::Com.Paypal.Android.Sdk.R p1, global::Com.Paypal.Android.Sdk.S p2, string p3)
		{
			if (id_b_Ljava_lang_String_Lcom_paypal_android_sdk_R_Lcom_paypal_android_sdk_S_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Ljava_lang_String_Lcom_paypal_android_sdk_R_Lcom_paypal_android_sdk_S_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/String;Lcom/paypal/android/sdk/R;Lcom/paypal/android/sdk/S;Ljava/lang/String;)Landroid/content/Intent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_b_Ljava_lang_String_Lcom_paypal_android_sdk_R_Lcom_paypal_android_sdk_S_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
