namespace GamePrototype.Items.EconomicItems.EconomicItems1;
{

    public sealed Gold : EconomicItem
    {
       public override bool Stackable => true;

       public Gold() : base(GameConstants.Gold)
       {
           
       }
    }
}