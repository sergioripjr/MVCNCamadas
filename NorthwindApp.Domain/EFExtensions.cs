using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;

namespace NorthwindApp.Domain
{
    static class EFExtensions
    {
        public static void Update(this ObjectContext context, string entitySetName, EntityObject entity)
        {
            if (entity.EntityKey == null)
                entity.EntityKey = context.CreateEntityKey(entitySetName, entity);
            if (entity.EntityState == System.Data.EntityState.Detached)
                context.Attach(entity);
            var stateEntry = context.ObjectStateManager.GetObjectStateEntry(entity.EntityKey);
            var propertyNameList = stateEntry.CurrentValues.DataRecordInfo.FieldMetadata.Select(pn => pn.FieldType.Name);
            foreach (var propName in propertyNameList)
            {
                stateEntry.SetModifiedProperty(propName);
            }
        }
    }
}
