using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk.Payments {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalAuthorization']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/payments/PayPalAuthorization", DoNotGenerateAcw=true)]
	public sealed partial class PayPalAuthorization : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalAuthorization']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/payments/PayPalAuthorization", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayPalAuthorization); }
		}

		internal PayPalAuthorization (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAuthorizationCode;
		public unsafe string AuthorizationCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalAuthorization']/method[@name='getAuthorizationCode' and count(parameter)=0]"
			[Register ("getAuthorizationCode", "()Ljava/lang/String;", "GetGetAuthorizationCodeHandler")]
			get {
				if (id_getAuthorizationCode == IntPtr.Zero)
					id_getAuthorizationCode = JNIEnv.GetMethodID (class_ref, "getAuthorizationCode", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthorizationCode), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getEnvironment;
		public unsafe string Environment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalAuthorization']/method[@name='getEnvironment' and count(parameter)=0]"
			[Register ("getEnvironment", "()Ljava/lang/String;", "GetGetEnvironmentHandler")]
			get {
				if (id_getEnvironment == IntPtr.Zero)
					id_getEnvironment = JNIEnv.GetMethodID (class_ref, "getEnvironment", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEnvironment), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalAuthorization']/method[@name='describeContents' and count(parameter)=0]"
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

		static IntPtr id_toJSONObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalAuthorization']/method[@name='toJSONObject' and count(parameter)=0]"
		[Register ("toJSONObject", "()Lorg/json/JSONObject;", "")]
		public unsafe global::Org.Json.JSONObject ToJSONObject ()
		{
			if (id_toJSONObject == IntPtr.Zero)
				id_toJSONObject = JNIEnv.GetMethodID (class_ref, "toJSONObject", "()Lorg/json/JSONObject;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJSONObject), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalAuthorization']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
