using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M08GenericDataStructures
{
    //class ItemDoesNotExist : [System.Serializable]
    //{
    //}
    public class ItemDoesNotExist : Exception
    {
        public ItemDoesNotExist() { }
        public ItemDoesNotExist(string message) : base(message) { }
        public ItemDoesNotExist(string message, Exception inner) : base(message, inner) { }
        protected ItemDoesNotExist(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        public string GiveMessageAndSource()
        {
            return $@"
Message: {Message},
Source: {Source}";
        }
    }
    
}
