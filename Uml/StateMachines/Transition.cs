﻿// -------------------------------------------------------------------------------------------------
// <copyright file="Transition.cs" company="RHEA System S.A.">
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

namespace Uml.StateMachines
{
    using Uml.Assembler;
    using Uml.Attributes;
    using Uml.Classification;
    using Uml.CommonBehavior;
    using Uml.CommonStructure;

    /// <summary>
    /// A <see cref="Transition"/> represents an arc between exactly one source <see cref="Vertex"/> and exactly one <see cref="Target"/> vertex (the source and targets may be the same <see cref="Vertex"/>). It may form part of a compound transition, which takes the <see cref="StateMachine"/> from one steady <see cref="State"/> configuration to another, representing the full response of the <see cref="StateMachine"/> to an occurrence of an <see cref="Event"/> that triggered it.
    /// </summary>
    [Class(IsAbstract = false, IsActive = false, Specializations = "ProtocolTransition")]
    public interface Transition : Namespace, RedefinableElement
    {
        /// <summary>
        /// Designates the <see cref="Region"/> that owns this <see cref="Transition"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "NamedElement.Namespace", RedefinedProperty = "")]
        Region Container { get; set; }

        /// <summary>
        /// Specifies an optional behavior to be performed when the <see cref="Transition"/> fires.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.Composite, SubsettedProperty = "Element.OwnedElement", RedefinedProperty = "")]
        OwnerList<Behavior> Effect { get; set; }

        /// <summary>
        /// A guard is a <see cref="Constraint"/> that provides a fine-grained control over the firing of the <see cref="Transition"/>. The guard is evaluated when an <see cref="Event"/> occurrence is dispatched by the <see cref="StateMachine"/>. If the guard is true at that time, the <see cref="Transition"/> may be enabled, otherwise, it is disabled. Guards should be pure expressions without side effects. Guard expressions with side effects are ill formed.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.Composite, SubsettedProperty = "Namespace.OwnedRule", RedefinedProperty = "")]
        OwnerList<Constraint> Guard { get; set; }

        /// <summary>
        /// Indicates the precise type of the <see cref="Transition"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        TransitionKind Kind { get; set; }

        /// <summary>
        /// The <see cref="Transition"/> that is redefined by this <see cref="Transition"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "RedefinableElement.RedefinedElement", RedefinedProperty = "")]
        Transition RedefinedTransition { get; set; }

        /// <summary>
        /// References the <see cref="Classifier"/> in which context this element may be redefined.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = true, IsDerivedUnion = false, IsReadOnly = true, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        Classifier RedefinitionContext { get; }

        /// <summary>
        /// Designates the originating <see cref="Vertex"/> (<see cref="State"/> or <see cref="Pseudostate"/>) of the <see cref="Transition"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        Vertex Source { get; set; }

        /// <summary>
        /// Designates the target <see cref="Vertex"/> that is reached when the <see cref="Transition"/> is taken.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        Vertex Target { get; set; }

        /// <summary>
        /// Specifies the <see cref="Trigger"/>s that may fire the transition.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.Composite, SubsettedProperty = "Element.OwnedElement", RedefinedProperty = "")]
        OwnerList<Trigger> Trigger { get; set; }
    }
}