﻿// -------------------------------------------------------------------------------------------------
// <copyright file="DirectedRelationship.cs" company="RHEA System S.A.">
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

namespace Uml.CommonStructure
{
    using System.Collections.Generic;
    using Uml.Attributes;
    using Uml.Classification;

    /// <summary>
    /// A <see cref="DirectedRelationship"/> represents a relationship between a collection of source model Elements and a collection of target model <see cref="Element"/>s.
    /// </summary>
    [Class(IsAbstract = true, IsActive = false, Specializations = "Dependency|ElementImport|PackageImport|TemplateBinding|Extend|Include|ProtocolConformance|PackageMerge|ProfileApplication|InformationFlow|Generalization")]
    public interface DirectedRelationship : Relationship
    {
        /// <summary>
        /// Specifies the source Element(s) of the <see cref="DirectedRelationship"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "*")]
        [Property(IsDerived = true, IsDerivedUnion = true, IsReadOnly = true, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "Relationship.RelatedElement", RedefinedProperty = "")]
        IEnumerable<Element> Source();

        /// <summary>
        /// Specifies the target Element(s) of the <see cref="DirectedRelationship"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "*")]
        [Property(IsDerived = true, IsDerivedUnion = true, IsReadOnly = true, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "Relationship.RelatedElement", RedefinedProperty = "")]
        IEnumerable<Element> Target();
    }
}