namespace FestivalManager.Entities.Instruments
{
	public class Drums : Instrument
	{
        private int RepairAmountConst = 20;

		protected override int RepairAmount => RepairAmountConst;
	}
}
