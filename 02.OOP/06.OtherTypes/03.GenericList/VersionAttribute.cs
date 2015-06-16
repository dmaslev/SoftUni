using System;

namespace _03.GenericList
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface |
    AttributeTargets.Enum | AttributeTargets.Method,
    AllowMultiple = true)]
    class VersionAttribute : System.Attribute
    {
        public int Major { get; set; }
        public int Minor { get; set; }

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
    }
}
