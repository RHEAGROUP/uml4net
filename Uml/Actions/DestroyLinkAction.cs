﻿// -------------------------------------------------------------------------------------------------
// <copyright file="DestroyLinkAction.cs" company="RHEA System S.A.">
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

namespace Uml.Actions
{
    using Uml.Assembler;
    using Uml.Attributes;
    using Uml.Classification;
    using Uml.StructuredClassifiers;

    /// <summary>
    /// A <see cref="DestroyLinkAction"/> is a <see cref="WriteLinkAction"/> that destroys links (including link objects).
    /// </summary>
    [Class(IsAbstract = false, IsActive = false, Specializations = "")]
    public interface DestroyLinkAction : WriteLinkAction
    {
        /// <summary>
        /// The <see cref="LinkEndData"/> that the values of the <see cref="Association"/> ends for the links to be destroyed.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 2, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.Composite, SubsettedProperty = "", RedefinedProperty = "LinkAction.EndData")]
        OwnerList<LinkEndDestructionData> EndData { get; set; }
    }
}