using MusicLibrary.Controllers;
using MusicLibrary.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;
using NSubstitute;
using MusicLibrary.Models;

namespace MusicLibrary.Tests
{
    public class AlbumControllerTests
    {
        AlbumController underTest;
        private IAlbumRepository repo;

        public AlbumControllerTests()
        {
            repo = Substitute.For<IAlbumRepository>();
            underTest = new AlbumController(repo);
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
        public void Details_Model_Is_Expected_Model()
        {
            var expectedId = 2;
            var expectedModel = new Album();
            repo.GetByID(expectedId).Returns(expectedModel);

            var result = underTest.Details(expectedId);
            var model = (Album)result.Model;

            Assert.Equal(expectedModel, model);
        }

    }
}
