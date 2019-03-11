﻿// -------------------------------------------------------------------------------------------------
// <copyright file="AddVariableValueAction.cs" company="RHEA System S.A.">
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
    using Uml.Activities;
    using Uml.Assembler;
    using Uml.Attributes;
    using Uml.Classification;

    /// <summary>
    /// An <see cref="AddVariableValueAction"/> is a <see cref="WriteVariableAction"/> for adding values to a Variable.
    /// </summary>
    [Class(IsAbstract = false, IsActive = false, Specializations = "")]
    public interface AddVariableValueAction : WriteVariableAction
    {
        /// <summary>
        /// The <see cref="InputPin"/> that gives the position at which to insert a new value or move an existing value in ordered Variables. The type of the insertAt <see cref="InputPin"/> is UnlimitedNatural, but the value cannot be zero. It is omitted for unordered Variables.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.Composite, SubsettedProperty = "Action.Input", RedefinedProperty = "")]
        OwnerList<InputPin> InsertAt { get; set; }

        /// <summary>
        /// Specifies whether existing values of the <see cref="Variable"/> should be removed before adding the new value.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        bool IsReplaceAll { get; set; }
    }
}