using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Structural.Adapter
{
    class CustomOperation
    {
        private IJsonSerializer _jsonSerializer;

        public CustomOperation(IJsonSerializer jsonSerializer)
        {
            _jsonSerializer = jsonSerializer;
        }
        public string SerializeObject(object obj)
        {
            return _jsonSerializer.SerializeObject(obj);
        }
    }
}
