namespace ASPNETMaker2024.Models;

// Partial class
public partial class UAMS_20250216_1835 {

    public class BitBool
    {
        protected bool? _bool;

        public BitBool(bool? value )
        {
            _bool = value;
        }

        public static implicit operator bool?(BitBool bitBool) => bitBool._bool;

        public static implicit operator BitBool(bool? value) => new BitBool(value);
    }
} // End Partial class
