namespace Syrna.DynamicPermission
{
    public static class DynamicPermissionDbProperties
    {
        public static string DbTablePrefix { get; set; } = "Syrna";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "SyrnaDynamicPermission";
    }
}
