using GigHub.Controllers.Api;
using GigHub.Core;
using GigHub.Tests.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GigHub.Tests.Controllers.Api
{

    [TestClass]
    public class GigControllerTests
    {
        private GigsController _controller;

        public GigControllerTests()
        {



            var mockUoW = new Mock<IUnitOfWork>();
            _controller = new GigsController(mockUoW.Object);
            _controller.MockCurrentUser("1", "user1@domain.com");
        }


    }
}
