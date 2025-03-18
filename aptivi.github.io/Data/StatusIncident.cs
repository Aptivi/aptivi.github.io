namespace aptivi.github.io.Data
{
    public class StatusIncident
    {
        public string IncidentName { get; set; }
        public string IncidentDescription { get; set; }
        public StatusIncidentTimeline[] IncidentTimeline { get; set; }
    }
}
