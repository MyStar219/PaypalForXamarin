using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk.Payments {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalItem']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/payments/PayPalItem", DoNotGenerateAcw=true)]
	public sealed partial class PayPalItem : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalItem']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/paypal/android/sdk/payments/PayPalItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayPalItem); }
		}

		internal PayPalItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Integer_Ljava_math_BigDecimal_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalItem']/constructor[@name='PayPalItem' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.math.BigDecimal'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/math/BigDecimal;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe PayPalItem (string p0, global::Java.Lang.Integer p1, global::Java.Math.BigDecimal p2, string p3, string p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				if (((object) this).GetType () != typeof (PayPalItem)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Integer;Ljava/math/BigDecimal;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/Integer;Ljava/math/BigDecimal;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Integer_Ljava_math_BigDecimal_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Integer_Ljava_math_BigDecimal_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/math/BigDecimal;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Integer_Ljava_math_BigDecimal_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Integer_Ljava_math_BigDecimal_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_getCurrency;
		public unsafe string Currency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalItem']/method[@name='getCurrency' and count(parameter)=0]"
			[Register ("getCurrency", "()Ljava/lang/String;", "GetGetCurrencyHandler")]
			get {
				if (id_getCurrency == IntPtr.Zero)
					id_getCurrency = JNIEnv.GetMethodID (class_ref, "getCurrency", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrency), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isValid;
		public unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalItem']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				if (id_isValid == IntPtr.Zero)
					id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isValid);
				} finally {
				}
			}
		}

		static IntPtr id_getName;
		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalItem']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPrice;
		public unsafe global::Java.Math.BigDecimal Price {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalItem']/method[@name='getPrice' and count(parameter)=0]"
			[Register ("getPrice", "()Ljava/math/BigDecimal;", "GetGetPriceHandler")]
			get {
				if (id_getPrice == IntPtr.Zero)
					id_getPrice = JNIEnv.GetMethodID (class_ref, "getPrice", "()Ljava/math/BigDecimal;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrice), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getQuantity;
		public unsafe global::Java.Lang.Integer Quantity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalItem']/method[@name='getQuantity' and count(parameter)=0]"
			[Register ("getQuantity", "()Ljava/lang/Integer;", "GetGetQuantityHandler")]
			get {
				if (id_getQuantity == IntPtr.Zero)
					id_getQuantity = JNIEnv.GetMethodID (class_ref, "getQuantity", "()Ljava/lang/Integer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getQuantity), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSku;
		public unsafe string Sku {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalItem']/method[@name='getSku' and count(parameter)=0]"
			[Register ("getSku", "()Ljava/lang/String;", "GetGetSkuHandler")]
			get {
				if (id_getSku == IntPtr.Zero)
					id_getSku = JNIEnv.GetMethodID (class_ref, "getSku", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSku), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalItem']/method[@name='describeContents' and count(parameter)=0]"
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

		static IntPtr id_getItemTotal_arrayLcom_paypal_android_sdk_payments_PayPalItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalItem']/method[@name='getItemTotal' and count(parameter)=1 and parameter[1][@type='com.paypal.android.sdk.payments.PayPalItem[]']]"
		[Register ("getItemTotal", "([Lcom/paypal/android/sdk/payments/PayPalItem;)Ljava/math/BigDecimal;", "")]
		public static unsafe global::Java.Math.BigDecimal GetItemTotal (global::Com.Paypal.Android.Sdk.Payments.PayPalItem[] p0)
		{
			if (id_getItemTotal_arrayLcom_paypal_android_sdk_payments_PayPalItem_ == IntPtr.Zero)
				id_getItemTotal_arrayLcom_paypal_android_sdk_payments_PayPalItem_ = JNIEnv.GetStaticMethodID (class_ref, "getItemTotal", "([Lcom/paypal/android/sdk/payments/PayPalItem;)Ljava/math/BigDecimal;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Math.BigDecimal __ret = global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getItemTotal_arrayLcom_paypal_android_sdk_payments_PayPalItem_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_toJSONArray_arrayLcom_paypal_android_sdk_payments_PayPalItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalItem']/method[@name='toJSONArray' and count(parameter)=1 and parameter[1][@type='com.paypal.android.sdk.payments.PayPalItem[]']]"
		[Register ("toJSONArray", "([Lcom/paypal/android/sdk/payments/PayPalItem;)Lorg/json/JSONArray;", "")]
		public static unsafe global::Org.Json.JSONArray ToJSONArray (global::Com.Paypal.Android.Sdk.Payments.PayPalItem[] p0)
		{
			if (id_toJSONArray_arrayLcom_paypal_android_sdk_payments_PayPalItem_ == IntPtr.Zero)
				id_toJSONArray_arrayLcom_paypal_android_sdk_payments_PayPalItem_ = JNIEnv.GetStaticMethodID (class_ref, "toJSONArray", "([Lcom/paypal/android/sdk/payments/PayPalItem;)Lorg/json/JSONArray;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Json.JSONArray __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toJSONArray_arrayLcom_paypal_android_sdk_payments_PayPalItem_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalItem']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
