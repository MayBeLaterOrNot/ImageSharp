﻿// <copyright file="IccDeviceAttribute.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp
{
    using System;

    /// <summary>
    /// Device attributes. Can be combined with a logical OR
    /// </summary>
    [Flags]
    internal enum IccDeviceAttribute : long
    {
        /// <summary>
        /// Opacity transparent
        /// </summary>
        OpacityTransparent = 1 << 31,

        /// <summary>
        /// Opacity reflective
        /// </summary>
        OpacityReflective = 0,

        /// <summary>
        /// Reflectivity matte
        /// </summary>
        ReflectivityMatte = 1 << 30,

        /// <summary>
        /// Reflectivity glossy
        /// </summary>
        ReflectivityGlossy = 0,

        /// <summary>
        /// Polarity negative
        /// </summary>
        PolarityNegative = 1 << 29,

        /// <summary>
        /// Polarity positive
        /// </summary>
        PolarityPositive = 0,

        /// <summary>
        /// Chroma black and white
        /// </summary>
        ChromaBlackWhite = 1 << 28,

        /// <summary>
        /// Chroma color
        /// </summary>
        ChromaColor = 0,
    }
}
