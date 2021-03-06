﻿// © Anamnesis.
// Developed by W and A Walsh.
// Licensed under the MIT license.

namespace Anamnesis.GameData
{
	using System;
	using Anamnesis.Memory;

	public interface ITribe : IRow, IEquatable<ITribe>
	{
		Appearance.Tribes Tribe { get; }
		string Feminine { get; }
		string Masculine { get; }
		string DisplayName { get; }
	}
}
