using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk.Payments {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalService']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/payments/PayPalService", DoNotGenerateAcw=true)]
	public sealed partial class PayPalService : global::Android.App.Service {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalService']/field[@name='EXTRA_PAYPAL_CONFIGURATION']"
		[Register ("EXTRA_PAYPAL_CONFIGURATION")]
		public const string ExtraPaypalConfiguration = (string) "com.paypal.android.sdk.paypalConfiguration";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/payments/PayPalService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayPalService); }
		}

		internal PayPalService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalService']/constructor[@name='PayPalService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PayPalService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PayPalService)) {
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

		static IntPtr id_clearAllUserData_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalService']/method[@name='clearAllUserData' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearAllUserData", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearAllUserData (global::Android.Content.Context p0)
		{
			if (id_clearAllUserData_Landroid_content_Context_ == IntPtr.Zero)
				id_clearAllUserData_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "clearAllUserData", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearAllUserData_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_doDeleteTokenizedCreditCard_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalService']/method[@name='doDeleteTokenizedCreditCard' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("doDeleteTokenizedCreditCard", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void DoDeleteTokenizedCreditCard (string p0, string p1)
		{
			if (id_doDeleteTokenizedCreditCard_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_doDeleteTokenizedCreditCard_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "doDeleteTokenizedCreditCard", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doDeleteTokenizedCreditCard_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_doTrackingRequest_Lcom_paypal_android_sdk_aB_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalService']/method[@name='doTrackingRequest' and count(parameter)=1 and parameter[1][@type='com.paypal.android.sdk.aB']]"
		[Register ("doTrackingRequest", "(Lcom/paypal/android/sdk/aB;)V", "")]
		public unsafe void DoTrackingRequest (global::Com.Paypal.Android.Sdk.AB p0)
		{
			if (id_doTrackingRequest_Lcom_paypal_android_sdk_aB_ == IntPtr.Zero)
				id_doTrackingRequest_Lcom_paypal_android_sdk_aB_ = JNIEnv.GetMethodID (class_ref, "doTrackingRequest", "(Lcom/paypal/android/sdk/aB;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doTrackingRequest_Lcom_paypal_android_sdk_aB_, __args);
			} finally {
			}
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalService']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Ljava/lang/String;", "")]
		protected unsafe string E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_e), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalService']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Ljava/lang/String;", "")]
		protected unsafe string F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_f), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_onBind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "")]
		public override sealed unsafe global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			if (id_onBind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onBind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.OS.IBinder __ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onBind_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onCreate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalService']/method[@name='onCreate' and count(parameter)=0]"
		[Register ("onCreate", "()V", "")]
		public override sealed unsafe void OnCreate ()
		{
			if (id_onCreate == IntPtr.Zero)
				id_onCreate = JNIEnv.GetMethodID (class_ref, "onCreate", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate);
			} finally {
			}
		}

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalService']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "")]
		public override sealed unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroy);
			} finally {
			}
		}

		static IntPtr id_onRebind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalService']/method[@name='onRebind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onRebind", "(Landroid/content/Intent;)V", "")]
		public override sealed unsafe void OnRebind (global::Android.Content.Intent p0)
		{
			if (id_onRebind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onRebind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onRebind", "(Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRebind_Landroid_content_Intent_, __args);
			} finally {
			}
		}

		static IntPtr id_onStartCommand_Landroid_content_Intent_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalService']/method[@name='onStartCommand' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onStartCommand", "(Landroid/content/Intent;II)I", "")]
		public override sealed unsafe global::Android.App.StartCommandResult OnStartCommand (global::Android.Content.Intent p0, [global::Android.Runtime.GeneratedEnum] global::Android.App.StartCommandFlags p1, int p2)
		{
			if (id_onStartCommand_Landroid_content_Intent_II == IntPtr.Zero)
				id_onStartCommand_Landroid_content_Intent_II = JNIEnv.GetMethodID (class_ref, "onStartCommand", "(Landroid/content/Intent;II)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				__args [2] = new JValue (p2);
				global::Android.App.StartCommandResult __ret = (global::Android.App.StartCommandResult) JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_onStartCommand_Landroid_content_Intent_II, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onUnbind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalService']/method[@name='onUnbind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onUnbind", "(Landroid/content/Intent;)Z", "")]
		public override sealed unsafe bool OnUnbind (global::Android.Content.Intent p0)
		{
			if (id_onUnbind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onUnbind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onUnbind", "(Landroid/content/Intent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onUnbind_Landroid_content_Intent_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_v;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalService']/method[@name='v' and count(parameter)=0]"
		[Register ("v", "()Ljava/lang/String;", "")]
		protected unsafe string V ()
		{
			if (id_v == IntPtr.Zero)
				id_v = JNIEnv.GetMethodID (class_ref, "v", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_v), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
