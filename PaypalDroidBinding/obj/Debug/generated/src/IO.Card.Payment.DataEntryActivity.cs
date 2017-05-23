using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Card.Payment {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.card.payment']/class[@name='DataEntryActivity']"
	[global::Android.Runtime.Register ("io/card/payment/DataEntryActivity", DoNotGenerateAcw=true)]
	public sealed partial class DataEntryActivity : global::Android.App.Activity, global::Android.Text.ITextWatcher {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/card/payment/DataEntryActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataEntryActivity); }
		}

		internal DataEntryActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.card.payment']/class[@name='DataEntryActivity']/constructor[@name='DataEntryActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataEntryActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DataEntryActivity)) {
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

		static IntPtr id_afterTextChanged_Landroid_text_Editable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='DataEntryActivity']/method[@name='afterTextChanged' and count(parameter)=1 and parameter[1][@type='android.text.Editable']]"
		[Register ("afterTextChanged", "(Landroid/text/Editable;)V", "")]
		public unsafe void AfterTextChanged (global::Android.Text.IEditable p0)
		{
			if (id_afterTextChanged_Landroid_text_Editable_ == IntPtr.Zero)
				id_afterTextChanged_Landroid_text_Editable_ = JNIEnv.GetMethodID (class_ref, "afterTextChanged", "(Landroid/text/Editable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_afterTextChanged_Landroid_text_Editable_, __args);
			} finally {
			}
		}

		static IntPtr id_beforeTextChanged_Ljava_lang_CharSequence_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='DataEntryActivity']/method[@name='beforeTextChanged' and count(parameter)=4 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("beforeTextChanged", "(Ljava/lang/CharSequence;III)V", "")]
		public unsafe void BeforeTextChanged (global::Java.Lang.ICharSequence p0, int p1, int p2, int p3)
		{
			if (id_beforeTextChanged_Ljava_lang_CharSequence_III == IntPtr.Zero)
				id_beforeTextChanged_Ljava_lang_CharSequence_III = JNIEnv.GetMethodID (class_ref, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_beforeTextChanged_Ljava_lang_CharSequence_III, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public void BeforeTextChanged (string p0, int p1, int p2, int p3)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			BeforeTextChanged (jls_p0, p1, p2, p3);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='DataEntryActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "")]
		protected override sealed unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='DataEntryActivity']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "")]
		protected override sealed unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResume);
			} finally {
			}
		}

		static IntPtr id_onTextChanged_Ljava_lang_CharSequence_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='DataEntryActivity']/method[@name='onTextChanged' and count(parameter)=4 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onTextChanged", "(Ljava/lang/CharSequence;III)V", "")]
		public unsafe void OnTextChanged (global::Java.Lang.ICharSequence p0, int p1, int p2, int p3)
		{
			if (id_onTextChanged_Ljava_lang_CharSequence_III == IntPtr.Zero)
				id_onTextChanged_Ljava_lang_CharSequence_III = JNIEnv.GetMethodID (class_ref, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTextChanged_Ljava_lang_CharSequence_III, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public void OnTextChanged (string p0, int p1, int p2, int p3)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			OnTextChanged (jls_p0, p1, p2, p3);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

	}
}
