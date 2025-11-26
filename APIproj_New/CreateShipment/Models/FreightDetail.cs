using System.Collections.Generic;

namespace CreateShipment.Models
{
	public class FreightDetail
	{
		public string SsccNumber { get; set; }
		public string CustomerItemNumber { get; set; }
		public string PackTypeCode { get; set; }
		public string Description { get; set; }
		public double Weight { get; set; }
		public double Volume { get; set; }
		public double Length { get; set; }
		public double Width { get; set; }
		public double Height { get; set; }
		public bool Stackable { get; set; }
		public string FreightClass { get; set; }
		public bool FoodGrade { get; set; }
		public List<ItemLine> ItemLines { get; set; }
		public List<HireLine> HireLines { get; set; }
	}

	public class ItemLine
	{
		public int Units { get; set; }
		public string PackTypeCode { get; set; }
		public string Description { get; set; }
		public List<DangerousGoodsLine> DangerousGoodsLines { get; set; }
	}

	public class DangerousGoodsLine
	{
		public string Class { get; set; }
		public string UnNumber { get; set; }
		public string Variant { get; set; }
		public string ProperName { get; set; }
		public string TechnicalName { get; set; }
		public string CommonName { get; set; }
		public string SubRisk { get; set; }
		public string TertiarySubRisk { get; set; }
		public string HazChem { get; set; }
		public string PackingGroup { get; set; }
		public string FlashPoint { get; set; }
		public string AdditionalInfo { get; set; }
		public string PackageType { get; set; }
		public string PackageInstruction { get; set; }
		public bool MarinePollutant { get; set; }
		public bool Acid { get; set; }
		public bool Alkali { get; set; }
		public double GrossWeight { get; set; }
		public double Volume { get; set; }
		public int Units { get; set; }
		public string Description { get; set; }
	}

	public class HireLine
	{
		public string Supplier { get; set; }
		public string PalletType { get; set; }
		public string ToAccount { get; set; }
		public string FromAccount { get; set; }
		public string TransactionType { get; set; }
		public int Quantity { get; set; }
	}
}
