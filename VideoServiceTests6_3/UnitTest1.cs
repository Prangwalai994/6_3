﻿using System;
using Moq;
using NUnit.Framework;
using Testing6_3.Mocking;

namespace VideoServiceTests6_3
{
    [TestFixture]
    public class VideoServiceTests
    {
        private Mock<IFileReader> _fileReader;
        private Mock<IVideoRepository> _repository;
        [SetUp]
        public void Setup()
        {
            _fileReader = new Mock<IFileReader>();
            _repository = new Mock<IVideoRepository>();
            _videoService = new VideoService(_fileReader.Object);
        }
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {

            _fileReader.Setup(fr => fr.Read("Video.txt")).Returns("");

            var result = _videoservice.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
        [Test]
        public void GetUnprocessedVideosCsv_NoUnprocesedVideos_ReturnAnEmptyString()
        {

        }
    }
}
