using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aZ']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/aZ", DoNotGenerateAcw=true)]
	public sealed partial class AZ : global::Org.Apache.Http.Conn.Ssl.SSLSocketFactory {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/aZ", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AZ); }
		}

		internal AZ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aZ']/constructor[@name='aZ' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AZ ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AZ)) {
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

		static IntPtr id_getHostnameVerifier;
		static IntPtr id_setHostnameVerifier_Lorg_apache_http_conn_ssl_X509HostnameVerifier_;
		public override unsafe global::Org.Apache.Http.Conn.Ssl.IX509HostnameVerifier HostnameVerifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aZ']/method[@name='getHostnameVerifier' and count(parameter)=0]"
			[Register ("getHostnameVerifier", "()Lorg/apache/http/conn/ssl/X509HostnameVerifier;", "GetGetHostnameVerifierHandler")]
			get {
				if (id_getHostnameVerifier == IntPtr.Zero)
					id_getHostnameVerifier = JNIEnv.GetMethodID (class_ref, "getHostnameVerifier", "()Lorg/apache/http/conn/ssl/X509HostnameVerifier;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Conn.Ssl.IX509HostnameVerifier> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHostnameVerifier), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aZ']/method[@name='setHostnameVerifier' and count(parameter)=1 and parameter[1][@type='org.apache.http.conn.ssl.X509HostnameVerifier']]"
			[Register ("setHostnameVerifier", "(Lorg/apache/http/conn/ssl/X509HostnameVerifier;)V", "GetSetHostnameVerifier_Lorg_apache_http_conn_ssl_X509HostnameVerifier_Handler")]
			set {
				if (id_setHostnameVerifier_Lorg_apache_http_conn_ssl_X509HostnameVerifier_ == IntPtr.Zero)
					id_setHostnameVerifier_Lorg_apache_http_conn_ssl_X509HostnameVerifier_ = JNIEnv.GetMethodID (class_ref, "setHostnameVerifier", "(Lorg/apache/http/conn/ssl/X509HostnameVerifier;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHostnameVerifier_Lorg_apache_http_conn_ssl_X509HostnameVerifier_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_connectSocket_Ljava_net_Socket_Ljava_lang_String_ILjava_net_InetAddress_ILorg_apache_http_params_HttpParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aZ']/method[@name='connectSocket' and count(parameter)=6 and parameter[1][@type='java.net.Socket'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.net.InetAddress'] and parameter[5][@type='int'] and parameter[6][@type='org.apache.http.params.HttpParams']]"
		[Register ("connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/params/HttpParams;)Ljava/net/Socket;", "")]
		public override sealed unsafe global::Java.Net.Socket ConnectSocket (global::Java.Net.Socket p0, string p1, int p2, global::Java.Net.InetAddress p3, int p4, global::Org.Apache.Http.Params.IHttpParams p5)
		{
			if (id_connectSocket_Ljava_net_Socket_Ljava_lang_String_ILjava_net_InetAddress_ILorg_apache_http_params_HttpParams_ == IntPtr.Zero)
				id_connectSocket_Ljava_net_Socket_Ljava_lang_String_ILjava_net_InetAddress_ILorg_apache_http_params_HttpParams_ = JNIEnv.GetMethodID (class_ref, "connectSocket", "(Ljava/net/Socket;Ljava/lang/String;ILjava/net/InetAddress;ILorg/apache/http/params/HttpParams;)Ljava/net/Socket;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				global::Java.Net.Socket __ret = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connectSocket_Ljava_net_Socket_Ljava_lang_String_ILjava_net_InetAddress_ILorg_apache_http_params_HttpParams_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_createSocket;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aZ']/method[@name='createSocket' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='aZ']/method[@name='createSocket' and count(parameter)=4 and parameter[1][@type='java.net.Socket'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
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
