namespace LegacyCodeKoans.StaticMethod
{
    public class Service
    {
        private readonly SomeSideEffect someSideEffect;

        public Service(SomeSideEffect someSideEffect)
        {
            this.someSideEffect = someSideEffect;
        }

        public void DoSomething()
        {
            someSideEffect.SomeSideEffect();
        }
    }
}