namespace B3.CdbCalc.Dto;

public class Cdb
{
    public decimal GrossValue { get; private set; }
    public decimal NetValue { get; private set; }
    public int Month { get; private set; }

    public Cdb(decimal grossValue, decimal netValue, int month)
    {
        GrossValue = grossValue;
        NetValue = netValue;
        Month = month;
    }
}
