using OpenClosedPrinciple.Entities;
using OpenClosedPrinciple.Enums;
using OpenClosedPrinciple.Interfaces;

namespace OpenClosedPrinciple.Extensions
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Color == color;
        }
    }
}
