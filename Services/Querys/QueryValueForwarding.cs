namespace Distribuited.Services.Querys;

public static class QueryValueForwarding
{
    public static int GetLastValueForwardingId() =>
        Program.ValueForwardings.Count > 0
            ? Program.ValueForwardings.Last().Id
            : 0;
}
