﻿using System.Security;

using GostCryptography.Asn1.Gost.Gost_R3410_2012_256;
using GostCryptography.Base;
using GostCryptography.Native;

namespace GostCryptography.Gost_R3410
{
	/// <inheritdoc />
	public sealed class Gost_R3410_2012_256_KeyExchangeAlgorithm : Gost_R3410_KeyExchangeAlgorithm
	{
		/// <inheritdoc />
		[SecurityCritical]
		public Gost_R3410_2012_256_KeyExchangeAlgorithm(ProviderType providerType, SafeProvHandleImpl provHandle, SafeKeyHandleImpl keyHandle, Gost_R3410_2012_256_KeyExchangeParams keyExchangeParameters, int keySize, int signatureAlgId)
			: base(providerType, provHandle, keyHandle, keyExchangeParameters, keySize, signatureAlgId)
		{
		}
	}
}