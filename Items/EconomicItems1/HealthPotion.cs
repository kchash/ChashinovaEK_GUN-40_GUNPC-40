namespace GamePrototype.Items.EconomicItems.EconomicItems1;
{
    public sealed class HealthPotion : EconomicItem
    {
        public uint HealthRestore = 7;
        public override bool Stackable = false;

        public HealthPotion(string name) : base(name)
        {
            
        }
    }
}