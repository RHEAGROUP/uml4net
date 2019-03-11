﻿// -------------------------------------------------------------------------------------------------
// <copyright file="InformationItem.cs" company="RHEA System S.A.">
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

namespace Uml.InformationFlows
{
    using System.Collections.Generic;
    using Uml.Attributes;
    using Uml.Classification;

    /// <summary>
    /// <see cref="InformationItem"/>s represent many kinds of information that can flow from sources to targets in very abstract ways.  They represent the kinds of information that may move within a system, but do not elaborate details of the transferred information.  Details of transferred information are the province of other <see cref="Classifier"/>s that may ultimately define <see cref="InformationItem"/>s.  Consequently, <see cref="InformationItem"/>s cannot be instantiated and do not themselves have features, generalizations, or associations. An important use of <see cref="InformationItem"/>s is to represent information during early design stages, possibly before the detailed modeling decisions that will ultimately define them have been made. Another purpose of <see cref="InformationItem"/>s is to abstract portions of complex models in less precise, but perhaps more general and communicable, ways. 
    /// </summary>
    [Class(IsAbstract = false, IsActive = false, Specializations = "")]
    public interface InformationItem : Classifier
    {
        /// <summary>
        /// Determines the classifiers that will specify the structure and nature of the information. An information item represents all its represented classifiers.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        List<Classifier> Represented { get; set; }
    }
}