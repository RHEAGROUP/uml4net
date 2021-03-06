﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ElementImport.cs" company="RHEA System S.A.">
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
    using Uml.Attributes;
    using Uml.Classification;

    /// <summary>
    /// An <see cref="ElementImport"/> identifies a <see cref="NamedElement"/> in a <see cref="Namespace"/> other than the one that owns that <see cref="NamedElement"/> and allows the <see cref="NamedElement"/> to be referenced using an unqualified name in the Namespace owning the <see cref="ElementImport"/>.
    /// </summary>
    [Class(IsAbstract = false, IsActive = false)]
    public interface ElementImport : DirectedRelationship
    {
        /// <summary>
        /// Specifies the name that should be added to the importing Namespace in lieu of the name of the imported <see cref="PackagableElement"/>. The alias must not clash with any other member in the importing Namespace. By default, no alias is used.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "1")]
        [Property(IsDerived = true, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        string Alias { get; set; }

        /// <summary>
        /// Specifies the <see cref="PackageableElement"/> whose name is to be added to a <see cref="Namespace"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "DirectedRelationship.Target", RedefinedProperty = "")]
        PackageableElement ImportedElement { get; set; }

        /// <summary>
        /// Specifies the <see cref="Namespace"/> that imports a <see cref="PackageableElement"/> from another <see cref="Namespace"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "DirectedRelationship.Source|Element.Owner", RedefinedProperty = "")]
        Namespace ImportingNamespace { get; set; }

        /// <summary>
        /// Specifies the visibility of the imported <see cref="PackageableElement"/> within the importingNamespace, i.e., whether the  importedElement will in turn be visible to other <see cref="Namespaces"/>. If the <see cref="ElementImport"/> is public, the importedElement will be visible outside the importingNamespace while, if the <see cref="ElementImport"/> is private, it will not.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        VisibilityKind Visibility { get; set; }
    }
}