using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='U']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/U", DoNotGenerateAcw=true)]
	public partial class U : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/U", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (U); }
		}

		protected U (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='U']/constructor[@name='U' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe U ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (U)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='U']/method[@name='a' and count(parameter)=0]"
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

		static IntPtr id_a_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='U']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("a", "(Landroid/app/Activity;)V", "")]
		public static unsafe void A (global::Android.App.Activity p0)
		{
			if (id_a_Landroid_app_Activity_ == IntPtr.Zero)
				id_a_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_app_Activity_Landroid_widget_TextView_Ljava_lang_String_Ljava_lang_String_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='U']/method[@name='a' and count(parameter)=5 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.widget.TextView'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.graphics.drawable.Drawable']]"
		[Register ("a", "(Landroid/app/Activity;Landroid/widget/TextView;Ljava/lang/String;Ljava/lang/String;Landroid/graphics/drawable/Drawable;)V", "")]
		public static unsafe void A (global::Android.App.Activity p0, global::Android.Widget.TextView p1, string p2, string p3, global::Android.Graphics.Drawables.Drawable p4)
		{
			if (id_a_Landroid_app_Activity_Landroid_widget_TextView_Ljava_lang_String_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_a_Landroid_app_Activity_Landroid_widget_TextView_Ljava_lang_String_Ljava_lang_String_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/app/Activity;Landroid/widget/TextView;Ljava/lang/String;Ljava/lang/String;Landroid/graphics/drawable/Drawable;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_app_Activity_Landroid_widget_TextView_Ljava_lang_String_Ljava_lang_String_Landroid_graphics_drawable_Drawable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='U']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "")]
		public unsafe void A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='U']/method[@name='b' and count(parameter)=0]"
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

		static IntPtr id_b_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='U']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("b", "(Landroid/app/Activity;)V", "")]
		public static unsafe void B (global::Android.App.Activity p0)
		{
			if (id_b_Landroid_app_Activity_ == IntPtr.Zero)
				id_b_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_b_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='U']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;)V", "")]
		public unsafe void B (string p0)
		{
			if (id_b_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_b_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='U']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Z", "")]
		public static unsafe bool C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetStaticMethodID (class_ref, "c", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_c);
			} finally {
			}
		}

	}
}
