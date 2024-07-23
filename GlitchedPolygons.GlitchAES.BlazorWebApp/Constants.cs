namespace GlitchedPolygons.GlitchAES.BlazorWebApp;

public static class Constants
{
    public static class Bool
    {
        public const string TRUE = "true";
        public const string FALSE = "false";
    }
    
    public static class PreferenceIds
    {
        public const string DARK_THEME = "DarkTheme";
    }

    public static class AesGcm
    {
        public const int NONCE_SIZE_BYTES = 12;
        public const int MAC_SIZE_BYTES = 16;
        public const int TAG_SIZE_BYTES = 16;
        public const int KEY_SIZE_BYTES = 32;
    }
}