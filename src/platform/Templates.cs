using Sitecore.Data;

namespace RenderingHost
{
    public static class Templates
    {
        public static class SiteRoot
        {
            public static readonly ID Id = ID.Parse("{061CBA15-5474-4B91-8A06-17903B102B82}");
        }
        
        public static class Page
        {
            public static readonly ID Id = ID.Parse("{85CD20BD-9E45-40D1-BB24-9B165667EA7A}");

            public static class Fields
            {
                public static readonly ID Title = ID.Parse("{E5365688-B6BB-41AB-AAFB-3215D68507D8}");
            }
        }
    }
}