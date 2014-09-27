////TASK 11
////Create a [Version] attribute that can be applied to structures, classes, interfaces,
////enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
////Apply the version attribute to a sample class and display its version at runtime.

namespace Euclidian3DSpace
{
    using System;

    public class VersionAttribute : Attribute
    {
        private double version;

        public VersionAttribute(double ver)
        {
            this.version = ver;
        }

        public double GetVersion
        {
            get
            {
                return this.version;
            }
        }
    }
}
