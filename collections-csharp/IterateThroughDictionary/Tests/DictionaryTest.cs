using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IterateThroughDictionary;
using System.Collections.Generic;
using System.IO;

namespace DictionaryTests
{
    [TestClass]
    public class DictionaryTest
    {
        public static readonly string _monthJanuary = "1 : January";
        public static readonly string _monthFebruary = "2 : February";
        public static readonly string _monthMarch = "3 : March";
        public static readonly string _monthApril = "4 : April";
        public static readonly string _monthJanuaryStringJoin = "[1, January]";

        StringWriter _stringWrite = new StringWriter();

        public DictionaryTest()
        {
            Console.SetOut(_stringWrite);
        }

        static Dictionary<int, string> _months = new Dictionary<int, string>
        {
            {1,"January" },
            {2,"February" },
            {3,"March" },
            {4,"April" }
         };

        [TestMethod]
        public void WhenDictionaryUsesForEach_ThenOutputsReqdResults()
        {
            Program.SubDictionaryUsingForEach(_months);
            
            var outputLines = _stringWrite.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            Assert.AreEqual(_monthJanuary, outputLines[0]);
            Assert.AreEqual(_monthFebruary, outputLines[1]);
            Assert.AreEqual(_monthMarch, outputLines[2]);
            Assert.AreEqual(_monthApril, outputLines[3]);
        }

        [TestMethod]
        public void WhenDictionaryUsesKeyValuePair_ThenOutputsReqdResults()
        {
            Program.SubDictionaryKeyValuePair(_months);
            
            var outputLines = _stringWrite.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            Assert.AreEqual(_monthJanuary, outputLines[0]);
            Assert.AreEqual(_monthFebruary, outputLines[1]);
            Assert.AreEqual(_monthMarch, outputLines[2]);
            Assert.AreEqual(_monthApril, outputLines[3]);
        }

        [TestMethod]
        public void WhenDictionaryUsesForLoop_ThenOutputsReqdResults()
        {
            Program.SubDictionaryForLoop(_months);
            
            var outputLines = _stringWrite.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            Assert.AreEqual(_monthJanuary, outputLines[0]);
            Assert.AreEqual(_monthFebruary, outputLines[1]);
            Assert.AreEqual(_monthMarch, outputLines[2]);
            Assert.AreEqual(_monthApril, outputLines[3]);
        }

        [TestMethod]
        public void WhenDictionaryUsesParallelEnumerable_ThenOutputsReqdResults()
        {
            Program.SubDictionaryParallelEnumerable(_months);
            
            var resultlines = _stringWrite.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            Assert.AreEqual(_monthJanuary, resultlines[0]);
            Assert.AreEqual(_monthFebruary, resultlines[1]);
            Assert.AreEqual(_monthMarch, resultlines[2]);
            Assert.AreEqual(_monthApril, resultlines[3]);
        }

        [TestMethod]
        public void WhenDictionaryUsesStringJoin_ThenOutputsReqdResults()
        {
            Program.SubDictionaryStringJoin(_months);
            
            var outputLines = _stringWrite.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            Assert.AreEqual(_monthJanuaryStringJoin, outputLines[0]);
        }
    }
}