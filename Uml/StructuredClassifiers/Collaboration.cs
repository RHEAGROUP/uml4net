﻿// -------------------------------------------------------------------------------------------------
// <copyright file="Collaboration.cs" company="RHEA System S.A.">
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

namespace Uml.StructuredClassifiers
{
    using System.Collections.Generic;
    using Uml.Attributes;
    using Uml.Classification;
    using Uml.SimpleClassifiers;

    /// <summary>
    /// A Collaboration describes a structure of collaborating elements (roles), each performing a specialized function, which collectively accomplish some desired functionality. 
    /// </summary>
    [Class(IsAbstract = false, IsActive = false, Specializations = "")]
    public interface Collaboration : StructuredClassifier, BehavioredClassifier
    {
        /// <summary>
        /// Represents the participants in the <see cref="Collaboration"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "StructuredClassifier.Role", RedefinedProperty = "")]
        List<ConnectableElement> CollaborationRole { get; set; }
    }
}