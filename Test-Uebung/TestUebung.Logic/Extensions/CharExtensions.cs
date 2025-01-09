namespace TestUebung.Logic.Extensions;

public static class CharExtensions
{
        #region public METHODS
        public static string ForegroundColor(this char source , string colorInstruction)
                => source.Color(colorInstruction);
        public static string BackgroundColor(this char source , string colorInstruction)
                => source.Color(colorInstruction , foreground: false);
        public static string Color(this char source , string colorInstruction , bool foreground = true)
                => (string.Empty + source).Color(colorInstruction , foreground);
        #endregion
}