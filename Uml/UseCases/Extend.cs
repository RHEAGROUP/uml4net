﻿// -------------------------------------------------------------------------------------------------
// <copyright file="Extend.cs" company="RHEA System S.A.">
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

namespace Uml.UseCases
{
    using System.Collections.Generic;
    using Uml.Assembler;
    using Uml.Attributes;
    using Uml.Classification;
    using Uml.CommonStructure;

    /// <summary>
    /// A relationship from an extending <see cref="UseCase"/> to an extended <see cref="UseCase"/> that specifies how and when the behavior defined in the extending <see cref="UseCase"/> can be inserted into the behavior defined in the extended <see cref="UseCase"/>.
    /// </summary>
    [Class(IsAbstract = false, IsActive = false, Specializations = "")]
    public interface Extend : NamedElement, DirectedRelationship
    {
        /// <summary>
        /// References the condition that must hold when the first <see cref="ExtensionPoint"/> is reached for the extension to take place. If no constraint is associated with the <see cref="Extend"/> relationship, the extension is unconditional.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.Composite, SubsettedProperty = "Element.OwnedElement", RedefinedProperty = "")]
        OwnerList<Constraint> Condition { get; set; }

        /// <summary>
        /// The <see cref="UseCase"/> that is being extended.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "DirectedRelationship.Target", RedefinedProperty = "")]
        UseCase ExtendedCase { get; set; }

        /// <summary>
        /// The <see cref="UseCase"/> that represents the extension and owns the Extend relationship.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "NamedElement.Namespace|DirectedRelationship.Source", RedefinedProperty = "")]
        UseCase Extension { get; set; }

        /// <summary>
        /// An ordered list of <see cref="ExtensionPoint"/>s belonging to the extended UseCase, specifying where the respective behavioral fragments of the extending UseCase are to be inserted. The first fragment in the extending UseCase is associated with the first extension point in the list, the second fragment with the second point, and so on. Note that, in most practical cases, the extending <see cref="UseCase"/> has just a single behavior fragment, so that the list of <see cref="ExtensionPoint"/>s is trivial.
        /// </summary>
        [MultiplicityElement(IsOrdered = true, IsUnique = true, Lower = 1, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        List<ExtensionPoint> ExtensionLocation { get; set; }
    }
}