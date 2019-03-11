﻿// -------------------------------------------------------------------------------------------------
// <copyright file="InvocationAction.cs" company="RHEA System S.A.">
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
    using Uml.StructuredClassifiers;
    using Uml.Assembler;
    using Uml.Attributes;
    using Uml.Classification;

    /// <summary>
    /// <see cref="InvocationAction"/> is an abstract class for the various actions that request <see cref="Behavior"/> invocation.
    /// </summary>
    [Class(IsAbstract = true, IsActive = false, Specializations = "BroadcastSignalAction|CallAction|SendObjectAction|SendSignalAction")]
    public interface InvocationAction : Action
    {
        /// <summary>
        /// The <see cref="InputPin"/>s that provide the argument values passed in the invocation request.
        /// </summary>
        [MultiplicityElement(IsOrdered = true, IsUnique = true, Lower = 0, Upper = "*")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.Composite, SubsettedProperty = "Action.Input", RedefinedProperty = "")]
        OwnerList<InputPin> Argument { get; set; }

        /// <summary>
        /// For <see cref="CallOperationAction"/>s, <see cref="SendSignalAction"/>s, and <see cref="SendObjectAction"/>s, an optional <see cref="Port"/> of the target object through which the invocation request is sent.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 0, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        Port OnPort { get; set; }
    }
}