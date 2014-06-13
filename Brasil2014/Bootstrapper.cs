namespace Brasil2014
{
    using Brasil2014.Data;
    using Brasil2014.Impl;
    using Nancy;
    using Nancy.TinyIoc;

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        // The bootstrapper enables you to reconfigure the composition of the framework,
        // by overriding the various methods and properties.
        // For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper

        protected override void ConfigureRequestContainer(TinyIoCContainer container, NancyContext context)
        {
            base.ConfigureRequestContainer(container, context);

            container.Register<ITeamRepository, TeamRepository>();
            container.Register<IMatchRepository, MatchRepository>();
        }
    }
}