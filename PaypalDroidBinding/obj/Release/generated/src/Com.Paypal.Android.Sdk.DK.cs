using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='dK']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/dK", DoNotGenerateAcw=true)]
	public sealed partial class DK : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/dK", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DK); }
		}

		internal DK (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a_Landroid_view_View_ZLandroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='dK']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean'] and parameter[3][@type='android.content.Context']]"
		[Register ("a", "(Landroid/view/View;ZLandroid/content/Context;)V", "")]
		public static unsafe void A (global::Android.Views.View p0, bool p1, global::Android.Content.Context p2)
		{
			if (id_a_Landroid_view_View_ZLandroid_content_Context_ == IntPtr.Zero)
				id_a_Landroid_view_View_ZLandroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/view/View;ZLandroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_view_View_ZLandroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_view_View_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='dK']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("a", "(Landroid/view/View;II)V", "")]
		public static unsafe void A (global::Android.Views.View p0, int p1, int p2)
		{
			if (id_a_Landroid_view_View_II == IntPtr.Zero)
				id_a_Landroid_view_View_II = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/view/View;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_view_View_II, __args);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='dK']/method[@name='a' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("a", "(Landroid/view/View;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void A (global::Android.Views.View p0, string p1, string p2, string p3, string p4)
		{
			if (id_a_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/view/View;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_a_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='dK']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("a", "(Ljava/lang/String;Landroid/content/Context;)I", "")]
		public static unsafe int A (string p0, global::Android.Content.Context p1)
		{
			if (id_a_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;Landroid/content/Context;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_a_Ljava_lang_String_Landroid_content_Context_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_a_Ljava_lang_String_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='dK']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='int']]"
		[Register ("a", "(Ljava/lang/String;Landroid/content/Context;I)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap A (string p0, global::Android.Content.Context p1, int p2)
		{
			if (id_a_Ljava_lang_String_Landroid_content_Context_I == IntPtr.Zero)
				id_a_Ljava_lang_String_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "a", "(Ljava/lang/String;Landroid/content/Context;I)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Ljava_lang_String_Landroid_content_Context_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_b_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='dK']/method[@name='b' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("b", "(Landroid/view/View;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void B (global::Android.Views.View p0, string p1, string p2, string p3, string p4)
		{
			if (id_b_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/view/View;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Landroid_view_View_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_b_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='dK']/method[@name='b' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("b", "(Ljava/lang/String;Landroid/content/Context;)F", "")]
		public static unsafe float B (string p0, global::Android.Content.Context p1)
		{
			if (id_b_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_b_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Ljava/lang/String;Landroid/content/Context;)F");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_b_Ljava_lang_String_Landroid_content_Context_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_c_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='dK']/method[@name='c' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("c", "(Ljava/lang/String;Landroid/content/Context;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap C (string p0, global::Android.Content.Context p1)
		{
			if (id_c_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_c_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Ljava/lang/String;Landroid/content/Context;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_c_Ljava_lang_String_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
