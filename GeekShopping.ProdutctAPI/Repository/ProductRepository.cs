using AutoMapper;
using GeekShopping.ProdutctAPI.Contracts.DTOs;
using GeekShopping.ProdutctAPI.Model;
using GeekShopping.ProdutctAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProdutctAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public ProductRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProductDTO>> FindAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return _mapper.Map<List< ProductDTO>>(products);
        }

        public async Task<ProductDTO> FindById(long id)
        {

            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            return _mapper.Map<ProductDTO>(product);
        }
        
        public async Task<ProductDTO> Create(ProductDTO dto)
        {
            Product product = _mapper.Map<Product>(dto); // Convertendo o DTO para a entidade Product
            _context.Products.Add(product); // Adicionando a entidade Product ao contexto
            await _context.SaveChangesAsync(); // Salvando as alterações no banco de dados
            return _mapper.Map<ProductDTO>(product); // Convertendo a entidade Product de volta para ProductDTO e retornando
        }

        public async Task<ProductDTO> Update(ProductDTO dto)
        {
            Product product = _mapper.Map<Product>(dto); // Convertendo o DTO para a entidade Product
            _context.Products.Update(product); // Atualizando a entidade Product no contexto
            await _context.SaveChangesAsync(); // Salvando as alterações no banco de dados
            return _mapper.Map<ProductDTO>(product);
        }
        public async Task<bool> Delete(long id)
        {
            try
            {
                var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
                if (product == null)
                    return false;
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }   
        }

    }
}
