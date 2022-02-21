using GerEstoque.Api.Contexts;

namespace GerEstoque.Api.Persistance.Repositories
{
    public class BaseRepository
    {
        protected readonly GerEstoqueContext _gerEstoqueContext;

        public BaseRepository(GerEstoqueContext gerEstoqueContext)
        {
            _gerEstoqueContext = gerEstoqueContext;
        }
    }
}