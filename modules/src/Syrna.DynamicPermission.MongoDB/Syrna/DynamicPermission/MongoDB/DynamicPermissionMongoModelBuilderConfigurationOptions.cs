﻿using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Syrna.DynamicPermission.MongoDB
{
    public class DynamicPermissionMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public DynamicPermissionMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}