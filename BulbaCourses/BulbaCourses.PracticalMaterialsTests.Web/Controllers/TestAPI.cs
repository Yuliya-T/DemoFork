﻿using BulbaCourses.PracticalMaterialsTests.Logic.Models.Tests;
using BulbaCourses.PracticalMaterialsTests.Logic.Services.Tests.Interfaсe;
using BulbaCourses.PracticalMaterialsTests.Logic.Services.Tests.Realization;
using Ninject;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace BulbaCourses.PracticalMaterialsTests.Web.Controllers
{    
    public class TestAPIController : ApiController
    {
        private readonly IService_Test _service_Test;

        public TestAPIController()
        {
            IKernel kernel = new StandardKernel();

            kernel.Bind<IService_Test>().To<Service_Test>();

            _service_Test = kernel.Get<IService_Test>();
        }

        [SwaggerResponse(HttpStatusCode.BadRequest, "Invalid parametr format")]
        [SwaggerResponse(HttpStatusCode.NotFound, "Book doesn't existing")]
        [SwaggerResponse(HttpStatusCode.OK, "Test found", typeof(string))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "Something Wrong")]
        public IHttpActionResult TesatMethod()
        {
            MTest_MainInfo Test_MainInfo = _service_Test.GetTestById(1);            

            return Ok(Test_MainInfo.Name);
        }
    }
}