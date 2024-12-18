using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Syrna.DynamicPermission.EntityFrameworkCore
{
    public class DynamicPermissionModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public DynamicPermissionModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}