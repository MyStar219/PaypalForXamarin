using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='M']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/M", DoNotGenerateAcw=true)]
	public partial class M : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/M", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (M); }
		}

		protected M (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='M']/constructor[@name='M' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe M ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (M)) {
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

		static IntPtr id_a_Landroid_content_Context_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='M']/method[@name='a' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int']]"
		[Register ("a", "(Landroid/content/Context;ZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Z", "")]
		protected unsafe bool A (global::Android.Content.Context p0, bool p1, string p2, string p3, string p4, int p5)
		{
			if (id_a_Landroid_content_Context_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_a_Landroid_content_Context_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/content/Context;ZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)Z");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_a_Landroid_content_Context_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}
}
