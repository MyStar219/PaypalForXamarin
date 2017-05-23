using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk.Payments {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalOAuthScopes']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/payments/PayPalOAuthScopes", DoNotGenerateAcw=true)]
	public sealed partial class PayPalOAuthScopes : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalOAuthScopes']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PAYPAL_SCOPE_ADDRESS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalOAuthScopes']/field[@name='PAYPAL_SCOPE_ADDRESS']"
		[Register ("PAYPAL_SCOPE_ADDRESS")]
		public static string PaypalScopeAddress {
			get {
				if (PAYPAL_SCOPE_ADDRESS_jfieldId == IntPtr.Zero)
					PAYPAL_SCOPE_ADDRESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAYPAL_SCOPE_ADDRESS", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAYPAL_SCOPE_ADDRESS_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PAYPAL_SCOPE_EMAIL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalOAuthScopes']/field[@name='PAYPAL_SCOPE_EMAIL']"
		[Register ("PAYPAL_SCOPE_EMAIL")]
		public static string PaypalScopeEmail {
			get {
				if (PAYPAL_SCOPE_EMAIL_jfieldId == IntPtr.Zero)
					PAYPAL_SCOPE_EMAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAYPAL_SCOPE_EMAIL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAYPAL_SCOPE_EMAIL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PAYPAL_SCOPE_FUTURE_PAYMENTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalOAuthScopes']/field[@name='PAYPAL_SCOPE_FUTURE_PAYMENTS']"
		[Register ("PAYPAL_SCOPE_FUTURE_PAYMENTS")]
		public static string PaypalScopeFuturePayments {
			get {
				if (PAYPAL_SCOPE_FUTURE_PAYMENTS_jfieldId == IntPtr.Zero)
					PAYPAL_SCOPE_FUTURE_PAYMENTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAYPAL_SCOPE_FUTURE_PAYMENTS", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAYPAL_SCOPE_FUTURE_PAYMENTS_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PAYPAL_SCOPE_OPENID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalOAuthScopes']/field[@name='PAYPAL_SCOPE_OPENID']"
		[Register ("PAYPAL_SCOPE_OPENID")]
		public static string PaypalScopeOpenid {
			get {
				if (PAYPAL_SCOPE_OPENID_jfieldId == IntPtr.Zero)
					PAYPAL_SCOPE_OPENID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAYPAL_SCOPE_OPENID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAYPAL_SCOPE_OPENID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PAYPAL_SCOPE_PAYPAL_ATTRIBUTES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalOAuthScopes']/field[@name='PAYPAL_SCOPE_PAYPAL_ATTRIBUTES']"
		[Register ("PAYPAL_SCOPE_PAYPAL_ATTRIBUTES")]
		public static string PaypalScopePaypalAttributes {
			get {
				if (PAYPAL_SCOPE_PAYPAL_ATTRIBUTES_jfieldId == IntPtr.Zero)
					PAYPAL_SCOPE_PAYPAL_ATTRIBUTES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAYPAL_SCOPE_PAYPAL_ATTRIBUTES", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAYPAL_SCOPE_PAYPAL_ATTRIBUTES_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PAYPAL_SCOPE_PHONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalOAuthScopes']/field[@name='PAYPAL_SCOPE_PHONE']"
		[Register ("PAYPAL_SCOPE_PHONE")]
		public static string PaypalScopePhone {
			get {
				if (PAYPAL_SCOPE_PHONE_jfieldId == IntPtr.Zero)
					PAYPAL_SCOPE_PHONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAYPAL_SCOPE_PHONE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAYPAL_SCOPE_PHONE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PAYPAL_SCOPE_PROFILE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalOAuthScopes']/field[@name='PAYPAL_SCOPE_PROFILE']"
		[Register ("PAYPAL_SCOPE_PROFILE")]
		public static string PaypalScopeProfile {
			get {
				if (PAYPAL_SCOPE_PROFILE_jfieldId == IntPtr.Zero)
					PAYPAL_SCOPE_PROFILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAYPAL_SCOPE_PROFILE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAYPAL_SCOPE_PROFILE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/payments/PayPalOAuthScopes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayPalOAuthScopes); }
		}

		internal PayPalOAuthScopes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_Set_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalOAuthScopes']/constructor[@name='PayPalOAuthScopes' and count(parameter)=1 and parameter[1][@type='java.util.Set']]"
		[Register (".ctor", "(Ljava/util/Set;)V", "")]
		public unsafe PayPalOAuthScopes (global::System.Collections.ICollection p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaSet.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (PayPalOAuthScopes)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/Set;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/Set;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Set_ == IntPtr.Zero)
					id_ctor_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Set;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Set_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_Set_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalOAuthScopes']/constructor[@name='PayPalOAuthScopes' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PayPalOAuthScopes ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PayPalOAuthScopes)) {
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

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalOAuthScopes']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalOAuthScopes']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalOAuthScopes']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
