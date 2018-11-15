using System.Collections.Generic;

namespace Platform.Client.Domain
{
    /**
     * The wrapper for "/v2/sources" response.
     */
    public class Sources : AbstractHasLinks 
    {
        private List<Source> SourceList { get; set; } = new List<Source>();
    }
}