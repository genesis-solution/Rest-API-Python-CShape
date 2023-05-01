using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Message
    {
        public Message()
        {
            id = data = "";
        }
        public Message(String _id, string _data)
        {
            id = _id;
            data = _data;
        }
        public Message(string _data)
        {
            id = Guid.NewGuid().ToString("N");
            data = _data;
        }
        public String id { get; set; }
        public string data { get; set; }

        public string type { get; set; }

        override public String ToString()
        {
            return "{ \"id\" : \"" + id + "\", \"data\" : \"" + data + "\"}";
        }
    }
}
