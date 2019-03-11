﻿// -------------------------------------------------------------------------------------------------
// <copyright file="Behavior.cs" company="RHEA System S.A.">
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
    using Uml.Assembler;
    using Uml.Attributes;
    using Uml.Classification;
    using Uml.CommonStructure;
    using Uml.SimpleClassifiers;
    using Uml.StructuredClassifiers;

    /// <summary>
    /// <see cref="Behavior"/> is a specification of how its context <see cref="BehavioredClassifier"/> changes state over time. This specification may be either a definition of possible behavior execution or emergent behavior, or a selective illustration of an interesting subset of possible executions. The latter form is typically used for capturing examples, such as a trace of a particular execution.
    /// </summary>
    [Class(IsAbstract = true, IsActive = false, Specializations = "OpaqueBehavior|Activity|StateMachine|Interaction")]
    public interface Behavior : Class
    {
        /// <summary>
        /// The <see cref="BehavioredClassifier"/> that is the context for the execution of the <see cref="Behavior"/>. A <see cref="Behavior"/> that is directly owned as a nestedClassifier does not have a context. Otherwise, to determine the context of a <see cref="Behavior"/>, find the first <see cref="BehavioredClassifier"/> reached by following the chain of owner relationships from the <see cref="Behavior"/>, if any. If there is such a <see cref="BehavioredClassifier"/>, then it is the context, unless it is itself a <see cref="Behavior"/> with a non-empty context, in which case that is also the context for the original <see cref="Behavior"/>. For example, following this algorithm, the context of an entry <see cref="Behavior"/> in a <see cref="StateMachine"/> is the <see cref="BehavioredClassifier"/> that owns the <see cref="StateMachine"/>. The features of the context <see cref="BehavioredClassifier"/> as well as the <see cref="Element"/>s visible to the context <see cref="Classifier"/> are visible to the <see cref="Behavior"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "1")]
        [Property(IsDerived = true, IsDerivedUnion = false, IsReadOnly = true, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "RedefinableElement.RedefinitionContext", RedefinedProperty = "")]
        BehavioredClassifier Context();

        /// <summary>
        /// Tells whether the <see cref="Behavior"/> can be invoked while it is still executing from a previous invocation.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        bool IsReentrant { get; set; }

        /// <summary>
        /// References a list of <see cref="Parameter"/>s to the Behavior which describes the order and type of arguments that can be given when the Behavior is invoked and of the values which will be returned when the <see cref="Behavior"/> completes its execution.
        /// </summary>
        [MultiplicityElement(IsOrdered = true, IsUnique = true, Lower = 0, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.Composite, SubsettedProperty = "Namespace.OwnedMember", RedefinedProperty = "")]
        OwnerList<Parameter> OwnedParameter { get; set; }

        /// <summary>
        /// The <see cref="ParameterSet"/>s owned by this <see cref="Behavior"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.Composite, SubsettedProperty = "Namespace.OwnedMember", RedefinedProperty = "")]
        OwnerList<ParameterSet> OwnedParameterSet { get; set; }

        /// <summary>
        /// An optional set of <see cref="Constraint"/>s specifying what is fulfilled after the execution of the Behavior is completed, if its precondition was fulfilled before its invocation.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.Composite, SubsettedProperty = "Namespace.OwnedRule", RedefinedProperty = "")]
        OwnerList<Constraint> PostCondition { get; set; }

        /// <summary>
        /// An optional set of <see cref="Constraint"/>s specifying what must be fulfilled before the <see cref="Behavior"/> is invoked.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.Composite, SubsettedProperty = "Namespace.OwnedRule", RedefinedProperty = "")]
        OwnerList<Constraint> PreCondition { get; set; }

        /// <summary>
        /// Designates a <see cref="BehavioralFeature"/> that the <see cref="Behavior"/> implements. The <see cref="BehavioralFeature"/> must be owned by the <see cref="BehavioredClassifier"/> that owns the <see cref="Behavior"/> or be inherited by it. The <see cref="Parameter"/>s of the <see cref="BehavioralFeature"/> and the implementing Behavior must match. A <see cref="Behavior"/> does not need to have a specification, in which case it either is the classifierBehavior of a <see cref="BehavioredClassifier"/> or it can only be invoked by another <see cref="Behavior"/> of the <see cref="Classifier"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        BehavioralFeature Specification { get; set; }

        /// <summary>
        /// References the <see cref="Behavior"/> that this <see cref="Behavior"/> redefines. A subtype of <see cref="Behavior"/> may redefine any other subtype of <see cref="Behavior"/>. If the Behavior implements a <see cref="BehavioralFeature"/>, it replaces the redefined <see cref="Behavior"/>. If the <see cref="Behavior"/> is a classifierBehavior, it extends the redefined <see cref="Behavior"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "Classifier.RedefinedClassifier", RedefinedProperty = "")]
        List<Behavior> RedefinedBehavior { get; set; }
    }
}