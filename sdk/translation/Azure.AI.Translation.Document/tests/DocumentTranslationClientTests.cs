// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.Translation.Document.Tests
{
    public class DocumentTranslationClientTests : ClientTestBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTranslationClientTests"/> class.
        /// </summary>
        /// <param name="isAsync">A flag used by the Azure Core Test Framework to differentiate between tests for asynchronous and synchronous methods.</param>
        public DocumentTranslationClientTests(bool isAsync)
            : base(isAsync)
        {
        }

        #region client
        /// <summary>
        /// Verifies functionality of the <see cref="DocumentTranslationClient"/> constructors.
        /// </summary>
        [Test]
        public void ConstructorRequiresTheEndpoint()
        {
            var keyCredential = new AzureKeyCredential("key");

            Assert.Throws<ArgumentNullException>(() => new DocumentTranslationClient(null, keyCredential));
            Assert.Throws<ArgumentNullException>(() => new DocumentTranslationClient(null, keyCredential, new DocumentTranslationClientOptions()));
        }

        /// <summary>
        /// Verifies functionality of the <see cref="DocumentTranslationClient"/> constructors.
        /// </summary>
        [Test]
        public void ConstructorRequiresTheAzureKeyCredential()
        {
            var endpoint = new Uri("http://localhost");

            Assert.Throws<ArgumentNullException>(() => new DocumentTranslationClient(endpoint, default(AzureKeyCredential)));
            Assert.Throws<ArgumentNullException>(() => new DocumentTranslationClient(endpoint, default(AzureKeyCredential), new DocumentTranslationClientOptions()));
        }

        /// <summary>
        /// Verifies functionality of the <see cref="DocumentTranslationClient"/> constructors.
        /// </summary>
        [Test]
        public void ConstructorRequiresTheOptions()
        {
            var endpoint = new Uri("http://localhost");
            var keyCredential = new AzureKeyCredential("key");

            Assert.Throws<ArgumentNullException>(() => new DocumentTranslationClient(endpoint, keyCredential, null));
        }

        #endregion

        [Test]
        public void DocumentStatusResultConvertBinaryDataToJsonElement()
        {
            var errorJson = @"{
                                ""code"": ""PartialError"",
                                ""message"": ""There were some errors.""
                           }";

            var result = DocumentTranslationModelFactory.DocumentStatusResult(
                "43534534",
                new Uri("http://localhost"),
                new BinaryData(errorJson),
                default,
                default,
                DocumentTranslationStatus.Succeeded,
                default,
                default,
                default);

            Assert.AreEqual("43534534", result.Id);
            Assert.AreEqual("PartialError", result.Error.Code);
            Assert.AreEqual("There were some errors.", result.Error.Message);
        }

        [Test]
        public void TranslationStatusResultConvertBinaryDataToJsonElement()
        {
            var errorJson = @"{
                                ""code"": ""PartialError"",
                                ""message"": ""There were some errors.""
                           }";

            var result = DocumentTranslationModelFactory.TranslationStatusResult(
                "43534534",
                default,
                default,
                DocumentTranslationStatus.Succeeded,
                new BinaryData(errorJson),
                default,
                default,
                default,
                default,
                default,
                default,
                default);

            Assert.AreEqual("43534534", result.Id);
            Assert.AreEqual("PartialError", result.Error.Code);
            Assert.AreEqual("There were some errors.", result.Error.Message);
        }
    }
}
