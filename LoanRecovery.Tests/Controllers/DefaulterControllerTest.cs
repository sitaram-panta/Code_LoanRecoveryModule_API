    using LoanRecovery.Controllers;
using LoanRecovery.Interfaces;
using LoanRecovery.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace LoanRecovery.Tests.Controllers
{
    public class DefaulterControllerTest
    {
        [Fact]
        public void GetList_ReturnsOkObjectResult()
        {
            // Arrange
            var mockRepo = new Mock<IDefaulter>();
            mockRepo.Setup(x => x.GetList())
                .Returns(new List<Defaulter>().AsQueryable()); // Return IQueryable directly

            var controller = new DefaulterController(mockRepo.Object);

            // Act
            var result = controller.GetList();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var items = Assert.IsAssignableFrom<IEnumerable<Defaulter>>(okResult.Value);
            Assert.Empty(items);
        }


        [Fact]
        public async Task GetDetails_ReturnsOkObjectResult_ForValidId()
        {
            // Arrange
            var validId = 1;
            var mockRepo = new Mock<IDefaulter>();
            mockRepo.Setup(repo => repo.GetDetails(validId))
                .ReturnsAsync(new Defaulter { Id = validId, /* other properties */ });

            var controller = new DefaulterController(mockRepo.Object);

            // Act
            var result = await controller.GetDetails(validId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var item = Assert.IsAssignableFrom<Defaulter>(okResult.Value);
            Assert.Equal(validId, item.Id);
        }

        [Fact]
        public async Task GetDetails_ReturnsNotFoundResult_ForInvalidId()
        {
            // Arrange
            var invalidId = 999;                  // <= Replace with an invalid ID
            var mockRepo = new Mock<IDefaulter>();
            mockRepo.Setup(repo => repo.GetDetails(invalidId))
                .ReturnsAsync((int id) => null);  //<= Simulate a null result for an invalid ID

            var controller = new DefaulterController(mockRepo.Object);

            // Act
            var result = await controller.GetDetails(invalidId);

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public async Task Create_ReturnsOkObjectResult_ForValidData()
        {
            // Arrange
            var validData = new Defaulter(); //{ /* Set valid data properties */ };
            var mockRepo = new Mock<IDefaulter>();
            mockRepo.Setup(repo => repo.Create(validData))
                .ReturnsAsync(validData);  // Simulate successful creation

            var controller = new DefaulterController(mockRepo.Object);

            // Act
            var result = await controller.Create(validData);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var createdData = Assert.IsAssignableFrom<Defaulter>(okResult.Value);
            Assert.Equal(validData.Id, createdData.Id);  // Adjust for your identifier property
        }

        [Fact]
        public async Task Update_ReturnsOkObjectResult_ForValidData()
        {
            // Arrange
            var validId = 1;
            var updatedData = new Defaulter { Id = validId /* Set updated data properties */ };
            var mockRepo = new Mock<IDefaulter>();
            mockRepo.Setup(repo => repo.Update(validId, updatedData))
                .ReturnsAsync(updatedData);  // Simulate successful update

            var controller = new DefaulterController(mockRepo.Object);

            // Act
            var result = await controller.Update(validId, updatedData);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnedData = Assert.IsAssignableFrom<Defaulter>(okResult.Value);
            Assert.Equal(validId, returnedData.Id);  // Adjust for your identifier property
        }

        [Fact]
        public async Task Update_ReturnsNotFoundResult_ForInvalidId()
        {
            // Arrange
            var invalidId = 999;  // <= Replace with an invalid ID
            var mockRepo = new Mock<IDefaulter>();
            mockRepo.Setup(x => x.Update(It.IsAny<int>(), It.IsAny<Defaulter>()))
            .ReturnsAsync((int id, Defaulter data) => null);
                
            var controller = new DefaulterController(mockRepo.Object);

            // Act
            var result = await controller.Update(invalidId, new Defaulter());
      
            // Assert
            Assert.IsType<NotFoundObjectResult>(result.Result);

        }


        [Fact]
        public async Task Delete_ReturnsOkObjectResult_ForValidId()
        {
            // Arrange
            var validId = 1;
            var deletedData = new Defaulter { Id = validId }; /* Set data properties if needed */
            var mockRepo = new Mock<IDefaulter>();
            mockRepo.Setup(repo => repo.Delete(validId))
                .ReturnsAsync(deletedData);  // Simulate successful deletion

            var controller = new DefaulterController(mockRepo.Object);

            // Act
            var result = await controller.Delete(validId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnedData = Assert.IsAssignableFrom<Defaulter>(okResult.Value);
            Assert.Equal(validId, returnedData.Id);  // Adjust for your identifier property
        }

        [Fact]
        public async Task Delete_ReturnsNotFoundResult_ForInvalidId()
        {
            // Arrange
            var invalidId = 999;  // Replace with an invalid ID
            var mockRepo = new Mock<IDefaulter>();
            mockRepo.Setup(repo => repo.Delete(invalidId))
                .ReturnsAsync((int id) => null);  // Simulate null result for an invalid ID during delete

            var controller = new DefaulterController(mockRepo.Object);

            // Act
            var result = await controller.Delete(invalidId);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result.Result);
        }
    }
}
