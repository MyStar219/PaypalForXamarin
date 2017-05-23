using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Card.Payment {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.card.payment']/class[@name='CreditCard']"
	[global::Android.Runtime.Register ("io/card/payment/CreditCard", DoNotGenerateAcw=true)]
	public partial class CreditCard : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CreditCard']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CreditCard']/field[@name='EXPIRY_MAX_FUTURE_YEARS']"
		[Register ("EXPIRY_MAX_FUTURE_YEARS")]
		public const int ExpiryMaxFutureYears = (int) 15;

		static IntPtr cardNumber_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CreditCard']/field[@name='cardNumber']"
		[Register ("cardNumber")]
		public string CardNumber {
			get {
				if (cardNumber_jfieldId == IntPtr.Zero)
					cardNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "cardNumber", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cardNumber_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cardNumber_jfieldId == IntPtr.Zero)
					cardNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "cardNumber", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cardNumber_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr cvv_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CreditCard']/field[@name='cvv']"
		[Register ("cvv")]
		public string Cvv {
			get {
				if (cvv_jfieldId == IntPtr.Zero)
					cvv_jfieldId = JNIEnv.GetFieldID (class_ref, "cvv", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cvv_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cvv_jfieldId == IntPtr.Zero)
					cvv_jfieldId = JNIEnv.GetFieldID (class_ref, "cvv", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cvv_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr expiryMonth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CreditCard']/field[@name='expiryMonth']"
		[Register ("expiryMonth")]
		public int ExpiryMonth {
			get {
				if (expiryMonth_jfieldId == IntPtr.Zero)
					expiryMonth_jfieldId = JNIEnv.GetFieldID (class_ref, "expiryMonth", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, expiryMonth_jfieldId);
			}
			set {
				if (expiryMonth_jfieldId == IntPtr.Zero)
					expiryMonth_jfieldId = JNIEnv.GetFieldID (class_ref, "expiryMonth", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, expiryMonth_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr expiryYear_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CreditCard']/field[@name='expiryYear']"
		[Register ("expiryYear")]
		public int ExpiryYear {
			get {
				if (expiryYear_jfieldId == IntPtr.Zero)
					expiryYear_jfieldId = JNIEnv.GetFieldID (class_ref, "expiryYear", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, expiryYear_jfieldId);
			}
			set {
				if (expiryYear_jfieldId == IntPtr.Zero)
					expiryYear_jfieldId = JNIEnv.GetFieldID (class_ref, "expiryYear", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, expiryYear_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr postalCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.card.payment']/class[@name='CreditCard']/field[@name='postalCode']"
		[Register ("postalCode")]
		public string PostalCode {
			get {
				if (postalCode_jfieldId == IntPtr.Zero)
					postalCode_jfieldId = JNIEnv.GetFieldID (class_ref, "postalCode", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, postalCode_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (postalCode_jfieldId == IntPtr.Zero)
					postalCode_jfieldId = JNIEnv.GetFieldID (class_ref, "postalCode", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, postalCode_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/card/payment/CreditCard", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CreditCard); }
		}

		protected CreditCard (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.card.payment']/class[@name='CreditCard']/constructor[@name='CreditCard' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe CreditCard (string p0, int p1, int p2, string p3, string p4)
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
				if (((object) this).GetType () != typeof (CreditCard)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;IILjava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_IILjava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.card.payment']/class[@name='CreditCard']/constructor[@name='CreditCard' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CreditCard ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CreditCard)) {
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

		static Delegate cb_getCardType;
#pragma warning disable 0169
		static Delegate GetGetCardTypeHandler ()
		{
			if (cb_getCardType == null)
				cb_getCardType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCardType);
			return cb_getCardType;
		}

		static IntPtr n_GetCardType (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Card.Payment.CreditCard __this = global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CreditCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CardType);
		}
#pragma warning restore 0169

		static IntPtr id_getCardType;
		public virtual unsafe global::IO.Card.Payment.CardType CardType {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CreditCard']/method[@name='getCardType' and count(parameter)=0]"
			[Register ("getCardType", "()Lio/card/payment/CardType;", "GetGetCardTypeHandler")]
			get {
				if (id_getCardType == IntPtr.Zero)
					id_getCardType = JNIEnv.GetMethodID (class_ref, "getCardType", "()Lio/card/payment/CardType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CardType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCardType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CardType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCardType", "()Lio/card/payment/CardType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFormattedCardNumber;
#pragma warning disable 0169
		static Delegate GetGetFormattedCardNumberHandler ()
		{
			if (cb_getFormattedCardNumber == null)
				cb_getFormattedCardNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormattedCardNumber);
			return cb_getFormattedCardNumber;
		}

		static IntPtr n_GetFormattedCardNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Card.Payment.CreditCard __this = global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CreditCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FormattedCardNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getFormattedCardNumber;
		public virtual unsafe string FormattedCardNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CreditCard']/method[@name='getFormattedCardNumber' and count(parameter)=0]"
			[Register ("getFormattedCardNumber", "()Ljava/lang/String;", "GetGetFormattedCardNumberHandler")]
			get {
				if (id_getFormattedCardNumber == IntPtr.Zero)
					id_getFormattedCardNumber = JNIEnv.GetMethodID (class_ref, "getFormattedCardNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormattedCardNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFormattedCardNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isExpiryValid;
#pragma warning disable 0169
		static Delegate GetIsExpiryValidHandler ()
		{
			if (cb_isExpiryValid == null)
				cb_isExpiryValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExpiryValid);
			return cb_isExpiryValid;
		}

		static bool n_IsExpiryValid (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Card.Payment.CreditCard __this = global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CreditCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpiryValid;
		}
#pragma warning restore 0169

		static IntPtr id_isExpiryValid;
		public virtual unsafe bool IsExpiryValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CreditCard']/method[@name='isExpiryValid' and count(parameter)=0]"
			[Register ("isExpiryValid", "()Z", "GetIsExpiryValidHandler")]
			get {
				if (id_isExpiryValid == IntPtr.Zero)
					id_isExpiryValid = JNIEnv.GetMethodID (class_ref, "isExpiryValid", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExpiryValid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isExpiryValid", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLastFourDigitsOfCardNumber;
#pragma warning disable 0169
		static Delegate GetGetLastFourDigitsOfCardNumberHandler ()
		{
			if (cb_getLastFourDigitsOfCardNumber == null)
				cb_getLastFourDigitsOfCardNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastFourDigitsOfCardNumber);
			return cb_getLastFourDigitsOfCardNumber;
		}

		static IntPtr n_GetLastFourDigitsOfCardNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Card.Payment.CreditCard __this = global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CreditCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LastFourDigitsOfCardNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getLastFourDigitsOfCardNumber;
		public virtual unsafe string LastFourDigitsOfCardNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CreditCard']/method[@name='getLastFourDigitsOfCardNumber' and count(parameter)=0]"
			[Register ("getLastFourDigitsOfCardNumber", "()Ljava/lang/String;", "GetGetLastFourDigitsOfCardNumberHandler")]
			get {
				if (id_getLastFourDigitsOfCardNumber == IntPtr.Zero)
					id_getLastFourDigitsOfCardNumber = JNIEnv.GetMethodID (class_ref, "getLastFourDigitsOfCardNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastFourDigitsOfCardNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastFourDigitsOfCardNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRedactedCardNumber;
#pragma warning disable 0169
		static Delegate GetGetRedactedCardNumberHandler ()
		{
			if (cb_getRedactedCardNumber == null)
				cb_getRedactedCardNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRedactedCardNumber);
			return cb_getRedactedCardNumber;
		}

		static IntPtr n_GetRedactedCardNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Card.Payment.CreditCard __this = global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CreditCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RedactedCardNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getRedactedCardNumber;
		public virtual unsafe string RedactedCardNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CreditCard']/method[@name='getRedactedCardNumber' and count(parameter)=0]"
			[Register ("getRedactedCardNumber", "()Ljava/lang/String;", "GetGetRedactedCardNumberHandler")]
			get {
				if (id_getRedactedCardNumber == IntPtr.Zero)
					id_getRedactedCardNumber = JNIEnv.GetMethodID (class_ref, "getRedactedCardNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRedactedCardNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRedactedCardNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::IO.Card.Payment.CreditCard __this = global::Java.Lang.Object.GetObject<global::IO.Card.Payment.CreditCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CreditCard']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.card.payment']/class[@name='CreditCard']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
