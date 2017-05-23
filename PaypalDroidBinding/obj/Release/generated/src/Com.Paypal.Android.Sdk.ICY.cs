using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.paypal.android.sdk']/interface[@name='cY']"
	[Register ("com/paypal/android/sdk/cY", "", "Com.Paypal.Android.Sdk.ICYInvoker")]
	public partial interface ICY : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/interface[@name='cY']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "GetAHandler:Com.Paypal.Android.Sdk.ICYInvoker, PaypalDroidBinding")]
		string A ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/interface[@name='cY']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/lang/String;", "GetBHandler:Com.Paypal.Android.Sdk.ICYInvoker, PaypalDroidBinding")]
		string B ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/interface[@name='cY']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/String;", "GetCHandler:Com.Paypal.Android.Sdk.ICYInvoker, PaypalDroidBinding")]
		string C ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/interface[@name='cY']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Ljava/lang/String;", "GetDHandler:Com.Paypal.Android.Sdk.ICYInvoker, PaypalDroidBinding")]
		string D ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/interface[@name='cY']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()Z", "GetEHandler:Com.Paypal.Android.Sdk.ICYInvoker, PaypalDroidBinding")]
		bool E ();

	}

	[global::Android.Runtime.Register ("com/paypal/android/sdk/cY", DoNotGenerateAcw=true)]
	internal class ICYInvoker : global::Java.Lang.Object, ICY {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/paypal/android/sdk/cY");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICYInvoker); }
		}

		IntPtr class_ref;

		public static ICY GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICY> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.paypal.android.sdk.cY"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICYInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Paypal.Android.Sdk.ICY __this = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.ICY> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.A ());
		}
#pragma warning restore 0169

		IntPtr id_a;
		public unsafe string A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_B);
			return cb_b;
		}

		static IntPtr n_B (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Paypal.Android.Sdk.ICY __this = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.ICY> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.B ());
		}
#pragma warning restore 0169

		IntPtr id_b;
		public unsafe string B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_b), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_C);
			return cb_c;
		}

		static IntPtr n_C (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Paypal.Android.Sdk.ICY __this = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.ICY> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.C ());
		}
#pragma warning restore 0169

		IntPtr id_c;
		public unsafe string C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_c), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_d;
#pragma warning disable 0169
		static Delegate GetDHandler ()
		{
			if (cb_d == null)
				cb_d = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_D);
			return cb_d;
		}

		static IntPtr n_D (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Paypal.Android.Sdk.ICY __this = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.ICY> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.D ());
		}
#pragma warning restore 0169

		IntPtr id_d;
		public unsafe string D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_d), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_e;
#pragma warning disable 0169
		static Delegate GetEHandler ()
		{
			if (cb_e == null)
				cb_e = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_E);
			return cb_e;
		}

		static bool n_E (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Paypal.Android.Sdk.ICY __this = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.ICY> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.E ();
		}
#pragma warning restore 0169

		IntPtr id_e;
		public unsafe bool E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_e);
		}

	}

}
