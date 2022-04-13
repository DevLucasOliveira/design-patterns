using InterfaceSegregationPrinciple.Interfaces;
using System;

namespace InterfaceSegregationPrinciple.Entities
{
    public class PhotoCopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }
}
