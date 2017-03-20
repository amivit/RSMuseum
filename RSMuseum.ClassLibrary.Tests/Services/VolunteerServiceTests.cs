﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using RSMuseum.ClassLibrary.Entities;
using RSMuseum.ClassLibrary.Repositories;
using RSMuseum.ClassLibrary.Services;
using Xunit;

namespace RSMuseum.ClassLibrary.Tests.Services
{
    public class VolunteerServiceTests
    {
        [Fact]
        public void GetAllVolunteersMethodWorks()
        {
            // Arrange
            var fakeVolunteer = new Volunteer { Id = 0 };
            var expectedData = new List<Volunteer>(new Volunteer[] { fakeVolunteer });

            var fakeVRepo = new Mock<IVolunteerRepository>();
            fakeVRepo.Setup(m => m.GetAllVolunteers()).Returns(expectedData);

            // Act
            var volunteerService = new VolunteerService(fakeVRepo.Object);
            var result = volunteerService.GetAllVolunteers();

            // Assert
            Assert.Equal(expectedData, result);
        }
    }
}