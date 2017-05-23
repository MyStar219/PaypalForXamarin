using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cC']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/cC", DoNotGenerateAcw=true)]
	public partial class CC : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/cC", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CC); }
		}

		protected CC (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cC']/constructor[@name='cC' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CC ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CC)) {
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

		static IntPtr id_a_Lcom_paypal_android_sdk_aB_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cC']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.paypal.android.sdk.aB']]"
		[Register ("a", "(Lcom/paypal/android/sdk/aB;)Lcom/paypal/android/sdk/aB;", "")]
		public static unsafe global::Com.Paypal.Android.Sdk.AB A (global::Com.Paypal.Android.Sdk.AB p0)
		{
			if (id_a_Lcom_paypal_android_sdk_aB_ == IntPtr.Zero)
				id_a_Lcom_paypal_android_sdk_aB_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lcom/paypal/android/sdk/aB;)Lcom/paypal/android/sdk/aB;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Paypal.Android.Sdk.AB __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.AB> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Lcom_paypal_android_sdk_aB_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
