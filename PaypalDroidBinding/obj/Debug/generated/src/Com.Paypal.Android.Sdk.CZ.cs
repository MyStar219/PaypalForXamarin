using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cZ']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/cZ", DoNotGenerateAcw=true)]
	public sealed partial class CZ : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/cZ", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CZ); }
		}

		internal CZ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cZ']/constructor[@name='cZ' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CZ (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (CZ)) {
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

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cZ']/method[@name='a' and count(parameter)=0]"
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

		static IntPtr id_a_Landroid_content_Context_Lcom_paypal_android_sdk_cY_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cZ']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.paypal.android.sdk.cY']]"
		[Register ("a", "(Landroid/content/Context;Lcom/paypal/android/sdk/cY;)V", "")]
		public unsafe void A (global::Android.Content.Context p0, global::Com.Paypal.Android.Sdk.ICY p1)
		{
			if (id_a_Landroid_content_Context_Lcom_paypal_android_sdk_cY_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Lcom_paypal_android_sdk_cY_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/content/Context;Lcom/paypal/android/sdk/cY;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Landroid_content_Context_Lcom_paypal_android_sdk_cY_, __args);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='cZ']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
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

	}
}
