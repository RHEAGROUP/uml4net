﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ProfileApplication.cs" company="RHEA System S.A.">
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

namespace Uml.Packages
{
    using Uml.Attributes;
    using Uml.Classification;
    using Uml.CommonStructure;

    /// <summary>
    /// A profile application is used to show which profiles have been applied to a package.
    /// </summary>
    [Class(IsAbstract = false, IsActive = false, Specializations = "")]
    public interface ProfileApplication : DirectedRelationship
    {
        /// <summary>
        /// References the <see cref="Profile"/>s that are applied to a <see cref="Package"/> through this <see cref="ProfileApplication"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "DirectedRelationship.Target", RedefinedProperty = "")]
        Profile AppliedProfile { get; set; }

        /// <summary>
        /// The package that owns the profile application.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "DirectedRelationship.Source|Element.Owner", RedefinedProperty = "")]
        Package ApplyingPackage { get; set; }

        /// <summary>
        /// Specifies that the <see cref="Profile"/> filtering rules for the metaclasses of the referenced metamodel shall be strictly applied.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        bool IsStrict { get; set; }
    }
}