namespace ClassLibrary
{
    public static class PlayerExtensions
    {
        public static string GetFlagFilename(this Player player)
        {
            return $"{player.HomeCountry.Alpha2Code}.png".ToLower();
        }

        private static void Refresh(this Player player)
        {
            player.HomeCountry = null;
        }
    }

}
