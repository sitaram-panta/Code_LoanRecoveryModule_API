using LoanRecovery.Controllers;
using LoanRecovery.Data;
using LoanRecovery.Models;
using LoanRecovery.Services;
using LoanRecovery.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LoanRecovery.Tests.Controllers
{
    public class DefaulterRelatedEnpointsControllerTest
    {
        [Fact]
        public void DefaultersListView_ReturnsOkObjectResult_WithData()
        {
            // Arrange  
            var mockRepo = new Mock<DefaulterPageServiceRepo>();

            // Mock data that you expect from the service
            var mockData = new List<DefaultersViewModel>().AsQueryable();

            // Set up the mock behavior
            mockRepo.Setup(repo => repo.GetDefaulters()).Returns(mockData);

            // Act
            var controller = new DefaultersRelatedEndpointsController(mockRepo.Object);
            var result = controller.DefaultersListView();

            // Assertions
            Assert.NotNull(result);

            // Ensure the HTTP status code is 200 (OK)
            var okObjectResult = Assert.IsType<OkObjectResult>(result.Result);
            Assert.Equal(200, okObjectResult.StatusCode);

            // Check if the content of the response is as expected
            Assert.NotNull(okObjectResult.Value);

            // Ensure the value is of type IQueryable<DefaultersViewModel>
            Assert.IsAssignableFrom<IQueryable<DefaultersViewModel>>(okObjectResult.Value);

            var data = (IQueryable<DefaultersViewModel>)okObjectResult.Value;

            // Ensure the count of returned data matches the expected count
            Assert.Equal(mockData.Count(), data.Count());
        }

        //    [Fact]
        //    public void GetDefaulters_ThrowsException_WhenNoDefaultersFound()
        //    {
        //        // Arrange
        //        var defaulterData = new List<Defaulter>().AsQueryable();
        //        var dbContextMock = new Mock<AppDbContext>(); 
        //        var defaulterDbSetMock = new Mock<DbSet<Defaulter>>();     //to ensure dbset is behaving as iQueryable 
        //        defaulterDbSetMock.As<IQueryable<Defaulter>>().Setup(m => m.Provider).Returns(defaulterData.Provider);
        //        defaulterDbSetMock.As<IQueryable<Defaulter>>().Setup(m => m.Expression).Returns(defaulterData.Expression);
        //        defaulterDbSetMock.As<IQueryable<Defaulter>>().Setup(m => m.ElementType).Returns(defaulterData.ElementType);
        //        defaulterDbSetMock.As<IQueryable<Defaulter>>().Setup(m => m.GetEnumerator()).Returns(defaulterData.GetEnumerator());

        //        dbContextMock.Setup(db => db.Defaulters).Returns(defaulterDbSetMock.Object);
        //        var repo = new DefaulterPageServiceRepo(dbContextMock.Object);

        //        // Act and Assert
        //        var ex = Assert.Throws<Exception>(() => repo.GetDefaulters());
        //        Assert.Equal("No Defaulters found", ex.Message);
        //    }
    }
}

