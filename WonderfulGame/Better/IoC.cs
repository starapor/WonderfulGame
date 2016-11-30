using Autofac;
using WonderfulGame.GrowsTo;
using WonderfulGame.Starts;

namespace WonderfulGame.Better
{
    class IoC
    {
        public void WireUp()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Dice>().Named<IDice>("real");

            builder.RegisterDecorator<IDice>((c, inner) => new SkipEverySecondRoll(inner),
                fromKey: "implementor", toKey: "decorator1");

            builder.RegisterDecorator<IDice>((c, inner) => new DiceLogger(inner, new Logger()),
                fromKey: "decorator1", toKey: null);

        }
    }
}
