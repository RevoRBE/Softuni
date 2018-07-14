namespace FestivalManager.Entities.Instruments
{
    public class Guitar : Instrument
    {
        private int RepairAmountConst = 60;
	    protected override int RepairAmount => RepairAmountConst;
    }
}
