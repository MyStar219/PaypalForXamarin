using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aM']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/aM", DoNotGenerateAcw=true)]
	public sealed partial class AM : global::Org.Apache.Http.Conn.Ssl.SSLSocketFactory {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/aM", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AM); }
		}

		internal AM (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aM']/constructor[@name='aM' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AM ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AM)) {
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

		static IntPtr id_createSocket;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aM']/method[@name='createSocket' and count(parameter)=0]"
		[Register ("createSocket", "()Ljava/net/Socket;", "")]
		public override sealed unsafe global::Java.Net.Socket CreateSocket ()
		{
			if (id_createSocket == IntPtr.Zero)
				id_createSocket = JNIEnv.GetMethodID (class_ref, "createSocket", "()Ljava/net/Socket;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createSocket), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createSocket_Ljava_net_Socket_Ljava_lang_String_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aM']/method[@name='createSocket' and count(parameter)=4 and parameter[1][@type='java.net.Socket'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;", "")]
		public override sealed unsafe global::Java.Net.Socket CreateSocket (global::Java.Net.Socket p0, string p1, int p2, bool p3)
		{
			if (id_createSocket_Ljava_net_Socket_Ljava_lang_String_IZ == IntPtr.Zero)
				id_createSocket_Ljava_net_Socket_Ljava_lang_String_IZ = JNIEnv.GetMethodID (class_ref, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Java.Net.Socket __ret = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createSocket_Ljava_net_Socket_Ljava_lang_String_IZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
