using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Z']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/Z", DoNotGenerateAcw=true)]
	public partial class Z : global::Java.Lang.Object, global::Android.Locations.ILocationListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/Z", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Z); }
		}

		protected Z (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Z']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/paypal/android/sdk/Z;", "")]
		public static unsafe global::Com.Paypal.Android.Sdk.Z A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()Lcom/paypal/android/sdk/Z;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Z> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_os_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Z']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("a", "(Landroid/os/Message;)V", "")]
		public unsafe void A (global::Android.OS.Message p0)
		{
			if (id_a_Landroid_os_Message_ == IntPtr.Zero)
				id_a_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/os/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Landroid_os_Message_, __args);
			} finally {
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Z']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "")]
		public unsafe void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_b);
			} finally {
			}
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Z']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Lorg/json/JSONObject;", "")]
		public unsafe global::Org.Json.JSONObject C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Lorg/json/JSONObject;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_c), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Z']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Ljava/lang/String;", "")]
		public static unsafe string D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetStaticMethodID (class_ref, "d", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_d), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Z']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()V", "")]
		public unsafe void E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_e);
			} finally {
			}
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Z']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()V", "")]
		public unsafe void F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_f);
			} finally {
			}
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Z']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()Ljava/lang/String;", "")]
		public unsafe string G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_g), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onLocationChanged_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetOnLocationChanged_Landroid_location_Location_Handler ()
		{
			if (cb_onLocationChanged_Landroid_location_Location_ == null)
				cb_onLocationChanged_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocationChanged_Landroid_location_Location_);
			return cb_onLocationChanged_Landroid_location_Location_;
		}

		static void n_OnLocationChanged_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Paypal.Android.Sdk.Z __this = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Z> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onLocationChanged_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Z']/method[@name='onLocationChanged' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("onLocationChanged", "(Landroid/location/Location;)V", "GetOnLocationChanged_Landroid_location_Location_Handler")]
		public virtual unsafe void OnLocationChanged (global::Android.Locations.Location p0)
		{
			if (id_onLocationChanged_Landroid_location_Location_ == IntPtr.Zero)
				id_onLocationChanged_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onLocationChanged", "(Landroid/location/Location;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLocationChanged_Landroid_location_Location_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLocationChanged", "(Landroid/location/Location;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onProviderDisabled_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnProviderDisabled_Ljava_lang_String_Handler ()
		{
			if (cb_onProviderDisabled_Ljava_lang_String_ == null)
				cb_onProviderDisabled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnProviderDisabled_Ljava_lang_String_);
			return cb_onProviderDisabled_Ljava_lang_String_;
		}

		static void n_OnProviderDisabled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Paypal.Android.Sdk.Z __this = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Z> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnProviderDisabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onProviderDisabled_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Z']/method[@name='onProviderDisabled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onProviderDisabled", "(Ljava/lang/String;)V", "GetOnProviderDisabled_Ljava_lang_String_Handler")]
		public virtual unsafe void OnProviderDisabled (string p0)
		{
			if (id_onProviderDisabled_Ljava_lang_String_ == IntPtr.Zero)
				id_onProviderDisabled_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onProviderDisabled", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProviderDisabled_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onProviderDisabled", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onProviderEnabled_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnProviderEnabled_Ljava_lang_String_Handler ()
		{
			if (cb_onProviderEnabled_Ljava_lang_String_ == null)
				cb_onProviderEnabled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnProviderEnabled_Ljava_lang_String_);
			return cb_onProviderEnabled_Ljava_lang_String_;
		}

		static void n_OnProviderEnabled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Paypal.Android.Sdk.Z __this = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Z> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnProviderEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onProviderEnabled_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Z']/method[@name='onProviderEnabled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onProviderEnabled", "(Ljava/lang/String;)V", "GetOnProviderEnabled_Ljava_lang_String_Handler")]
		public virtual unsafe void OnProviderEnabled (string p0)
		{
			if (id_onProviderEnabled_Ljava_lang_String_ == IntPtr.Zero)
				id_onProviderEnabled_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onProviderEnabled", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProviderEnabled_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onProviderEnabled", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_Handler ()
		{
			if (cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ == null)
				cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_);
			return cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
		}

		static void n_OnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, IntPtr native_p2)
		{
			global::Com.Paypal.Android.Sdk.Z __this = global::Java.Lang.Object.GetObject<global::Com.Paypal.Android.Sdk.Z> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Availability p1 = (global::Android.Locations.Availability) native_p1;
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnStatusChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Z']/method[@name='onStatusChanged' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V", "GetOnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_Handler")]
		public virtual unsafe void OnStatusChanged (string p0, [global::Android.Runtime.GeneratedEnum] global::Android.Locations.Availability p1, global::Android.OS.Bundle p2)
		{
			if (id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue ((int) p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
