namespace kata_playground
{
    public partial class Kata
    {
        public static string Rgb(int r, int g, int b)
        {
            return $"{RgbToHex(r)}{RgbToHex(g)}{RgbToHex(b)}";
        }

        private static string RgbToHex(int rgb)
        {
            if (BelowMinimumRgb(rgb)) return "00";
            else if (AboveMaximumRgb(rgb)) return "FF";
            else return string.Format("{0:X2}", rgb);
        }

        private static bool AboveMaximumRgb(int rgb) => rgb >= 255;
        private static bool BelowMinimumRgb(int rgb) => rgb <= 0;
    }
}