﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KSU.Visio.Lib;
using System.Drawing;

namespace KSU.Visio.UT
{
    [TestClass]
    public class UTLost_message
    {
        [TestMethod]
        public void UTPos_hit()
        {
            Lost_message RO = new Lost_message();
            UTDraw(RO);
            Point p = new Point(5, 3);
            bool actual = RO.Hit_testing( p);
            bool expected = true;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void UTNeg_hit()
        {
            Lost_message RO = new Lost_message();
            UTDraw(RO);
            Point p = new Point(20, 20);
            bool actual = RO.Hit_testing( p);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        public void UTDraw(Lost_message RO)
        {
            ////RO.LeftTop = new Point(7, 8);
            ////RO.RightBottom = new Point(5, 2);
            //Graphics gr = new Graphics();

        }
        [TestMethod]
        public void UTShift()
        {
            Lost_message RO = new Lost_message();
            UTDraw(RO);
            Point p = new Point(10, 10);
            Point p1 = new Point(5, 8);
            RO.Hit_testing( p);
            RO.Shift(p1);
            if (p1.Equals(RO.LeftTop))
                Assert.AreEqual(p1, RO.LeftTop);
            else
                Assert.AreEqual(p1, RO.RightBottom);


        }

        [TestMethod]
        public void UTShift_Hit_pos()
        {
            Lost_message RO = new Lost_message();
            UTDraw(RO);
            Point p = new Point(10, 10);
            RO.Shift(p);
            Point p1 = new Point(11, 11);
            bool actual = RO.Hit_testing( p1);
            bool expected = true;
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void UTShift_Hit_neg()
        {
            Lost_message RO = new Lost_message();
            UTDraw(RO);
            Point p = new Point(10, 10);
            RO.Hit_testing( p);
            RO.Shift(p);
            Point p1 = new Point(30, 357);
            bool actual = RO.Hit_testing( p1);
            bool expected = false;
            Assert.AreEqual(expected, actual);

        }


    }
}
