using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk.Payments {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='ShippingAddress']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/payments/ShippingAddress", DoNotGenerateAcw=true)]
	public sealed partial class ShippingAddress : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='ShippingAddress']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/paypal/android/sdk/payments/ShippingAddress", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShippingAddress); }
		}

		internal ShippingAddress (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='ShippingAddress']/constructor[@name='ShippingAddress' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ShippingAddress ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ShippingAddress)) {
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

		static IntPtr id_isProcessable;
		public unsafe bool IsProcessable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='ShippingAddress']/method[@name='isProcessable' and count(parameter)=0]"
			[Register ("isProcessable", "()Z", "GetIsProcessableHandler")]
			get {
				if (id_isProcessable == IntPtr.Zero)
					id_isProcessable = JNIEnv.GetMethodID (class_ref, "isProcessable", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isProcessable);
				} finally {
				}
			}
		}

		static IntPtr id_city_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='ShippingAddress']/method[@name='city' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("city", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/ShippingAddress;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.ShippingAddress City (string p0)
		{
			if (id_city_Ljava_lang_String_ == IntPtr.Zero)
				id_city_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "city", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/ShippingAddress;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.ShippingAddress __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.ShippingAddress> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_city_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_countryCode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='ShippingAddress']/method[@name='countryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("countryCode", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/ShippingAddress;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.ShippingAddress CountryCode (string p0)
		{
			if (id_countryCode_Ljava_lang_String_ == IntPtr.Zero)
				id_countryCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "countryCode", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/ShippingAddress;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.ShippingAddress __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.ShippingAddress> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_countryCode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='ShippingAddress']/method[@name='describeContents' and count(parameter)=0]"
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

		static IntPtr id_line1_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='ShippingAddress']/method[@name='line1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("line1", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/ShippingAddress;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.ShippingAddress Line1 (string p0)
		{
			if (id_line1_Ljava_lang_String_ == IntPtr.Zero)
				id_line1_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "line1", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/ShippingAddress;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.ShippingAddress __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.ShippingAddress> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_line1_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_line2_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='ShippingAddress']/method[@name='line2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("line2", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/ShippingAddress;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.ShippingAddress Line2 (string p0)
		{
			if (id_line2_Ljava_lang_String_ == IntPtr.Zero)
				id_line2_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "line2", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/ShippingAddress;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.ShippingAddress __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.ShippingAddress> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_line2_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_postalCode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='ShippingAddress']/method[@name='postalCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("postalCode", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/ShippingAddress;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.ShippingAddress PostalCode (string p0)
		{
			if (id_postalCode_Ljava_lang_String_ == IntPtr.Zero)
				id_postalCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "postalCode", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/ShippingAddress;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.ShippingAddress __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.ShippingAddress> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_postalCode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_recipientName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='ShippingAddress']/method[@name='recipientName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("recipientName", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/ShippingAddress;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.ShippingAddress RecipientName (string p0)
		{
			if (id_recipientName_Ljava_lang_String_ == IntPtr.Zero)
				id_recipientName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "recipientName", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/ShippingAddress;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.ShippingAddress __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.ShippingAddress> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_recipientName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_state_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='ShippingAddress']/method[@name='state' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("state", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/ShippingAddress;", "")]
		public unsafe global::Com.Paypal.Android.Sdk.Payments.ShippingAddress State (string p0)
		{
			if (id_state_Ljava_lang_String_ == IntPtr.Zero)
				id_state_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "state", "(Ljava/lang/String;)Lcom/paypal/android/sdk/payments/ShippingAddress;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Paypal.Android.Sdk.Payments.ShippingAddress __ret = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Payments.ShippingAddress> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_state_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_toJSONObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='ShippingAddress']/method[@name='toJSONObject' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='ShippingAddress']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
