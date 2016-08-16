﻿// Licensed under the GPL License, Version 3.0. See LICENSE in the git repository root for license information.

using System.Xml.Linq;

namespace MainSMS
{
	/// <summary>Response with balance of account.</summary>
	/// <seealso cref="BaseResponse" />
	public class BalanceInfo : BaseResponse
	{
		/// <summary>Initializes a new instance of the <see cref="BalanceInfo" /> class.</summary>
		/// <param name="response">The response.</param>
		public BalanceInfo(XContainer response) : base(response)
		{
			if (!ErrorsHandler())
				return;

			Balance = ExtractDouble("balance");
		}

		/// <summary>Gets the balance.</summary>
		/// <value>The balance.</value>
		public double Balance { get; private set; }
	}
}