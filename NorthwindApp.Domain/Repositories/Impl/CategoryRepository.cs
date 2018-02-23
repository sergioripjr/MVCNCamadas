namespace NorthwindApp.Domain.Repositories.Impl
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        #region Implementação obrigatória da classe base
        
        public CategoryRepository(NorthwindEntities context)  
            : base(context) { }

        protected override string TableName
        {
            get { return "Categories"; }
        }

        protected override string EntitySetName
        {
            get { return "Categories"; }
        }

        #endregion
    }
}
