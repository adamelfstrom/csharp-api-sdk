using Newtonsoft.Json;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

namespace FortnoxAPILibrary.Entities
{
    /// <remarks/>
    [Entity(SingularName = "LockedPeriod")]
    public class LockedPeriod
    {
        /// <remarks/>
        [ReadOnly]
        [JsonProperty]
        public string EndDate { get; private set; }
    }
}
