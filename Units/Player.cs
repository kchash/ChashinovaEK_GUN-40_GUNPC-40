
using GamePrototype.Items.EconomicItems;
using GamePrototype.Items.EquipItems;
using GamePrototype.Utils;
using System.Text;
using GamePrototype.Items.EconomicItems.EconomicItems1;

namespace GamePrototype.Units;
{
    private readonly Dictionary<EquipSlot, EquipItem> _equippedItems = new();
    
    public Player(string name, uint health, uint maxHealth, uint baseDamage) : base(name, health, maxHealth, baseDamage)
    {
    
    }
    public override uint GetUnitDamage()
    {
        if (_equipment.TryGetValue(EquipSlot))
    }
    
}