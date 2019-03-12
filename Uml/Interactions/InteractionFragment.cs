﻿// -------------------------------------------------------------------------------------------------
// <copyright file="InteractionFragment.cs" company="RHEA System S.A.">
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
    using Uml.Assembler;
    using Uml.Attributes;
    using Uml.Classification;
    using Uml.CommonStructure;

    /// <summary>
    /// <see cref="InteractionFragment"/> is an abstract notion of the most general interaction unit. An <see cref="InteractionFragment"/> is a piece of an <see cref="Interaction"/>. Each <see cref="InteractionFragment"/> is conceptually like an <see cref="Interaction"/> by itself.
    /// </summary>
    [Class(IsAbstract = true, IsActive = false, Specializations = "CombinedFragment|Continuation|ExecutionSpecification|Interaction|InteractionOperand|InteractionUse|OccurrenceSpecification|StateInvariant")]
    public interface InteractionFragment : NamedElement
    {
        /// <summary>
        /// References the <see cref="Lifeline"/>s that the <see cref="InteractionFragment"/> involves.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        List<Lifeline> Covered { get; set; }

        /// <summary>
        /// The <see cref="Interaction"/> enclosing this <see cref="InteractionFragment"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "NamedElement.Namespace", RedefinedProperty = "")]
        Interaction EnclosingInteraction { get; set; }

        /// <summary>
        /// The operand enclosing this <see cref="InteractionFragment"/> (they may nest recursively).
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "NamedElement.Namespace", RedefinedProperty = "")]
        InteractionOperand EnclosingOperand { get; set; }

        /// <summary>
        /// The general ordering relationships contained in this fragment.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.Composite, SubsettedProperty = "Element.OwnedElement", RedefinedProperty = "")]
        OwnerList<GeneralOrdering> GeneralOrdering { get; set; }
    }
}