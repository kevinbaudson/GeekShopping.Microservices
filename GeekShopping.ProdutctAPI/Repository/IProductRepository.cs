using GeekShopping.ProdutctAPI.Contracts.DTOs;

namespace GeekShopping.ProdutctAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDTO>> FindAll();
        Task<ProductDTO> FindById(long id);
        Task<ProductDTO> Create(ProductDTO dto);
        Task<ProductDTO> Update(ProductDTO dto);
        Task<bool> Delete(long id);
    }
}
