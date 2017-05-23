using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='dJ']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/dJ", DoNotGenerateAcw=true)]
	public sealed partial class DJ : global::Java.Lang.Object {


		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='dJ']/field[@name='c']"
		[Register ("c")]
		public static int C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "c", "I");
				return JNIEnv.GetStaticIntField (class_ref, c_jfieldId);
			}
		}

		static IntPtr d_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='dJ']/field[@name='d']"
		[Register ("d")]
		public static int D {
			get {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "I");
				return JNIEnv.GetStaticIntField (class_ref, d_jfieldId);
			}
		}

		static IntPtr e_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='dJ']/field[@name='e']"
		[Register ("e")]
		public static int E {
			get {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "e", "I");
				return JNIEnv.GetStaticIntField (class_ref, e_jfieldId);
			}
		}

		static IntPtr f_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='dJ']/field[@name='f']"
		[Register ("f")]
		public static global::Android.Graphics.Typeface F {
			get {
				if (f_jfieldId == IntPtr.Zero)
					f_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "f", "Landroid/graphics/Typeface;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, f_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/dJ", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DJ); }
		}

		internal DJ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='dJ']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable A (global::Android.Content.Context p0)
		{
			if (id_a_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;)Landroid/graphics/drawable/Drawable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_b_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='dJ']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("b", "(Landroid/content/Context;)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable B (global::Android.Content.Context p0)
		{
			if (id_b_Landroid_content_Context_ == IntPtr.Zero)
				id_b_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;)Landroid/graphics/drawable/Drawable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_b_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
