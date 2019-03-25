using MusicLibrary.Controllers;
using MusicLibrary.Models;
using MusicLibrary.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System.Collections.Generic;
using Xunit;

namespace MusicLibrary.Tests
{
    public class SongControllerTests
    {
        SongController underTest;
        private ISongRepository repo;

        public SongControllerTests()
        {
            repo = Substitute.For<ISongRepository>();
            underTest = new SongController(repo);
        }

        [Fact]
        public void Index_Returns_A_View_Result()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Has_A_View()
        {
            var result = underTest.Details(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void CanAddSong()
        {
            
            var expectedId = 2;
            var expectedModel = new Song();
            repo.GetByID(expectedId).Returns(expectedModel);

            var result = underTest.Details(expectedId);
            var model = (Song)result.Model;

            Assert.Equal(expectedModel, model);

        }

        [Fact]
        public void Index_Model_Is_Expected_Model()
        {
            var expectedModel = new List<Song>();
            repo.GetAll().Returns(expectedModel);

            var result = underTest.Index();
            var model = (IEnumerable<Song>)result.Model;
            Assert.Equal(expectedModel, model);
        }
        [Fact]
        public void Details_Model_Is_Expected_Model()
        {
            var expectedId = 2;
            var expectedModel = new Song();
            repo.GetByID(expectedId).Returns(expectedModel);

            var result = underTest.Details(expectedId);
            var model = (Song)result.Model;

            Assert.Equal(expectedModel, model);
        }
    }
}
