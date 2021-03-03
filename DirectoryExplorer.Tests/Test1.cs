﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicFilesLib;
using Moq;

namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class Test1
    {
        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";
        private readonly string _file3 = "file3.txt";
        Mock<IDirectoryExplorer> _directorExplorer;

        [OneTimeSetUp]
        public void Init()
        {
            _directorExplorer = new Mock<IDirectoryExplorer>();

            _directorExplorer
                .Setup(x => x.GetFiles(It.IsAny<string>()))
                .Returns((string x) =>
                    new List<string>
                    {
                        _file1,
                        _file2
                    });
        }

        [Test]
        [TestCase("souvik")]
        [TestCase("C:\\Life")]
        [TestCase("D:\\Path2")]
        public void GetFilesTest(string input)
        {
            ICollection<string> files = _directorExplorer.Object.GetFiles(input);

            Assert.IsNotNull(files);
            Assert.IsTrue(files.Count == 2);
            Assert.IsTrue(files.Contains(_file2));

        }
    }
}
