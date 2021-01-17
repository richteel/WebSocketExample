namespace TeelSys.Settings
{
    public struct AssemblyDetails
    {
        public string Company { get; }

        public string Copyright { get; }

        public string Description { get; }

        public string Name { get; }

        public string Title { get; }

        public string Version { get; }

        public AssemblyDetails(string Company, string Copyright, string Description, string Name, string Title, string Version)
        {
            this.Company = Company;
            this.Copyright = Copyright;
            this.Description = Description;
            this.Name = Name;
            this.Title = Title;
            this.Version = Version;
        }
    }
}
