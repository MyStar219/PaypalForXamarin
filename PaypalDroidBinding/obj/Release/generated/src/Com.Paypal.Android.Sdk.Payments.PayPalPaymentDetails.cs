using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk.Payments {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPaymentDetails']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/payments/PayPalPaymentDetails", DoNotGenerateAcw=true)]
	public sealed partial class PayPalPaymentDetails : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPaymentDetails']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/paypal/android/sdk/payments/PayPalPaymentDetails", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayPalPaymentDetails); }
		}

		internal PayPalPaymentDetails (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_math_BigDecimal_Ljava_math_BigDecimal_Ljava_math_BigDecimal_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPaymentDetails']/constructor[@name='PayPalPaymentDetails' and count(parameter)=3 and parameter[1][@type='java.math.BigDecimal'] and parameter[2][@type='java.math.BigDecimal'] and parameter[3][@type='java.math.BigDecimal']]"
		[Register (".ctor", "(Ljava/math/BigDecimal;Ljava/math/BigDecimal;Ljava/math/BigDecimal;)V", "")]
		public unsafe PayPalPaymentDetails (global::Java.Math.BigDecimal p0, global::Java.Math.BigDecimal p1, global::Java.Math.BigDecimal p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (PayPalPaymentDetails)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/math/BigDecimal;Ljava/math/BigDecimal;Ljava/math/BigDecimal;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/math/BigDecimal;Ljava/math/BigDecimal;Ljava/math/BigDecimal;)V", __args);
					return;
				}

				if (id_ctor_Ljava_math_BigDecimal_Ljava_math_BigDecimal_Ljava_math_BigDecimal_ == IntPtr.Zero)
					id_ctor_Ljava_math_BigDecimal_Ljava_math_BigDecimal_Ljava_math_BigDecimal_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/math/BigDecimal;Ljava/math/BigDecimal;Ljava/math/BigDecimal;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_math_BigDecimal_Ljava_math_BigDecimal_Ljava_math_BigDecimal_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_math_BigDecimal_Ljava_math_BigDecimal_Ljava_math_BigDecimal_, __args);
			} finally {
			}
		}

		static IntPtr id_isProcessable;
		public unsafe bool IsProcessable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPaymentDetails']/method[@name='isProcessable' and count(parameter)=0]"
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

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPaymentDetails']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/math/BigDecimal;", "")]
		protected unsafe global::Java.Math.BigDecimal A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Ljava/math/BigDecimal;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPaymentDetails']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/math/BigDecimal;", "")]
		protected unsafe global::Java.Math.BigDecimal B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Ljava/math/BigDecimal;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_b), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPaymentDetails']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/math/BigDecimal;", "")]
		protected unsafe global::Java.Math.BigDecimal C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/math/BigDecimal;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_c), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPaymentDetails']/method[@name='describeContents' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPaymentDetails']/method[@name='toJSONObject' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk.payments']/class[@name='PayPalPaymentDetails']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
