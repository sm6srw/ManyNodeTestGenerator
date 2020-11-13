using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace <%namespace%>
{
    public class NodeType_Base
    {
        public NodeType_Base() { }
    }

    public class NodeType_Top : NodeType_Base
    {
        public NodeType_Top() { }
    }

    public class NodeType_Middle : NodeType_Top
    {
        public NodeType_Middle() { }
    }

    public class NodeType_Bottom : NodeType_Middle
    {
        public NodeType_Bottom() { }
    }

<%nodeDefinitions%>
}
