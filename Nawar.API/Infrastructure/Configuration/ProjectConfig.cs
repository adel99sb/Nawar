namespace Nawar.API.Infrastructure.Configuration
{
    public class ProjectConfig
    {
        private static readonly Lazy<ProjectConfig> _instance =
            new Lazy<ProjectConfig>(() => new ProjectConfig());

        public static ProjectConfig Instance => _instance.Value;

        public JwtSettings JwtSettings { get; private set; }
        public SmtpSettings SmtpSettings { get; private set; }
        public string ConnectionString { get; private set; }

        private ProjectConfig()
        {
            // Load configuration settings from appsettings.json or environment variables
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            IConfiguration configuration = configBuilder.Build();

            JwtSettings = configuration.GetSection("JwtSettings").Get<JwtSettings>();
            SmtpSettings = configuration.GetSection("SmtpSettings").Get<SmtpSettings>();
            ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }

    }

}
