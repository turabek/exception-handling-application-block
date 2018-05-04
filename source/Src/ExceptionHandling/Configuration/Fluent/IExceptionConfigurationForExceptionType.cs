﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using EnterpriseLibrary.ExceptionHandling;

namespace EnterpriseLibrary.Common.Configuration.Fluent
{
    /// <summary>
    /// Fluent interface extensions for configuring an exception type on a <see cref="ExceptionPolicy"/>
    /// </summary>
    public interface IExceptionConfigurationForExceptionType : IExceptionConfigurationGivenPolicyWithName
    {
        /// <summary>
        /// The <see cref="Exception"/> handled under the <see cref="ExceptionPolicy"/>.
        /// </summary>
        /// <param name="exceptionType">The type of <see cref="Exception"/> handled for this policy.</param>
        /// <returns></returns>
        IExceptionConfigurationAddExceptionHandlers ForExceptionType(Type exceptionType);

        /// <summary>
        /// The <see cref="Exception"/> handled under the <see cref="ExceptionPolicy"/>.
        /// </summary>
        /// <typeparam name="T">The type of <see cref="Exception"/> handled for this policy.</typeparam>
        /// <returns></returns>
        IExceptionConfigurationAddExceptionHandlers ForExceptionType<T>() where T : Exception;

    }
}