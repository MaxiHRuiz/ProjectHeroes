using Domain.Place;

namespace Heroes.Domain.Place
{
    public abstract class DecoratorBuilder
    {
        protected DecoratorBuilder decorator;

        public void DecorateBuilder(DecoratorBuilder decorator)
        {
            this.decorator = decorator;
        }

        public DecoratorBuilder GetDecorator()
        {
            return this.decorator;
        }

        public abstract ISector BuildDecorator();
    }
}
