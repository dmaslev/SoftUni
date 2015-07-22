namespace WinterIsComing.Core
{
    using System;
    using Contracts;
    using Models;
    using WinterIsComing.Models.Units;

    public static class UnitFactory
    {
        public static IUnit Create(UnitType type, string name, int x, int y)
        {
            switch (type)
            {
                case UnitType.Warrior: return new Warrior(type, name, x, y); 
                case UnitType.Mage: return new Mage(type, name, x, y); 
                case UnitType.IceGiant: return new IceGiant(type, name, x, y);


                // TODO: Implement units
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
