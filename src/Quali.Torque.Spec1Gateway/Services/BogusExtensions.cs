using Bogus;
namespace Quali.Torque.Spec1Gateway.Services;

public static class BogusExtensions
{
    public static WebApplication UseFaker(this WebApplication app)
    {
        Randomizer.Seed = new Random(8675309);

        return app;
    }
}
