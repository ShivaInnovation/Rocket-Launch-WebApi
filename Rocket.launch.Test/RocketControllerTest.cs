using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rocket.Launch.Business.Interfaces;
using Rhino.Mocks;
using Rocket.Launch.Repository.Interfaces;
using Rocket.Launch.WebApi.Controllers;
using System.Net.Http;
using System.Net;

namespace Rocket.launch.Test
{
    [TestClass]
    public class RocketControllerTest
    {
        [TestMethod]
        public void MustReturnRocketForGetUsingAValidId()
        {
            //Arrange
            int id = 1002;
            var rockets = new Rocket.Launch.DbEntities.Entities.Rocket()
            {
                Satellites = { },
                RocketNo = 23,
                RocketName = "dfdasf",
                Path = "AIR",
                Destination = "HHH",
                Id = 1002,
                CreatedTime = Convert.ToDateTime("2019-06-23T03:37:32.243"),
                LastUpdatedTime = Convert.ToDateTime("2019-06-23T03:37:32.243"),
                CreatedBy = 1,
                LastUpdatedBy = 1
            };

            
            //IRepository<Rocket.Launch.DbEntities.Entities.Rocket> repository = MockRepository.GenerateMock<IRepository<Rocket.Launch.DbEntities.Entities.Rocket>>();
            //repository.Stub(x => x.Get(id)).Return(rockets);
            //IRocketManager manager = (IRocketManager)repository;

            MockRepository mocks = new MockRepository();
            IRocketManager viewMock = mocks.Stub<IRocketManager>();


            var controller = new RocketController(viewMock);
            controller.EnsureNotNull();

            //Act
            HttpResponseMessage respose = controller.Get(id);

            //Assert
            Assert.IsNotNull(respose);
            Assert.IsNotNull(respose.Content);
            Assert.IsInstanceOfType(respose.Content, typeof(ObjectContent<Rocket.Launch.DbEntities.Entities.Rocket>));
            Assert.AreEqual(HttpStatusCode.OK, respose.StatusCode);

            var content = (respose.Content as ObjectContent<Rocket.Launch.DbEntities.Entities.Rocket>);
            var result = content.Value as Rocket.Launch.DbEntities.Entities.Rocket;

            Assert.AreEqual(rockets.Id, result.Id);
            Assert.AreEqual(rockets.RocketName, result.RocketName);
            Assert.AreEqual(rockets.Destination, result.Destination);

        }
    }
}
