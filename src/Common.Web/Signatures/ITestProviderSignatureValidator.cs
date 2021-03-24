﻿// Copyright 2020 De Staat der Nederlanden, Ministerie van Volksgezondheid, Welzijn en Sport.
// Licensed under the EUROPEAN UNION PUBLIC LICENCE v. 1.2
// SPDX-License-Identifier: EUPL-1.2

namespace NL.Rijksoverheid.CoronaTester.BackEnd.Common.Web.Signatures
{
    public interface ITestProviderSignatureValidator
    {
        void Initialize();
        bool Validate(string provider, byte[] content, byte[] signature);
    }
}