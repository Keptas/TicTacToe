using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TicTacToe;
namespace TicTacToe.Test
{
    [TestClass]
    public class xoTest
    {
        [TestMethod]
        public void TestCheckWin123()
        {
            bool actual = false;
            bool expected = true;
            List<int> Combo = new List<int>();
            Combo.Add(1);
            Combo.Add(2);
            Combo.Add(3);
            Game game = new Game();
            actual = game.checkForWin(Combo);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestCheckWin159()
        {
            bool actual = false;
            bool expected = true;
            List<int> Combo = new List<int>();
            Combo.Add(1);
            Combo.Add(5);
            Combo.Add(9);
            Game game = new Game();
            actual = game.checkForWin(Combo);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestCheckWin789()
        {
            bool actual = false;
            bool expected = true;
            List<int> Combo = new List<int>();
            Combo.Add(7);
            Combo.Add(8);
            Combo.Add(9);
            Game game = new Game();
            actual = game.checkForWin(Combo);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestCheckWin21_22_23()
        {
            bool actual = false;
            bool expected = true;
            List<int> Combo = new List<int>();
            Combo.Add(21);
            Combo.Add(22);
            Combo.Add(23);
            Game game = new Game();
            actual = game.checkForWin(Combo);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestSelectGame3x3()
        {
            Game game = new Game();
            string actual = "";
            string expected = "Game3x3";      
            actual = game.selectGame("3x3");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestSelectGame4x4()
        {
            Game game = new Game();
            string actual = "";
            string expected = "Game4x4";
            actual = game.selectGame("4x4");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestSelectGame5x5()
        {
            Game game = new Game();
            string actual = "";
            string expected = "Game5x5";
            actual = game.selectGame("5x5");
            Assert.AreEqual(expected, actual);

        }
    }
}
