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
        public int Build { set; get; }

        public V2RayVersion()
        {

        }

        public V2RayVersion(int Major, int Minor, int Build)
        {
            this.Major = Major;
            this.Minor = Minor;
            this.Build = Build;
        }

        public static bool operator >=(V2RayVersion left, V2RayVersion right)
        {
            return (left.Major > right.Major)
                || (left.Major == right.Major && left.Minor > right.Minor)
                || (left.Major == right.Major && left.Minor == right.Minor && left.Build >= right.Build);
        }

        public static bool operator <=(V2RayVersion left, V2RayVersion right)
        {
            return (left.Major < right.Major)
                || (left.Major == right.Major && left.Minor < right.Minor)
                || (left.Major == right.Major && left.Minor == right.Minor && left.Build <= right.Build);
        }

        public static bool operator >(V2RayVersion left, V2RayVersion right)
        {
            return (left.Major > right.Major)
                || (left.Major == right.Major && left.Minor > right.Minor)
                || (left.Major == right.Major && left.Minor == right.Minor && left.Build > right.Build);
        }

        public static bool operator <(V2RayVersion left, V2RayVersion right)
        {
            return (left.Major < right.Major)
                || (left.Major == right.Major && left.Minor < right.Minor)
                || (left.Major == right.Major && left.Minor == right.Minor && left.Build < right.Build);
        }

        public override string ToString() => $"v{Major}.{Minor}.{Build}";
    }
}
