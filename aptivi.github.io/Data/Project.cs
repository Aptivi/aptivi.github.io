namespace aptivi.github.io.Data
{
    public class Project
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ProjectSlug { get; set; }
        public string ProjectGLSlug { get; set; }
        public string ProjectGBSlug { get; set; }
        public string[] NuGetPackages { get; set; }
        public string ProjectImageName { get; set; }
        public string ProjectOrg { get; set; }
        public bool ProjectHasLanding { get; set; }
        public ProjectSupportPolicy[] ProjectSupportPolicy { get; set; }
    }
}
