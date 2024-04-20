namespace SofaSoGood.Model
{
    public class CurrentlyRentedFurnitureInformation
    {
        public int FurnitureID { get; set; }
        public string FurnitureName { get; set; }
        public string FurnitureCategory { get; set; }
        public string FurnitureStyle { get; set; }
        public string Description { get; set; }
        public decimal RentalRatePerDay { get; set; }
        public int AmountRented { get; set; }
    }
}
