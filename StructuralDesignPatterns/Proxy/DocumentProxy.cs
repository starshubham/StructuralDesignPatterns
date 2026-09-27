using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Proxy
{
    public class DocumentProxy : IDocument
    {
        private RealDocument _realDocument;

        private readonly bool _isAuthorized;

        public DocumentProxy(bool isAuthorized)
        {
            _isAuthorized = isAuthorized;
        }

        public void Read()
        {
            if (!_isAuthorized)
            {
                Console.WriteLine("Access Denied.");

                return;
            }

            if (_realDocument == null)
            {
                _realDocument = new RealDocument();
            }

            _realDocument.Read();
        }
    }
}
