using System.Text.Json.Serialization;

namespace LongRunningJob.API
{
    /// <summary>
    ///     This is a basic request object that contains all required inputs
    ///     for your long-running job.
    ///     You may send a file ot list-files as array-string. 
    ///     Then, once the string-data is received in API, you can run base64-decode
    /// </summary>
    public class JobRequest
    {
        /// <summary>
        ///     sample settings for the job
        /// </summary>
        public string Settings { get; set; }


        /// <summary>
        ///     sample id
        /// </summary>
        public string JobId { get; set; }

        /// <summary>
        ///     sample input to job where "data" can potentially 
        ///     be a list of "file contents as string"
        /// </summary>
        /// <remarks>
        ///     base64 data would be extracted from string in the list
        /// </remarks>
        public List<string> Data { get; set; }
    }
}
