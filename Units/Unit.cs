using GamePrototype.Items.EconomicItems;

namespace GamePrototype.Units;
{
    public abstract class Unit
    {
        private const int INVENTORY_SIZE = 3;
        private uint _health;
        private uint _maxHealth;
        protected uint BaseDamage;
        protected inventory inventory;
        
        public string Name { get; private set; }

        public uint Health
        {
             get => _health;
             protected set  => _health = value;
        }
        
        public uint MaxHealth => _maxHealth;

        protected Unit(string name, uint health, uint maxHealth, uint baseDamage)
        {
            Name = name;
            _health = health;
            _maxHealth = maxHealth;
            BaseDamage = baseDamage;
            Inventory = new inventory(INVENTORY_SIZE);
        }
        
        public void ApplyDamage(uint amount)
        {
            _health -= CalculateAppliedDamage(damage);
            DamageReceiveHandler();
        }
        
        protected abstract uint CalculateAppliedDamage(uint damage);

        protected virtual void DamageReceiveHandler()
        {
        }
        public abstract uint GetUnitDamage();
        public abstract void HandleCombatComplete();

        public virtual void AddItemToInventory(Item item)
        {
            if (!inventory.TryAdd(item))
            {
                Console.WriteLine($"Inventory of {Name} is full.");
            }
        }
        
        public void AddItemFromUnitToInventory(Unit unit)
        {}
    }
}