using B3.CdbCalc.Dto;

namespace B3.CdbCalc.Application.Interfaces;

public interface ICdbCalc : IDisposable
{
    public IList<Cdb> DenominateValue(decimal initialValue, decimal months);
}
