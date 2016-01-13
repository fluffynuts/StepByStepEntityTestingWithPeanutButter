using PeanutButter.RandomGenerators;
using SomeProjectUsingEntity.Models;

namespace SomeProjectUsingEntity.Tests.Models
{
    public class SomeEntityBuilder: GenericBuilder<SomeEntityBuilder,SomeEntity>
    {
        public override SomeEntityBuilder WithRandomProps()
        {
            // Name property is required, so we ensure that a random
            // entity has a name (random builder could set the name to
            //  an empty string!)
            return base.WithRandomProps()
                .WithName(RandomValueGen.GetRandomString(1, 10));
        }

        public SomeEntityBuilder WithName(string name)
        {
            return WithProp(o => o.Name = name);
        }
    }
}