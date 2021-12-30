using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericCollection;

namespace NumericCollectionTest
{
    [TestClass]
    public class NumericCollectionTest
    {
        private NumericCollection<short> _collectionShorts = new();
        private NumericCollection<int> _collectionInts = new();
        private NumericCollection<long> _collectionLongs = new();
        private NumericCollection<float> _collectionFloats = new();
        private NumericCollection<double> _collectionDoubles = new();
        private NumericCollection<decimal> _collectionDecimals = new();
        private NumericCollection<sbyte> _collectionSbytes = new();
        private NumericCollection<byte> _collectionBytes = new();
        private NumericCollection<ushort> _collectionUshorts = new();
        private NumericCollection<uint> _collectionUints = new();
        private NumericCollection<ulong> _collectionUlongs = new();
        
        [TestMethod]
        public void AddTest()
        {
            _collectionShorts.Add(1);
            _collectionInts.Add(1);
            _collectionLongs.Add(1);
            _collectionFloats.Add(1);
            _collectionDoubles.Add(1);
            _collectionDecimals.Add(1);
            _collectionSbytes.Add(1);
            _collectionBytes.Add(1);
            _collectionUshorts.Add(1);
            _collectionUints.Add(1);
            _collectionUlongs.Add(1);
            Assert.AreEqual(0,_collectionShorts.IndexOf(1));
            Assert.AreEqual(0,_collectionInts.IndexOf(1));
            Assert.AreEqual(0,_collectionLongs.IndexOf(1));
            Assert.AreEqual(0,_collectionFloats.IndexOf(1));
            Assert.AreEqual(0,_collectionDoubles.IndexOf(1));
            Assert.AreEqual(0,_collectionDecimals.IndexOf(1));
            Assert.AreEqual(0,_collectionSbytes.IndexOf(1));
            Assert.AreEqual(0,_collectionBytes.IndexOf(1));
            Assert.AreEqual(0,_collectionUshorts.IndexOf(1));
            Assert.AreEqual(0,_collectionUints.IndexOf(1));
            Assert.AreEqual(0,_collectionUlongs.IndexOf(1));
        }
        [TestMethod]
        public void InsertTest()
        {
            _collectionShorts.Insert(0,2);
            _collectionInts.Insert(0,2);
            _collectionLongs.Insert(0,2);
            _collectionFloats.Insert(0,2);
            _collectionDoubles.Insert(0,2);
            _collectionDecimals.Insert(0,2);
            _collectionSbytes.Insert(0,2);
            _collectionBytes.Insert(0,2);
            _collectionUshorts.Insert(0,2);
            _collectionUints.Insert(0,2);
            _collectionUlongs.Insert(0,2);
            Assert.AreEqual(0,_collectionShorts.IndexOf(2));
            Assert.AreEqual(0,_collectionInts.IndexOf(2));
            Assert.AreEqual(0,_collectionLongs.IndexOf(2));
            Assert.AreEqual(0,_collectionFloats.IndexOf(2));
            Assert.AreEqual(0,_collectionDoubles.IndexOf(2));
            Assert.AreEqual(0,_collectionDecimals.IndexOf(2));
            Assert.AreEqual(0,_collectionSbytes.IndexOf(2));
            Assert.AreEqual(0,_collectionBytes.IndexOf(2));
            Assert.AreEqual(0,_collectionUshorts.IndexOf(2));
            Assert.AreEqual(0,_collectionUints.IndexOf(2));
            Assert.AreEqual(0,_collectionUlongs.IndexOf(2));
        }
        [TestMethod]
        public void RemoveTest()
        {
            AddTest();
            _collectionShorts.Remove(1);
            _collectionInts.Remove(1);
            _collectionLongs.Remove(1);
            _collectionFloats.Remove(1);
            _collectionDoubles.Remove(1);
            _collectionDecimals.Remove(1);
            _collectionSbytes.Remove(1);
            _collectionBytes.Remove(1);
            _collectionUshorts.Remove(1);
            _collectionUints.Remove(1);
            _collectionUlongs.Remove(1);
            Assert.AreEqual(-1,_collectionShorts.IndexOf(1));
            Assert.AreEqual(-1,_collectionInts.IndexOf(1));
            Assert.AreEqual(-1,_collectionLongs.IndexOf(1));
            Assert.AreEqual(-1,_collectionFloats.IndexOf(1));
            Assert.AreEqual(-1,_collectionDoubles.IndexOf(1));
            Assert.AreEqual(-1,_collectionDecimals.IndexOf(1));
            Assert.AreEqual(-1,_collectionSbytes.IndexOf(1));
            Assert.AreEqual(-1,_collectionBytes.IndexOf(1));
            Assert.AreEqual(-1,_collectionUshorts.IndexOf(1));
            Assert.AreEqual(-1,_collectionUints.IndexOf(1));
            Assert.AreEqual(-1,_collectionUlongs.IndexOf(1));
        }
        [TestMethod]
        public void RemoveAtTest()
        {
            AddTest();
            _collectionShorts.RemoveAt(0);
            _collectionInts.RemoveAt(0);
            _collectionLongs.RemoveAt(0);
            _collectionFloats.RemoveAt(0);
            _collectionDoubles.RemoveAt(0);
            _collectionDecimals.RemoveAt(0);
            _collectionSbytes.RemoveAt(0);
            _collectionBytes.RemoveAt(0);
            _collectionUshorts.RemoveAt(0);
            _collectionUints.RemoveAt(0);
            _collectionUlongs.RemoveAt(0);
            Assert.AreEqual(-1,_collectionShorts.IndexOf(1));
            Assert.AreEqual(-1,_collectionInts.IndexOf(1));
            Assert.AreEqual(-1,_collectionLongs.IndexOf(1));
            Assert.AreEqual(-1,_collectionFloats.IndexOf(1));
            Assert.AreEqual(-1,_collectionDoubles.IndexOf(1));
            Assert.AreEqual(-1,_collectionDecimals.IndexOf(1));
            Assert.AreEqual(-1,_collectionSbytes.IndexOf(1));
            Assert.AreEqual(-1,_collectionBytes.IndexOf(1));
            Assert.AreEqual(-1,_collectionUshorts.IndexOf(1));
            Assert.AreEqual(-1,_collectionUints.IndexOf(1));
            Assert.AreEqual(-1,_collectionUlongs.IndexOf(1));
        }

        [TestMethod]
        public void MaxValueTest()
        {
            AddTest();
            Assert.AreEqual((short)1,_collectionShorts.MaxValue);
            Assert.AreEqual((int)1,_collectionInts.MaxValue);
            Assert.AreEqual((long)1,_collectionLongs.MaxValue);
            Assert.AreEqual((float)1,_collectionFloats.MaxValue);
            Assert.AreEqual((double)1,_collectionDoubles.MaxValue);
            Assert.AreEqual((decimal)1,_collectionDecimals.MaxValue);
            Assert.AreEqual((sbyte)1,_collectionSbytes.MaxValue);
            Assert.AreEqual((byte)1,_collectionBytes.MaxValue);
            Assert.AreEqual((ushort)1,_collectionUshorts.MaxValue);
            Assert.AreEqual((uint)1,_collectionUints.MaxValue);
            Assert.AreEqual((ulong)1,_collectionUlongs.MaxValue);
        }
    }
}