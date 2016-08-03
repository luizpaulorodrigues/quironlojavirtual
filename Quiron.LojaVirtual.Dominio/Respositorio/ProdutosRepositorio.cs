using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiron.LojaVirtual.Dominio.Entidades;
namespace Quiron.LojaVirtual.Dominio.Respositorio
{
    public class ProdutosRepositorio
    {
        private readonly EFDbContext _context = new EFDbContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produto; }

        }        
    }
}
