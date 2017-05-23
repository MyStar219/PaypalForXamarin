using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/cO", DoNotGenerateAcw=true)]
	public sealed partial class CO : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/cO", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CO); }
		}

		internal CO (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/constructor[@name='cO' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Z)V", "")]
		public unsafe CO (global::Android.Content.Context p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (CO)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Z)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Z == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Z, __args);
			} finally {
			}
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Landroid/view/View;", "")]
		public unsafe global::Android.Views.View A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Landroid/view/View;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_Lcom_paypal_android_sdk_cJ_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.paypal.android.sdk.cJ']]"
		[Register ("a", "(Landroid/content/Context;Lcom/paypal/android/sdk/cJ;)V", "")]
		public unsafe void A (global::Android.Content.Context p0, global::Com.Paypal.Android.Sdk.CJ p1)
		{
			if (id_a_Landroid_content_Context_Lcom_paypal_android_sdk_cJ_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Lcom_paypal_android_sdk_cJ_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/content/Context;Lcom/paypal/android/sdk/cJ;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Landroid_content_Context_Lcom_paypal_android_sdk_cJ_, __args);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_Lcom_paypal_android_sdk_cV_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.paypal.android.sdk.cV']]"
		[Register ("a", "(Landroid/content/Context;Lcom/paypal/android/sdk/cV;)V", "")]
		public unsafe void A (global::Android.Content.Context p0, global::Com.Paypal.Android.Sdk.CV p1)
		{
			if (id_a_Landroid_content_Context_Lcom_paypal_android_sdk_cV_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Lcom_paypal_android_sdk_cV_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/content/Context;Lcom/paypal/android/sdk/cV;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Landroid_content_Context_Lcom_paypal_android_sdk_cV_, __args);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_text_SpannableString_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.text.SpannableString']]"
		[Register ("a", "(Landroid/text/SpannableString;)V", "")]
		public unsafe void A (global::Android.Text.SpannableString p0)
		{
			if (id_a_Landroid_text_SpannableString_ == IntPtr.Zero)
				id_a_Landroid_text_SpannableString_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/text/SpannableString;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Landroid_text_SpannableString_, __args);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("a", "(Landroid/view/View$OnClickListener;)V", "")]
		public unsafe void A (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_a_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_a_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Landroid_view_View_OnClickListener_, __args);
			} finally {
			}
		}

		static IntPtr id_a_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='a' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("a", "(Z)V", "")]
		public unsafe void A (bool p0)
		{
			if (id_a_Z == IntPtr.Zero)
				id_a_Z = JNIEnv.GetMethodID (class_ref, "a", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Z, __args);
			} finally {
			}
		}

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_a_Ljava_lang_String_Landroid_graphics_Bitmap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Landroid/graphics/Bitmap;Ljava/lang/String;)V", "")]
		public unsafe void A (string p0, global::Android.Graphics.Bitmap p1, string p2)
		{
			if (id_a_Ljava_lang_String_Landroid_graphics_Bitmap_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Landroid_graphics_Bitmap_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Landroid/graphics/Bitmap;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Ljava_lang_String_Landroid_graphics_Bitmap_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void A (string p0, string p1)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Landroid/widget/TextView;", "")]
		public unsafe global::Android.Widget.TextView B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Landroid/widget/TextView;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_b), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_b_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("b", "(Landroid/view/View$OnClickListener;)V", "")]
		public unsafe void B (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_b_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_b_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "b", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_b_Landroid_view_View_OnClickListener_, __args);
			} finally {
			}
		}

		static IntPtr id_b_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='b' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("b", "(Z)V", "")]
		public unsafe void B (bool p0)
		{
			if (id_b_Z == IntPtr.Zero)
				id_b_Z = JNIEnv.GetMethodID (class_ref, "b", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_b_Z, __args);
			} finally {
			}
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "")]
		public unsafe void C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_c);
			} finally {
			}
		}

		static IntPtr id_c_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='c' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("c", "(Landroid/view/View$OnClickListener;)V", "")]
		public unsafe void C (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_c_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_c_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "c", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_c_Landroid_view_View_OnClickListener_, __args);
			} finally {
			}
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Landroid/widget/TextView;", "")]
		public unsafe global::Android.Widget.TextView D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Landroid/widget/TextView;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_d), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_d_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='d' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("d", "(Landroid/view/View$OnClickListener;)V", "")]
		public unsafe void D (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_d_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_d_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "d", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_d_Landroid_view_View_OnClickListener_, __args);
			} finally {
			}
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Landroid/view/View;", "")]
		public unsafe global::Android.Views.View E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Landroid/view/View;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_e), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cO']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()Landroid/view/View;", "")]
		public unsafe global::Android.Views.View F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()Landroid/view/View;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_f), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
