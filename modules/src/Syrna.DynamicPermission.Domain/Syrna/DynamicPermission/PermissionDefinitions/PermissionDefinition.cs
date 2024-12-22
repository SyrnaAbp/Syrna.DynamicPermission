using JetBrains.Annotations;
using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace Syrna.DynamicPermission.PermissionDefinitions
{
    public class PermissionDefinition : AuditedAggregateRoot<string>
    {
        [NotNull]
        [MaxLength(255)]
        public virtual string DisplayName { get; protected set; }

        [CanBeNull]
        [MaxLength(int.MaxValue)]
        public virtual string Description { get; protected set; }

        public virtual bool IsPublic { get; protected set; }

        protected PermissionDefinition()
        {
        }

        public PermissionDefinition(
            string id,
            string displayName,
            string description,
            bool isPublic
        )
        {
            Id = id;
            DisplayName = displayName;
            Description = description;
            IsPublic = isPublic;
        }
    }
}
