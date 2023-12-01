
namespace Distribuited.Models;

public class Charge : Entity
{
    public decimal Value { get; set; } = 0M;
    public ChargeSetValue ChargeSetValue { get; set; } = ChargeSetValue.Asserted;

}