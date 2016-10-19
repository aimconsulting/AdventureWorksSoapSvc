using System.ServiceModel;

namespace AdventureWorksSvc
{
    [ServiceContract]
    public interface IProductsService
    {
        [OperationContract]
        Product GetProductsByCategory(string category);
    }
}
