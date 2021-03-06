// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Internal.TypeSystem
{
    partial class TypeDesc
    {
        /// <summary>
        /// Gets a value indicating whether the concrete type this object represents is unknown
        /// at compile time. For a constructed type, returns true if any of the constituents are
        /// unknown at compile time. Use <see cref="IsRuntimeDeterminedType"/> to check if
        /// this is a runtime determined type without checking constituents.
        /// </summary>
        public abstract bool IsRuntimeDeterminedSubtype
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether this is a runtime determined type. This will not
        /// check the composition of constructed types for runtime determined types. Use
        /// <see cref="IsRuntimeDeterminedSubtype"/> to do that.
        /// </summary>
        public bool IsRuntimeDeterminedType
        {
            get
            {
                return this.GetType() == typeof(RuntimeDeterminedType);
            }
        }
    }
}
