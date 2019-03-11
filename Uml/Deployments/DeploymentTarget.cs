﻿// -------------------------------------------------------------------------------------------------
// <copyright file="DeploymentTarget.cs" company="RHEA System S.A.">
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

namespace Uml.Deployments
{
    using System.Collections.Generic;
    using Uml.Assembler;
    using Uml.Attributes;
    using Uml.Classification;
    using Uml.CommonStructure;

    /// <summary>
    /// A deployment target is the location for a deployed artifact.
    /// </summary>
    [Class(IsAbstract = true, IsActive = false, Specializations = "Node|InstanceSpecification|Property")]
    public interface DeploymentTarget : NamedElement
    {
        /// <summary>
        /// The set of elements that are manifested in an <see cref="Artifact"/> that is involved in <see cref="Deployment"/> to a <see cref="DeploymentTarget"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "*")]
        [Property(IsDerived = true, IsDerivedUnion = false, IsReadOnly = true, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        IEnumerable<PackageableElement> DeployedElement { get; set; }

        /// <summary>
        /// The set of Deployments for a <see cref="DeploymentTarget"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.Composite, SubsettedProperty = "Element.OwnedElement|NamedElement.ClientDependency", RedefinedProperty = "")]
        OwnerList<Deployment> Deployment { get; set; }
    }
}