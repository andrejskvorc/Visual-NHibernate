﻿using System.Runtime.InteropServices;

namespace ArchAngel.Licensing
{
	/// <summary>
	/// Contains calls to unmanaged code.
	/// </summary>

	// Sealed because this is a static class
	// Class called NativeMethods to satisfy FxCop!
	public sealed class NativeMethods
	{
		// P/Invoke to check various security settings
		// Using byte for arguments rather than bool, because bool won't work on 64-bit Windows!
		[DllImport("mscoree.dll", CharSet = CharSet.Unicode)]
		private static extern bool StrongNameSignatureVerificationEx(string wszFilePath, byte fForceVerification, ref byte pfWasVerified);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
		private static extern int IsDebuggerPresent();

		// Private constructor because this type has no non-static members
		private NativeMethods()
		{
		}

		public static bool UnmanagedDebuggerPresent()
		{
			return (IsDebuggerPresent() == 1);
		}

		public static bool CheckSignature(string assemblyName, byte forceVerification, ref byte wasVerified)
		{
			return StrongNameSignatureVerificationEx(assemblyName, forceVerification, ref wasVerified);
		}

	}
}
