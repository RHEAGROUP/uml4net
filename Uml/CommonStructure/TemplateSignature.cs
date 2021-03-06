﻿// -------------------------------------------------------------------------------------------------
// <copyright file="TemplateSignature.cs" company="RHEA System S.A.">
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
    using Uml.Assembler;
    using Uml.Attributes;
    using Uml.Classification;

    /// <summary>
    /// A Template Signature bundles the set of formal <see cref="TemplateParameter"/>s for a template.
    /// </summary>
    [Class(IsAbstract = false, IsActive = false, Specializations = "RedefinableTemplateSignature")]
    public interface TemplateSignature : Element
    {
        /// <summary>
        /// The formal parameters that are owned by this <see cref="TemplateSignature"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = true, IsUnique = true, Lower = 0, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.Composite, SubsettedProperty = "Element.OwnedElement|TemplateSignature.Parameter", RedefinedProperty = "")]
        OwnerList<TemplateParameter> OwnedParameter { get; set; }

        /// <summary>
        /// The ordered set of all formal <see cref="TemplateParameter"/>s for this <see cref="TemplateSignature"/>.
        /// </summary>
        [MultiplicityElement(IsOrdered = true, IsUnique = true, Lower = 1, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        List<TemplateParameter> Parameter { get; set; }

        /// <summary>
        /// The <see cref="TemplateableElement"/> that owns this <see cref="TemplateSignature"/>.
        /// </summary>
        /// <remarks>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "Element.Owner", RedefinedProperty = "")]
        TemplateableElement Template { get; set; }
    }
}