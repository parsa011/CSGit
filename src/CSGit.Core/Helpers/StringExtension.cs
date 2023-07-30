namespace CSGit.Core.Helpers
{
    public static class StringHelper
    {
        public static string WhiteSpace(int count)
        {
            string buf = "";
            for (int i = 0; i < count; i++)
                buf += " ";
            return buf;
        }
    }
}
