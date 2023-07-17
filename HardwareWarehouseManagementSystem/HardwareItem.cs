using System;
using System.Collections.Generic;
using System.Text;
using WarehouseManagementSystemAPI;

namespace HardwareWarehouseManagementSystem
{
    public abstract class HardwareItem : IEntityPrimaryProperties, IEntityAdditionalProperties
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public decimal UnitValue { get; set; }
    }

    public interface IDrill
    { 
        string DrillBrandName { get; set; }
    }
    public interface ILadder
    {
        string LadderBrandName { get; set; }
    }
    public interface IPaintbrush
    {
        string PainbrushBrandName { get; set; }
    }
    public interface IHammer
    {
        string HammerBrandName { get; set; }
    }
    
    public class Drill : HardwareItem, IDrill
    {
        public string DrillBrandName { get; set; }
    }

    public class Ladder : HardwareItem, ILadder
    {
        public string LadderBrandName { get; set; }
    }

    public class Paintbrush : HardwareItem, IPaintbrush
    {
        public string PainbrushBrandName { get; set; }
    }

    public class Hammer : HardwareItem, IHammer
    {
        public string HammerBrandName { get; set; }
    }
}
