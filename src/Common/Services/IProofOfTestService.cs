﻿// Copyright 2020 De Staat der Nederlanden, Ministerie van Volksgezondheid, Welzijn en Sport.
// Licensed under the EUROPEAN UNION PUBLIC LICENCE v. 1.2
// SPDX-License-Identifier: EUPL-1.2

namespace NL.Rijksoverheid.CoronaTester.BackEnd.Common.Services
{
    public interface IProofOfTestService
    {
        /// <summary>
        /// Signs the given attributes and returns the signature wrapped as base64 encoded string
        /// </summary>
        /// <param name="testType">Well known string identifying the type of test.</param>
        /// <param name="dateTime">UTC date/time in ISO format with time rounded to the hour</param>
        /// <param name="nonce">Nonce bytes in b64 format</param>
        /// <returns></returns>
        string GetProofOfTest(string testType, string dateTime, string nonce);

        /// <summary>
        /// Generates a nonce and returns the value as a base64 string
        /// </summary>
        /// <returns></returns>
        string GenerateNonce();
    }
}
