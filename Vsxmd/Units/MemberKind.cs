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
        Type = 1,

        /// <summary>
        /// Constants
        /// </summary>
        Constants = 2,

        /// <summary>
        /// Constructor.
        /// </summary>
        Constructor = 3,

        /// <summary>
        /// Property.
        /// </summary>
        Property = 4,

        /// <summary>
        /// Method.
        /// </summary>
        Method = 5,
    }
}
