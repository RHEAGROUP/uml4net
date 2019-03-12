﻿// -------------------------------------------------------------------------------------------------
// <copyright file="OccurrenceSpecification.cs" company="RHEA System S.A.">
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

namespace Uml.Interactions
{
    using System.Collections.Generic;
    using Uml.Attributes;
    using Uml.Classification;

    /// <summary>
    /// An <see cref="OccurrenceSpecification"/> is the basic semantic unit of <see cref="Interaction"/>s. The sequences of occurrences specified by them are the meanings of <see cref="Interaction"/>s.
    /// </summary>
    [Class(IsAbstract = false, IsActive = false, Specializations = "ExecutionOccurrenceSpecification|MessageOccurrenceSpecification")]
    public interface OccurrenceSpecification : InteractionFragment
    {
        /// <summary>
        /// References the <see cref="Lifeline"/> on which the <see cref="OccurrenceSpecification"/> appears.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "InteractionFragment.Covered")]
        Lifeline Covered { get; set; }

        /// <summary>
        /// References the <see cref="GeneralOrdering"/>s that specify EventOcurrences that must occur after this <see cref="OccurrenceSpecification"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        List<GeneralOrdering> ToAfter { get; set; }

        /// <summary>
        /// References the <see cref="GeneralOrdering"/>s that specify EventOcurrences that must occur before this <see cref="OccurrenceSpecification"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        List<GeneralOrdering> ToBefore { get; set; }
    }
}