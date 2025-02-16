namespace ASPNETMaker2024.Models;

// Partial class
public partial class UAMS_20250216_1835 {

    public class JsonString
    {
        protected string? _str;

        public JsonString(string? value)
        {
            _str = value;
        }

        public static implicit operator string?(JsonString jsonString) => jsonString._str;

        public static implicit operator JsonString(string? value) => new JsonString(value);
    }
} // End Partial class
