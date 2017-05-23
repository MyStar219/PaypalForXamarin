using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aL']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/aL", DoNotGenerateAcw=true)]
	public sealed partial class AL : global::Java.Lang.Object, global::Javax.Net.Ssl.IX509TrustManager {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/aL", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AL); }
		}

		internal AL (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aL']/constructor[@name='aL' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AL ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AL)) {
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

		static IntPtr id_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aL']/method[@name='checkClientTrusted' and count(parameter)=2 and parameter[1][@type='java.security.cert.X509Certificate[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "")]
		public unsafe void CheckClientTrusted (global::Java.Security.Cert.X509Certificate[] p0, string p1)
		{
			if (id_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == IntPtr.Zero)
				id_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aL']/method[@name='checkServerTrusted' and count(parameter)=2 and parameter[1][@type='java.security.cert.X509Certificate[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V", "")]
		public unsafe void CheckServerTrusted (global::Java.Security.Cert.X509Certificate[] p0, string p1)
		{
			if (id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == IntPtr.Zero)
				id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getAcceptedIssuers;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aL']/method[@name='getAcceptedIssuers' and count(parameter)=0]"
		[Register ("getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;", "")]
		public unsafe global::Java.Security.Cert.X509Certificate[] GetAcceptedIssuers ()
		{
			if (id_getAcceptedIssuers == IntPtr.Zero)
				id_getAcceptedIssuers = JNIEnv.GetMethodID (class_ref, "getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;");
			try {
				return (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAcceptedIssuers), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.X509Certificate));
			} finally {
			}
		}

	}
}
