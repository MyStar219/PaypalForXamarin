using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk.Payments {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalFuturePaymentActivity']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/payments/PayPalFuturePaymentActivity", DoNotGenerateAcw=true)]
	public sealed partial class PayPalFuturePaymentActivity : global::Android.App.Activity {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalFuturePaymentActivity']/field[@name='EXTRA_RESULT_AUTHORIZATION']"
		[Register ("EXTRA_RESULT_AUTHORIZATION")]
		public const string ExtraResultAuthorization = (string) "com.paypal.android.sdk.authorization";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalFuturePaymentActivity']/field[@name='RESULT_EXTRAS_INVALID']"
		[Register ("RESULT_EXTRAS_INVALID")]
		public const int ResultExtrasInvalid = (int) 2;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/payments/PayPalFuturePaymentActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayPalFuturePaymentActivity); }
		}

		internal PayPalFuturePaymentActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalFuturePaymentActivity']/constructor[@name='PayPalFuturePaymentActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PayPalFuturePaymentActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PayPalFuturePaymentActivity)) {
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

		static IntPtr id_finish;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalFuturePaymentActivity']/method[@name='finish' and count(parameter)=0]"
		[Register ("finish", "()V", "")]
		public override sealed unsafe void Finish ()
		{
			if (id_finish == IntPtr.Zero)
				id_finish = JNIEnv.GetMethodID (class_ref, "finish", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finish);
			} finally {
			}
		}

		static IntPtr id_onActivityResult_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalFuturePaymentActivity']/method[@name='onActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("onActivityResult", "(IILandroid/content/Intent;)V", "")]
		protected override sealed unsafe void OnActivityResult (int p0, [global::Android.Runtime.GeneratedEnum] global::Android.App.Result p1, global::Android.Content.Intent p2)
		{
			if (id_onActivityResult_IILandroid_content_Intent_ == IntPtr.Zero)
				id_onActivityResult_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onActivityResult", "(IILandroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityResult_IILandroid_content_Intent_, __args);
			} finally {
			}
		}

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalFuturePaymentActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "")]
		protected override sealed unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_onCreateDialog_ILandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalFuturePaymentActivity']/method[@name='onCreateDialog' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onCreateDialog", "(ILandroid/os/Bundle;)Landroid/app/Dialog;", "")]
		protected override sealed unsafe global::Android.App.Dialog OnCreateDialog (int p0, global::Android.OS.Bundle p1)
		{
			if (id_onCreateDialog_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_onCreateDialog_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreateDialog", "(ILandroid/os/Bundle;)Landroid/app/Dialog;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.App.Dialog __ret = global::Java.Lang.Object.GetObject<global::Android.App.Dialog> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCreateDialog_ILandroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalFuturePaymentActivity']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "")]
		protected override sealed unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroy);
			} finally {
			}
		}

	}
}
