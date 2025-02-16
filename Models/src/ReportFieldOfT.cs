namespace ASPNETMaker2024.Models;

// Partial class
public partial class UAMS_20250216_1835 {
    /// <summary>
    /// Field class of T
    /// </summary>
    /// <typeparam name="T">Field type</typeparam>
    public class ReportField<T> : ReportField
    { // DN

        public T DbType; // Field type (.NET data type)

        public ReportField(object table, string fieldVar, int type, T dbType) : base(table, fieldVar, type)
        {
            DbType = dbType;
        }
    }
} // End Partial class
