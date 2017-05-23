using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cV']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/cV", DoNotGenerateAcw=true)]
	public sealed partial class CV : global::Java.Lang.Object, global::Com.Paypal.Android.Sdk.ICY {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/cV", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CV); }
		}

		internal CV (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cV']/constructor[@name='cV' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CV ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CV)) {
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

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cV']/method[@name='a' and count(parameter)=0]"
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

		static IntPtr id_a_Lorg_json_JSONObject_Lorg_json_JSONArray_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cV']/method[@name='a' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='org.json.JSONArray'] and parameter[3][@type='int']]"
		[Register ("a", "(Lorg/json/JSONObject;Lorg/json/JSONArray;I)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.IList A (global::Org.Json.JSONObject p0, global::Org.Json.JSONArray p1, int p2)
		{
			if (id_a_Lorg_json_JSONObject_Lorg_json_JSONArray_I == IntPtr.Zero)
				id_a_Lorg_json_JSONObject_Lorg_json_JSONArray_I = JNIEnv.GetStaticMethodID (class_ref, "a", "(Lorg/json/JSONObject;Lorg/json/JSONArray;I)Ljava/util/ArrayList;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Lorg_json_JSONObject_Lorg_json_JSONArray_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cV']/method[@name='b' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cV']/method[@name='c' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cV']/method[@name='d' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cV']/method[@name='e' and count(parameter)=0]"
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

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cV']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Ljava/lang/String;", "")]
		public unsafe string F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_f), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cV']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()Ljava/lang/String;", "")]
		public unsafe string G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_g), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cV']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()Ljava/lang/String;", "")]
		public unsafe string H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_h), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cV']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()Ljava/lang/String;", "")]
		public unsafe string I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_i), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cV']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Ljava/lang/String;", "")]
		public unsafe string J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_j), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_k;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cV']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()Ljava/lang/String;", "")]
		public unsafe string K ()
		{
			if (id_k == IntPtr.Zero)
				id_k = JNIEnv.GetMethodID (class_ref, "k", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_k), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_l;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cV']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()Ljava/lang/String;", "")]
		public unsafe string L ()
		{
			if (id_l == IntPtr.Zero)
				id_l = JNIEnv.GetMethodID (class_ref, "l", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_l), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
