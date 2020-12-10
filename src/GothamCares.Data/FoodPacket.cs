using GothamCares.Common;

namespace GothamCares.Data
{
    public class FoodPacket
    {
        /// <summary>
        /// Gets or sets the food packet Id.
        /// </summary>
        public int Id { get; set; }

        
        public PacketType FoodPacketType { get; set; }
    }
}