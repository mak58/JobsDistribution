namespace Distribuited.Models;
public class Title
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public decimal Amount { get; set; }

    public override string ToString()
    {
        return $"Company #{Id}, Quantity jobs {Quantity}, Amount {Amount} ";
    }
}
