// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Mono.Linker.Tests.Cases.Expectations.Metadata
{
	[AttributeUsage (AttributeTargets.Class, AllowMultiple = true)]
	public class SetupLinkerResponseFileAttribute : BaseMetadataAttribute
	{
		public SetupLinkerResponseFileAttribute (string relativePathToFile, string destinationFileName = null)
		{
			ArgumentException.ThrowIfNullOrEmpty (relativePathToFile);
		}
	}
}