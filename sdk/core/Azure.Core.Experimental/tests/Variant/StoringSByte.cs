﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using NUnit.Framework;

namespace Azure
{
    public class StoringSByte
    {
        [TestCase(0)]
        [TestCase(42)]
        [TestCase(sbyte.MinValue)]
        [TestCase(sbyte.MaxValue)]
        public void SByteImplicit(sbyte testValue)
        {
            Value value = testValue;
            Assert.AreEqual(testValue, value.As<sbyte>());
            Assert.AreEqual(typeof(sbyte), value.Type);

            sbyte? source = testValue;
            value = source;
            Assert.AreEqual(source, value.As<sbyte?>());
            Assert.AreEqual(typeof(sbyte), value.Type);
        }

        [TestCase(0)]
        [TestCase(42)]
        [TestCase(sbyte.MinValue)]
        [TestCase(sbyte.MaxValue)]
        public void SByteCreate(sbyte testValue)
        {
            Value value;
            using (MemoryWatch.Create())
            {
                value = Value.Create(testValue);
            }

            Assert.AreEqual(testValue, value.As<sbyte>());
            Assert.AreEqual(typeof(sbyte), value.Type);

            sbyte? source = testValue;

            using (MemoryWatch.Create())
            {
                value = Value.Create(source);
            }

            Assert.AreEqual(source, value.As<sbyte?>());
            Assert.AreEqual(typeof(sbyte), value.Type);
        }

        [TestCase(0)]
        [TestCase(42)]
        [TestCase(sbyte.MinValue)]
        [TestCase(sbyte.MaxValue)]
        public void SByteInOut(sbyte testValue)
        {
            Value value = new(testValue);
            bool success = value.TryGetValue(out sbyte result);
            Assert.True(success);
            Assert.AreEqual(testValue, result);

            Assert.AreEqual(testValue, value.As<sbyte>());
            Assert.AreEqual(testValue, (sbyte)value);
        }

        [TestCase(0)]
        [TestCase(42)]
        [TestCase(sbyte.MinValue)]
        [TestCase(sbyte.MaxValue)]
        public void NullableSByteInSByteOut(sbyte? testValue)
        {
            sbyte? source = testValue;
            Value value = new(source);

            bool success = value.TryGetValue(out sbyte result);
            Assert.True(success);
            Assert.AreEqual(testValue, result);

            Assert.AreEqual(testValue, value.As<sbyte>());

            Assert.AreEqual(testValue, (sbyte)value);
        }

        [TestCase(0)]
        [TestCase(42)]
        [TestCase(sbyte.MinValue)]
        [TestCase(sbyte.MaxValue)]
        public void SByteInNullableSByteOut(sbyte testValue)
        {
            sbyte source = testValue;
            Value value = new(source);
            bool success = value.TryGetValue(out sbyte? result);
            Assert.True(success);
            Assert.AreEqual(testValue, result);

            Assert.AreEqual(testValue, (sbyte?)value);
        }

        [Test]
        public void NullSByte()
        {
            sbyte? source = null;
            Value value = source;
            Assert.Null(value.Type);
            Assert.AreEqual(source, value.As<sbyte?>());
            Assert.False(value.As<sbyte?>().HasValue);
        }

        [TestCase(0)]
        [TestCase(42)]
        [TestCase(sbyte.MinValue)]
        [TestCase(sbyte.MaxValue)]
        public void OutAsObject(sbyte testValue)
        {
            Value value = new(testValue);
            object o = value.As<object>();
            Assert.AreEqual(typeof(sbyte), o.GetType());
            Assert.AreEqual(testValue, (sbyte)o);

            sbyte? n = testValue;
            value = new(n);
            o = value.As<object>();
            Assert.AreEqual(typeof(sbyte), o.GetType());
            Assert.AreEqual(testValue, (sbyte)o);
        }
    }
}
