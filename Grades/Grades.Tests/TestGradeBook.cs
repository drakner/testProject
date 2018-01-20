using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTest
    {
        [TestMethod]
        public void testGradebook()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(5);
            book.AddGrade(88);
            book.AddGrade(21);

            GradeStatistics stats = book.ComputeGradeStatistics();
            Assert.IsNotNull(stats);

            Assert.AreEqual(88, stats.HighestGrade);
            Trace.Write(stats.AverageGrade);
            
        }

        [TestMethod]
        public void testASD()
        {
            int i = 5;
            Console.WriteLine(i);
            Assert.AreEqual(5, i);
        }

        [TestMethod]
        public void testDD()
        {
            List<int> intList = new List<int>();
            intList.Add(5);
            intList.Add(6);


            foreach(int tASD in intList)
            {
                Trace.Write(tASD);
            }
            
            
        }
    }
}
