using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cJ']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/cJ", DoNotGenerateAcw=true)]
	public sealed partial class CJ : global::Java.Lang.Object, global::Com.Paypal.Android.Sdk.ICY {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/cJ", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CJ); }
		}

		internal CJ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cJ']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "")]
		public unsafe string A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_a_Lorg_json_JSONObject_Lorg_json_JSONArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cJ']/method[@name='a' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONArray']]"
		[Register ("a", "(Lorg/json/JSONObject;Lorg/json/JSONArray;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.IList A (global::Org.Json.JSONObject p0, global::Org.Json.JSONArray p1)
		{
			if (id_a_Lorg_json_JSONObject_Lorg_json_JSONArray_ == IntPtr.Zero)
				id_a_Lorg_json_JSONObject_Lorg_json_JSONArray_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lorg/json/JSONObject;Lorg/json/JSONArray;)Ljava/util/ArrayList;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Lorg_json_JSONObject_Lorg_json_JSONArray_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cJ']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/lang/String;", "")]
		public unsafe string B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_b), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cJ']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/String;", "")]
		public unsafe string C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_c), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cJ']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Ljava/lang/String;", "")]
		public unsafe string D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_d), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cJ']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Z", "")]
		public unsafe bool E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_e);
			} finally {
			}
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cJ']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()Z", "")]
		public unsafe bool G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_g);
			} finally {
			}
		}

	}
}
