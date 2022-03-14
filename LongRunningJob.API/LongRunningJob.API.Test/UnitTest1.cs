using LongRunningJob.API.Controllers;
using NUnit.Framework;

namespace LongRunningJob.API.Test
{
    /// <summary>
    /// You can run unit-test to exercise calling your long-running job.
    /// </summary>
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void JobRequest_Test()
        {
            // arrange
            JobRequest request = new JobRequest
            {
                JobId = "123",
                Settings = "my-settings"
            };
            JobsController controller = new JobsController();

            // act
            controller.RequestJob(request);

            // assert
            Assert.Pass();
        }
    }
}