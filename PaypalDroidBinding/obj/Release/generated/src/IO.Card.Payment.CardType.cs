using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Card.Payment {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']"
	[global::Android.Runtime.Register ("io/card/payment/CardType", DoNotGenerateAcw=true)]
	public sealed partial class CardType : global::Java.Lang.Enum {


		static IntPtr AMEX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/field[@name='AMEX']"
		[Register ("AMEX")]
		public static global::IO.Card.Payment.CardType Amex {
			get {
				if (AMEX_jfieldId == IntPtr.Zero)
					AMEX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AMEX", "Lio/card/payment/CardType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AMEX_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CardType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DINERSCLUB_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/field[@name='DINERSCLUB']"
		[Register ("DINERSCLUB")]
		public static global::IO.Card.Payment.CardType Dinersclub {
			get {
				if (DINERSCLUB_jfieldId == IntPtr.Zero)
					DINERSCLUB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DINERSCLUB", "Lio/card/payment/CardType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DINERSCLUB_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CardType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DISCOVER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/field[@name='DISCOVER']"
		[Register ("DISCOVER")]
		public static global::IO.Card.Payment.CardType Discover {
			get {
				if (DISCOVER_jfieldId == IntPtr.Zero)
					DISCOVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISCOVER", "Lio/card/payment/CardType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISCOVER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CardType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INSUFFICIENT_DIGITS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/field[@name='INSUFFICIENT_DIGITS']"
		[Register ("INSUFFICIENT_DIGITS")]
		public static global::IO.Card.Payment.CardType InsufficientDigits {
			get {
				if (INSUFFICIENT_DIGITS_jfieldId == IntPtr.Zero)
					INSUFFICIENT_DIGITS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSUFFICIENT_DIGITS", "Lio/card/payment/CardType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSUFFICIENT_DIGITS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CardType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JCB_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/field[@name='JCB']"
		[Register ("JCB")]
		public static global::IO.Card.Payment.CardType Jcb {
			get {
				if (JCB_jfieldId == IntPtr.Zero)
					JCB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JCB", "Lio/card/payment/CardType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JCB_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CardType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MAESTRO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/field[@name='MAESTRO']"
		[Register ("MAESTRO")]
		public static global::IO.Card.Payment.CardType Maestro {
			get {
				if (MAESTRO_jfieldId == IntPtr.Zero)
					MAESTRO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAESTRO", "Lio/card/payment/CardType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAESTRO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CardType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MASTERCARD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/field[@name='MASTERCARD']"
		[Register ("MASTERCARD")]
		public static global::IO.Card.Payment.CardType Mastercard {
			get {
				if (MASTERCARD_jfieldId == IntPtr.Zero)
					MASTERCARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MASTERCARD", "Lio/card/payment/CardType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MASTERCARD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CardType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::IO.Card.Payment.CardType Unknown {
			get {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lio/card/payment/CardType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CardType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VISA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/field[@name='VISA']"
		[Register ("VISA")]
		public static global::IO.Card.Payment.CardType Visa {
			get {
				if (VISA_jfieldId == IntPtr.Zero)
					VISA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VISA", "Lio/card/payment/CardType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VISA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CardType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, name_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, name_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/card/payment/CardType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CardType); }
		}

		internal CardType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_cvvLength;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/method[@name='cvvLength' and count(parameter)=0]"
		[Register ("cvvLength", "()I", "")]
		public unsafe int CvvLength ()
		{
			if (id_cvvLength == IntPtr.Zero)
				id_cvvLength = JNIEnv.GetMethodID (class_ref, "cvvLength", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_cvvLength);
			} finally {
			}
		}

		static IntPtr id_fromCardNumber_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/method[@name='fromCardNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromCardNumber", "(Ljava/lang/String;)Lio/card/payment/CardType;", "")]
		public static unsafe global::IO.Card.Payment.CardType FromCardNumber (string p0)
		{
			if (id_fromCardNumber_Ljava_lang_String_ == IntPtr.Zero)
				id_fromCardNumber_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromCardNumber", "(Ljava/lang/String;)Lio/card/payment/CardType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Card.Payment.CardType __ret = global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CardType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromCardNumber_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)Lio/card/payment/CardType;", "")]
		public static unsafe global::IO.Card.Payment.CardType FromString (string p0)
		{
			if (id_fromString_Ljava_lang_String_ == IntPtr.Zero)
				id_fromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromString", "(Ljava/lang/String;)Lio/card/payment/CardType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Card.Payment.CardType __ret = global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CardType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getDisplayName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/method[@name='getDisplayName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDisplayName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string GetDisplayName (string p0)
		{
			if (id_getDisplayName_Ljava_lang_String_ == IntPtr.Zero)
				id_getDisplayName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDisplayName", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_imageBitmap_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/method[@name='imageBitmap' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("imageBitmap", "(Landroid/content/Context;)Landroid/graphics/Bitmap;", "")]
		public unsafe global::Android.Graphics.Bitmap ImageBitmap (global::Android.Content.Context p0)
		{
			if (id_imageBitmap_Landroid_content_Context_ == IntPtr.Zero)
				id_imageBitmap_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "imageBitmap", "(Landroid/content/Context;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_imageBitmap_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_numberLength;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/method[@name='numberLength' and count(parameter)=0]"
		[Register ("numberLength", "()I", "")]
		public unsafe int NumberLength ()
		{
			if (id_numberLength == IntPtr.Zero)
				id_numberLength = JNIEnv.GetMethodID (class_ref, "numberLength", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_numberLength);
			} finally {
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/method[@name='toString' and count(parameter)=0]"
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

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lio/card/payment/CardType;", "")]
		public static unsafe global::IO.Card.Payment.CardType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/card/payment/CardType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::IO.Card.Payment.CardType __ret = global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CardType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CardType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lio/card/payment/CardType;", "")]
		public static unsafe global::IO.Card.Payment.CardType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/card/payment/CardType;");
			try {
				return (global::IO.Card.Payment.CardType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Card.Payment.CardType));
			} finally {
			}
		}

	}
}
