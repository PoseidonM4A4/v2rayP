using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2rayP.Model
{
    public class V2RayVersion
    {
        public int Major { set; get; }
        public int Minor { set; get; }

        public V2RayVersion()
        {

        }

        public V2RayVersion(int Major, int Minor)
        {
            this.Major = Major;
            this.Minor = Minor;
        }

        public static bool operator >=(V2RayVersion lOperand, V2RayVersion rOperand)
        {
            return (lOperand.Major > rOperand.Major)
                || (lOperand.Major == rOperand.Major && lOperand.Minor >= rOperand.Minor);
        }

        public static bool operator <=(V2RayVersion lOperand, V2RayVersion rOperand)
        {
            return (lOperand.Major < rOperand.Major)
                || (lOperand.Major == rOperand.Major && lOperand.Minor <= rOperand.Minor);
        }

        public static bool operator >(V2RayVersion lOperand, V2RayVersion rOperand)
        {
            return (lOperand.Major > rOperand.Major)
                || (lOperand.Major == rOperand.Major && lOperand.Minor > rOperand.Minor);
        }

        public static bool operator <(V2RayVersion lOperand, V2RayVersion rOperand)
        {
            return (lOperand.Major < rOperand.Major)
                || (lOperand.Major == rOperand.Major && lOperand.Minor < rOperand.Minor);
        }

        public override string ToString() => $"v{Major}.{Minor}";
    }
}
