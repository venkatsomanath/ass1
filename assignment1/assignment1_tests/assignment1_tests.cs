using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment1;
using NUnit.Framework;                                 

namespace assignment1_tests
{
    [TestFixture]
    class CalcTests
    {
        [Test]
        public void Getrectanglelength_Input6_Returns6()
        {
            //Arrange
            int l = 4;
            int w = 5;
         
            rectangle testrectangle= new rectangle(l,w);
            //Act---
            double length = testrectangle.Getrectanglelength();
            //Assert
            Assert.AreEqual(length, l);
        }
        [Test]
        public void GetrectangleWidth_Input6_Returns6()
        {
            //Arrange
            int l = 4;
            int w = 6;

            rectangle testrectangle = new rectangle(l, w);
            //Act---
            double width = testrectangle.GetrectangleWidth();
            //Assert
            Assert.AreEqual(width, w);
        }
        [Test]
        public void Getrectanglearea_Input4andinput5_Returns20()
        {
            //Arrange
            int l = 4;
            int w = 5;
            int area = 20;

            rectangle testrectangle = new rectangle(l, w);
            //Act---
            double outputarea = testrectangle.GetrectangleArea();
            //Assert
            Assert.AreEqual(outputarea, area);
        }
        [Test]
        public void GetrectanglePerimeter_Input4andinput5_Returns18()
        {
            //Arrange
            int l = 4;
            int w = 5;
            int perimeter = 18;

            rectangle testrectangle = new rectangle(l, w);
            //Act---
            double outputperimeter = testrectangle.GetrectanglePerimeter();
            //Assert
            Assert.AreEqual(outputperimeter, perimeter);
        }
        [Test]
        public void Changerectanglelength_Input7_Returns7()
        {
            //Arrange
            int l = 7;
            int w = 5;
            int Length = 7;
            rectangle testrectangle = new rectangle(l, w);
            //Act---
            double changedLength = testrectangle.ChangerectangleLength(7);
            //Assert
            Assert.AreEqual(changedLength, Length);
        }
        [Test]
        public void ChangerectangleWidth_Input8_Returns8()
        {
            //Arrange
            int l = 7;
            int w = 5;
            int Width = 8;
            rectangle testrectangle = new rectangle(l, w);
            //Act---
            double changedWidth = testrectangle.ChangerectangleWidth(8);
            //Assert
            Assert.AreEqual(changedWidth, Width);
        }
    }
}
