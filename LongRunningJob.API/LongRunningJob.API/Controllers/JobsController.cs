using Microsoft.AspNetCore.Mvc;

namespace LongRunningJob.API.Controllers
{
    /// <summary>
    ///  API Controller template to: 1) submit a request for a long-running-job; 2) poll the progress or status of the job
    /// </summary>
    [ApiController]
    [Route("jobs")]
    public class JobsController : ControllerBase
    {

        /// <summary>
        ///     Post a request to a long-running job.
        ///     Submit all data required for long-running job 
        ///     as encapsulated into one object.
        /// </summary>
        /// <param name="requestBody">
        ///     The data required to run a long-running job.
        ///     It could contain list-of-file-contents, or, could be 
        ///     as simple as job IDs, or URIs to point the API function
        ///     to required resources to run the job
        /// </param>
        /// <returns>
        ///     Return some sort of ID in order to the client
        ///     to periodically poll the status of the job.
        /// </returns>
        [HttpPost("request")]
        public Guid RequestJob([FromBody] JobRequest requestBody)
        {
            return new Guid();
        }


        /// <summary>
        ///     Use this end-point to inquire API 
        ///     "what's the status of my long-running job?"
        /// </summary>
        /// <param name="id">
        ///     Some identifier to check status for
        /// </param>
        /// <returns>
        ///     It can return a percentage of a job completed.
        ///     Or, you can also return strings or complex objects return-types too.
        /// </returns>
        [HttpGet("{id}/status-check")]
        public double StatusCheck(Guid id)
        {
            return 0.8d;
        }
    }


}
