namespace AworksFrontEndDomain.Models;

public class SalesCustomer
{
    private Guid _rowGuid;

    public int CustomerId { get; set; }
    public int? PersonId { get; set; }
    public int? StoreId { get; set; }
    public int? TerritoryId { get; set; }
    public string AccountNumber { get; set; } = string.Empty;
    public Guid rowguid
    {
        get
        {
            if (_rowGuid == Guid.Empty)
            {
                _rowGuid = Guid.NewGuid();
            }
            return _rowGuid;
        }
        set { _rowGuid = value; }
    }
    public DateTime? ModifiedDate { get; set; }

}
