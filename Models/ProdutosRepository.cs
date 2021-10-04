using System.Collections.Generic;

namespace mvc1.Models
{
    public class ProdutosRepository : IRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProdutosRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Produto> Produtos => _appDbContext.Produtos;
    }
}
