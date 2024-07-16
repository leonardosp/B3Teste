using B3.CdbCalc.Application.Interfaces;
using B3.CdbCalc.Dto;

namespace B3.CdbCalc.Application;

public class CdbCalc : ICdbCalc
{
    public readonly decimal cdiValue = 0.009m;
    public readonly decimal tbValue = 1.08m;
    private readonly IList<Cdb> ValuesAndMonths = new List<Cdb>();
    private readonly IList<(decimal, int)> Taxes = new List<(decimal, int)>
    {
        (22.5m, 6),
        (20m, 12),
        (17.5m, 24),
        (15m, 25),
    };

    public IList<Cdb> DenominateValue(decimal initialValue, decimal months)
    {
        decimal vf = decimal.Zero;
        decimal netValue = decimal.Zero;
        decimal tax = decimal.Zero;

        vf = initialValue * (1 + (cdiValue * tbValue));

        tax = ObtainTax(months);

        for (int i = 0; i < months; i++)
        {
            netValue = ReturnNetvalue(vf, tax / 100);

            ValuesAndMonths.Add(new Cdb(vf, netValue, i+1));

            vf = vf * (1 + (cdiValue * tbValue));
        }

        return ValuesAndMonths;
    }

    private decimal ReturnNetvalue(decimal grossValue, decimal tax)
    {
        return grossValue - (tax * grossValue);
    }

    private decimal ObtainTax(decimal months)
    {
        if (months > 24) return Taxes.Last().Item1;
        else
            return Taxes.First(x => x.Item2 >= months).Item1;
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
