//-----------------------------------------------------------------------
// <copyright file="MemberKind.cs" company="Junle Li">
//     Copyright (c) Junle Li. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Vsxmd.Units
{
    /// <summary>
    /// The member kind.
    /// </summary>
    internal enum MemberKind
    {
        /// <summary>
        /// Not supported member kind.
        /// </summary>
        NotSupported = 99,

        /// <summary>
        /// Type.
        /// </summary>
        Type = 0,

        /// <summary>
        /// Constants
        /// </summary>
        Constants = 1,

        /// <summary>
        /// Constructor.
        /// </summary>
        Constructor = 2,

        /// <summary>
        /// Property.
        /// </summary>
        Property = 3,

        /// <summary>
        /// Method.
        /// </summary>
        Method = 4,
    }
}
