using System;
using System.Collections.Generic;
using Android.Runtime;
//using Android.App;
//using Android.Content;
//using Android.Content.PM;
//using Android.Views;
//using Android.Widget;
//using Android.OS;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cH']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/cH", DoNotGenerateAcw=true)]
	public sealed partial class CH : global::Java.Lang.Object {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cH']/field[@name='a']"
		[Register ("a")]
		public global::Android.Views.ViewGroup A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Landroid/view/ViewGroup;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, a_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Landroid/view/ViewGroup;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, a_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cH']/field[@name='b']"
		[Register ("b")]
		public global::Android.Widget.TextView B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, b_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, b_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cH']/field[@name='c']"
		[Register ("c")]
		public global::Android.Widget.TextView C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "[Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField(((global::Java.Lang.Object)this).Handle, c_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
				//return global::Android.Runtime.JavaArray<global::Android.Widget.TextView>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, c_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "[Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
				//IntPtr native_value = global::Android.Runtime.JavaArray<global::Android.Widget.TextView>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, c_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr d_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cH']/field[@name='d']"
		[Register ("d")]
		public global::Android.Widget.TextView D {
			get {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetFieldID (class_ref, "d", "Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, d_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetFieldID (class_ref, "d", "Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, d_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr e_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cH']/field[@name='e']"
		[Register ("e")]
		public global::Android.Widget.TextView E {
			get {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, e_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, e_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr f_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cH']/field[@name='f']"
		[Register ("f")]
		public global::Com.Paypal.Android.Sdk.CI F {
			get {
				if (f_jfieldId == IntPtr.Zero)
					f_jfieldId = JNIEnv.GetFieldID (class_ref, "f", "Lcom/paypal/android/sdk/cI;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, f_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.CI> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (f_jfieldId == IntPtr.Zero)
					f_jfieldId = JNIEnv.GetFieldID (class_ref, "f", "Lcom/paypal/android/sdk/cI;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, f_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr g_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cH']/field[@name='g']"
		[Register ("g")]
		public global::Android.Widget.Button G {
			get {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetFieldID (class_ref, "g", "Landroid/widget/Button;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, g_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.Button> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetFieldID (class_ref, "g", "Landroid/widget/Button;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, g_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr h_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cH']/field[@name='h']"
		[Register ("h")]
		public global::Android.Widget.LinearLayout H {
			get {
				if (h_jfieldId == IntPtr.Zero)
					h_jfieldId = JNIEnv.GetFieldID (class_ref, "h", "Landroid/widget/LinearLayout;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, h_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.LinearLayout> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (h_jfieldId == IntPtr.Zero)
					h_jfieldId = JNIEnv.GetFieldID (class_ref, "h", "Landroid/widget/LinearLayout;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, h_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr i_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cH']/field[@name='i']"
		[Register ("i")]
		public global::Android.Widget.TextView I {
			get {
				if (i_jfieldId == IntPtr.Zero)
					i_jfieldId = JNIEnv.GetFieldID (class_ref, "i", "Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, i_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (i_jfieldId == IntPtr.Zero)
					i_jfieldId = JNIEnv.GetFieldID (class_ref, "i", "Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, i_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/cH", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CH); }
		}

		internal CH (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cH']/constructor[@name='cH' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CH (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (CH)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}
