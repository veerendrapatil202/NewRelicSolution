using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewRelic;
using System;
using System.IO;
using System.Linq;

namespace NewRelicTest
{
    [TestClass]
    public class FindTest
    {
        [TestMethod]
        public void FindMostCommonSequencesSuccessTest()
        {
            var fileName = "texts\\moby-dick.txt";
            var fileNameWithPath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            Find find = new Find();
            var top3 = find.FindMostCommonSequences(fileNameWithPath, 3);
            Assert.IsNotNull(top3);
            var wordList = top3.ToList();
            Assert.AreEqual(3, wordList.Count);
            Assert.AreEqual("the sperm whale", wordList[0].Key);
            Assert.AreEqual(86, wordList[0].Value);
            Assert.AreEqual("of the whale", wordList[1].Key);
            Assert.AreEqual(78, wordList[1].Value);
            Assert.AreEqual("the white whale", wordList[2].Key);
            Assert.AreEqual(71, wordList[2].Value);
        }

        [TestMethod]
        public void FindMostCommonSequencesNegativeCountTest()
        {
            var fileName = "texts\\moby-dick.txt";
            var fileNameWithPath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            Find find = new Find();
            var wordSequences = find.FindMostCommonSequences(fileNameWithPath, -10);
            Assert.IsNotNull(wordSequences);
            Assert.AreEqual(0, wordSequences.Count());
        }

        [TestMethod]
        public void FindMostCommonSequencesInvalidFileTest()
        {
            var fileName = "xyz.txt";
            Find find = new Find();
            var wordSequences = find.FindMostCommonSequences(fileName, 10);
            Assert.IsNotNull(wordSequences);
            Assert.AreEqual(0, wordSequences.Count());
        }        

        [TestMethod]
        public void FindMostCommonSequencesNullTest()
        {
            string? fileName = null;
            Find find = new Find();
            var wordSequences = find.FindMostCommonSequences(fileName, 10);
            Assert.IsNotNull(wordSequences);
            Assert.AreEqual(0, wordSequences.Count());       
        }
    }
}