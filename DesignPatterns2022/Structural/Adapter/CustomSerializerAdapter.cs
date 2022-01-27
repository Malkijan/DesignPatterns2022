using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2022.Structural.Adapter
{
    class CustomSerializerAdapter : IJsonSerializer
    {
        public string SerializeObject(object obj)
        {
            CustomSerializer customSerializer = new CustomSerializer();
            return customSerializer.Serialize(obj);
        }
    }
}
