﻿// -------------------------------------------------------------------------------------------------
// <copyright file="Trigger.cs" company="RHEA System S.A.">
//   Copyright (c) 2018-2019 RHEA System S.A.
//
//   This file is part of uml-sharp
//
//   uml-sharp is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//   
//   uml-sharp is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//   GNU General Public License for more details.
//
//   You should have received a copy of the GNU General Public License
//   along with uml-sharp. If not, see<http://www.gnu.org/licenses/>.
// </copyright>
// -------------------------------------------------------------------------------------------------

namespace Uml.CommonBehavior
{
    using System.Collections.Generic;
    using Uml.Attributes;
    using Uml.Classification;
    using Uml.CommonStructure;
    using Uml.StructuredClassifiers;

    /// <summary>
    /// A <see cref="Trigger"/> specifies a specific point  at which an <see cref="Event"/> occurrence may trigger an effect in a <see cref="Behavior"/>. A <see cref="Trigger"/> may be qualified by the <see cref="Port"/> on which the Event occurred.
    /// </summary>
    [Class(IsAbstract = false, IsActive = false, Specializations = "")]
    public interface Trigger : NamedElement
    {
        /// <summary>
        /// The <see cref="Event"/> that detected by the <see cref="Trigger"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        Event Event { get; set; }

        /// <summary>
        /// A optional <see cref="Port"/> of through which the given effect is detected.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        List<Port> Port { get; set; }
    }
}