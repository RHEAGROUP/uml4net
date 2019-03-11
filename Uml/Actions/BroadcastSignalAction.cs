﻿// -------------------------------------------------------------------------------------------------
// <copyright file="BroadcastSignalAction.cs" company="RHEA System S.A.">
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
    using Uml.Attributes;
    using Uml.Classification;
    using Uml.SimpleClassifiers;

    /// <summary>
    /// A <see cref="BroadcastSignalAction"/> is an <see cref="InvocationAction"/> that transmits a Signal instance to all the potential target objects in the system. Values from the argument <see cref="InputPin"/>s are used to provide values for the attributes of the <see cref="Signal"/>. The requestor continues execution immediately after the <see cref="Signal"/> instances are sent out and cannot receive reply values.
    /// </summary>
    [Class(IsAbstract = false, IsActive = false, Specializations = "")]
    public interface BroadcastSignalAction : InvocationAction
    {
        /// <summary>
        /// The <see cref="Signal"/> whose instances are to be sent.
        /// </summary>
        [MultiplicityElement(IsOrdered = false, IsUnique = true, Lower = 1, Upper = "1")]
        [Property(IsDerived = false, IsDerivedUnion = false, IsReadOnly = false, IsStatic = false, Aggregation = AggregationKind.None, SubsettedProperty = "", RedefinedProperty = "")]
        Signal Signal { get; set; }
    }
}