using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Paypal.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']"
	[global::Android.Runtime.Register ("com/paypal/android/sdk/Y", DoNotGenerateAcw=true)]
	public sealed partial class y : global::Java.Lang.Object {


		static IntPtr B_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='B']"
		[Register ("B")]
		public string B {
			get {
				if (B_jfieldId == IntPtr.Zero)
					B_jfieldId = JNIEnv.GetFieldID (class_ref, "B", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, B_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (B_jfieldId == IntPtr.Zero)
					B_jfieldId = JNIEnv.GetFieldID (class_ref, "B", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, B_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr C_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='C']"
		[Register ("C")]
		public global::Java.Lang.Boolean C {
			get {
				if (C_jfieldId == IntPtr.Zero)
					C_jfieldId = JNIEnv.GetFieldID (class_ref, "C", "Ljava/lang/Boolean;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, C_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (C_jfieldId == IntPtr.Zero)
					C_jfieldId = JNIEnv.GetFieldID (class_ref, "C", "Ljava/lang/Boolean;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, C_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr D_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='D']"
		[Register ("D")]
		public string D {
			get {
				if (D_jfieldId == IntPtr.Zero)
					D_jfieldId = JNIEnv.GetFieldID (class_ref, "D", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, D_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (D_jfieldId == IntPtr.Zero)
					D_jfieldId = JNIEnv.GetFieldID (class_ref, "D", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, D_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr E_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='E']"
		[Register ("E")]
		public string E {
			get {
				if (E_jfieldId == IntPtr.Zero)
					E_jfieldId = JNIEnv.GetFieldID (class_ref, "E", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, E_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (E_jfieldId == IntPtr.Zero)
					E_jfieldId = JNIEnv.GetFieldID (class_ref, "E", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, E_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr F_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='F']"
		[Register ("F")]
		public global::Java.Lang.Boolean F {
			get {
				if (F_jfieldId == IntPtr.Zero)
					F_jfieldId = JNIEnv.GetFieldID (class_ref, "F", "Ljava/lang/Boolean;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, F_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (F_jfieldId == IntPtr.Zero)
					F_jfieldId = JNIEnv.GetFieldID (class_ref, "F", "Ljava/lang/Boolean;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, F_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr G_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='G']"
		[Register ("G")]
		public string G {
			get {
				if (G_jfieldId == IntPtr.Zero)
					G_jfieldId = JNIEnv.GetFieldID (class_ref, "G", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, G_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (G_jfieldId == IntPtr.Zero)
					G_jfieldId = JNIEnv.GetFieldID (class_ref, "G", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, G_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr H_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='H']"
		[Register ("H")]
		public string H {
			get {
				if (H_jfieldId == IntPtr.Zero)
					H_jfieldId = JNIEnv.GetFieldID (class_ref, "H", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, H_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (H_jfieldId == IntPtr.Zero)
					H_jfieldId = JNIEnv.GetFieldID (class_ref, "H", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, H_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr I_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='I']"
		[Register ("I")]
		public long I {
			get {
				if (I_jfieldId == IntPtr.Zero)
					I_jfieldId = JNIEnv.GetFieldID (class_ref, "I", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, I_jfieldId);
			}
			set {
				if (I_jfieldId == IntPtr.Zero)
					I_jfieldId = JNIEnv.GetFieldID (class_ref, "I", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, I_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr J_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='J']"
		[Register ("J")]
		public long J {
			get {
				if (J_jfieldId == IntPtr.Zero)
					J_jfieldId = JNIEnv.GetFieldID (class_ref, "J", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, J_jfieldId);
			}
			set {
				if (J_jfieldId == IntPtr.Zero)
					J_jfieldId = JNIEnv.GetFieldID (class_ref, "J", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, J_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr K_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='K']"
		[Register ("K")]
		public string K {
			get {
				if (K_jfieldId == IntPtr.Zero)
					K_jfieldId = JNIEnv.GetFieldID (class_ref, "K", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, K_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (K_jfieldId == IntPtr.Zero)
					K_jfieldId = JNIEnv.GetFieldID (class_ref, "K", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, K_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr L_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='L']"
		[Register ("L")]
		public int L {
			get {
				if (L_jfieldId == IntPtr.Zero)
					L_jfieldId = JNIEnv.GetFieldID (class_ref, "L", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, L_jfieldId);
			}
			set {
				if (L_jfieldId == IntPtr.Zero)
					L_jfieldId = JNIEnv.GetFieldID (class_ref, "L", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, L_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr M_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='M']"
		[Register ("M")]
		public int M {
			get {
				if (M_jfieldId == IntPtr.Zero)
					M_jfieldId = JNIEnv.GetFieldID (class_ref, "M", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, M_jfieldId);
			}
			set {
				if (M_jfieldId == IntPtr.Zero)
					M_jfieldId = JNIEnv.GetFieldID (class_ref, "M", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, M_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr N_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='N']"
		[Register ("N")]
		public string N {
			get {
				if (N_jfieldId == IntPtr.Zero)
					N_jfieldId = JNIEnv.GetFieldID (class_ref, "N", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, N_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (N_jfieldId == IntPtr.Zero)
					N_jfieldId = JNIEnv.GetFieldID (class_ref, "N", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, N_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr O_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='O']"
		[Register ("O")]
		public int O {
			get {
				if (O_jfieldId == IntPtr.Zero)
					O_jfieldId = JNIEnv.GetFieldID (class_ref, "O", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, O_jfieldId);
			}
			set {
				if (O_jfieldId == IntPtr.Zero)
					O_jfieldId = JNIEnv.GetFieldID (class_ref, "O", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, O_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr P_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='P']"
		[Register ("P")]
		public string P {
			get {
				if (P_jfieldId == IntPtr.Zero)
					P_jfieldId = JNIEnv.GetFieldID (class_ref, "P", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, P_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (P_jfieldId == IntPtr.Zero)
					P_jfieldId = JNIEnv.GetFieldID (class_ref, "P", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, P_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr Q_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='Q']"
		[Register ("Q")]
		public global::Java.Lang.Boolean Q {
			get {
				if (Q_jfieldId == IntPtr.Zero)
					Q_jfieldId = JNIEnv.GetFieldID (class_ref, "Q", "Ljava/lang/Boolean;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, Q_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Q_jfieldId == IntPtr.Zero)
					Q_jfieldId = JNIEnv.GetFieldID (class_ref, "Q", "Ljava/lang/Boolean;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, Q_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr R_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='R']"
		[Register ("R")]
		public global::Java.Lang.Boolean R {
			get {
				if (R_jfieldId == IntPtr.Zero)
					R_jfieldId = JNIEnv.GetFieldID (class_ref, "R", "Ljava/lang/Boolean;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, R_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (R_jfieldId == IntPtr.Zero)
					R_jfieldId = JNIEnv.GetFieldID (class_ref, "R", "Ljava/lang/Boolean;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, R_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr S_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='S']"
		[Register ("S")]
		public string S {
			get {
				if (S_jfieldId == IntPtr.Zero)
					S_jfieldId = JNIEnv.GetFieldID (class_ref, "S", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, S_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (S_jfieldId == IntPtr.Zero)
					S_jfieldId = JNIEnv.GetFieldID (class_ref, "S", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, S_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr T_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='T']"
		[Register ("T")]
		public long T {
			get {
				if (T_jfieldId == IntPtr.Zero)
					T_jfieldId = JNIEnv.GetFieldID (class_ref, "T", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, T_jfieldId);
			}
			set {
				if (T_jfieldId == IntPtr.Zero)
					T_jfieldId = JNIEnv.GetFieldID (class_ref, "T", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, T_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr U_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='U']"
		[Register ("U")]
		public long U {
			get {
				if (U_jfieldId == IntPtr.Zero)
					U_jfieldId = JNIEnv.GetFieldID (class_ref, "U", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, U_jfieldId);
			}
			set {
				if (U_jfieldId == IntPtr.Zero)
					U_jfieldId = JNIEnv.GetFieldID (class_ref, "U", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, U_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr V_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='V']"
		[Register ("V")]
		public string V {
			get {
				if (V_jfieldId == IntPtr.Zero)
					V_jfieldId = JNIEnv.GetFieldID (class_ref, "V", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, V_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (V_jfieldId == IntPtr.Zero)
					V_jfieldId = JNIEnv.GetFieldID (class_ref, "V", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, V_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr W_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='W']"
		[Register ("W")]
		public string W {
			get {
				if (W_jfieldId == IntPtr.Zero)
					W_jfieldId = JNIEnv.GetFieldID (class_ref, "W", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, W_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (W_jfieldId == IntPtr.Zero)
					W_jfieldId = JNIEnv.GetFieldID (class_ref, "W", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, W_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr X_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='X']"
		[Register ("X")]
		public string X {
			get {
				if (X_jfieldId == IntPtr.Zero)
					X_jfieldId = JNIEnv.GetFieldID (class_ref, "X", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, X_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (X_jfieldId == IntPtr.Zero)
					X_jfieldId = JNIEnv.GetFieldID (class_ref, "X", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, X_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr Y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='Y']"
		[Register ("Y")]
		public string Y {
			get {
				if (Y_jfieldId == IntPtr.Zero)
					Y_jfieldId = JNIEnv.GetFieldID (class_ref, "Y", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, Y_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Y_jfieldId == IntPtr.Zero)
					Y_jfieldId = JNIEnv.GetFieldID (class_ref, "Y", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, Y_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr Z_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='Z']"
		[Register ("Z")]
		public string Z {
			get {
				if (Z_jfieldId == IntPtr.Zero)
					Z_jfieldId = JNIEnv.GetFieldID (class_ref, "Z", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, Z_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Z_jfieldId == IntPtr.Zero)
					Z_jfieldId = JNIEnv.GetFieldID (class_ref, "Z", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, Z_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr aa_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='aa']"
		[Register ("aa")]
		public string Aa {
			get {
				if (aa_jfieldId == IntPtr.Zero)
					aa_jfieldId = JNIEnv.GetFieldID (class_ref, "aa", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, aa_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (aa_jfieldId == IntPtr.Zero)
					aa_jfieldId = JNIEnv.GetFieldID (class_ref, "aa", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, aa_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ab_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='ab']"
		[Register ("ab")]
		public string Ab {
			get {
				if (ab_jfieldId == IntPtr.Zero)
					ab_jfieldId = JNIEnv.GetFieldID (class_ref, "ab", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ab_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ab_jfieldId == IntPtr.Zero)
					ab_jfieldId = JNIEnv.GetFieldID (class_ref, "ab", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ab_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ac_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/field[@name='ac']"
		[Register ("ac")]
		public global::System.Collections.IDictionary Ac {
			get {
				if (ac_jfieldId == IntPtr.Zero)
					ac_jfieldId = JNIEnv.GetFieldID (class_ref, "ac", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ac_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ac_jfieldId == IntPtr.Zero)
					ac_jfieldId = JNIEnv.GetFieldID (class_ref, "ac", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ac_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/paypal/android/sdk/Y", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (y); }
		}

		internal y (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/constructor[@name='Y' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe y ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (y)) {
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

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lorg/json/JSONObject;", "")]
		public unsafe global::Org.Json.JSONObject A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Lorg/json/JSONObject;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_a_Lcom_paypal_android_sdk_Y_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.paypal.android.sdk']/class[@name='Y']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.paypal.android.sdk.Y']]"
		[Register ("a", "(Lcom/paypal/android/sdk/Y;)Lorg/json/JSONObject;", "")]
		public unsafe global::Org.Json.JSONObject A (global::Com.Paypal.Android.Sdk.y p0)
		{
			if (id_a_Lcom_paypal_android_sdk_Y_ == IntPtr.Zero)
				id_a_Lcom_paypal_android_sdk_Y_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/paypal/android/sdk/Y;)Lorg/json/JSONObject;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a_Lcom_paypal_android_sdk_Y_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
