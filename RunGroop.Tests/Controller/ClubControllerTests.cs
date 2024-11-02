using RunGroop.Interfaces;
using System;
using FakeItEasy;
using RunGroop.Services;
using RunGroop.Models;
using Microsoft.AspNetCore.Http;
using RunGroop.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace RunGroop.Tests.Controller;

public class ClubControllerTests
{
    private ClubController clubController;
    private IClubRepository clubRepo;
    private IPhotoService photoService;
    private IHttpContextAccessor contextAccessor;
    public ClubControllerTests()
    {
        //Dependancies
        clubRepo = A.Fake<IClubRepository>();
        photoService = A.Fake<IPhotoService>();
        contextAccessor = A.Fake<HttpContextAccessor>();

        //SUT
        clubController = new ClubController(clubRepo, photoService, contextAccessor);

    }

    [Fact]
    public void ClubController_Index_ReturnsSuccess()
    {
        //Arrange - What do i need to bring in?
        var clubs = A.Fake<IEnumerable<Club>>();
        A.CallTo(() => clubRepo.GetAll()).Returns(clubs);
        //Act
        var result = clubController.Index();
        //Assert - Object check actions

        result.Should().BeOfType<Task<IActionResult>>();

    }

    [Fact]
    public void ClubController_Detail_ReturnsSuccess()
    {
        //Arrange
        var id = 1;
        var club = A.Fake<Club>();
        A.CallTo(() => clubRepo.GetByIdAsync(id)).Returns(club);

        //Act
        var result = clubController.Detail(id);

        //Assert
        result.Should().BeOfType<Task<IActionResult>>();
    }
}
