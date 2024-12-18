using System;
using JetBrains.Annotations;

namespace Syrna.DynamicPermission.PermissionDefinitions.Dtos
{
    public class PermissionDefinitionKey
    {
        public string Name { get; set; }

        public PermissionDefinitionKey()
        {
        }
        
        public PermissionDefinitionKey([NotNull] string name)
        {
            Name = name;
        }
    }
}