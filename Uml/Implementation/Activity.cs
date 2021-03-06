﻿// -------------------------------------------------------------------------------------------------
// <copyright file="Activity.cs" company="RHEA System S.A.">
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

namespace Implementation.Activities
{
    using System.Collections.Generic;
    using Uml.Actions;
    using Uml.Activities;
    using Uml.Assembler;
    using Uml.Classification;
    using Uml.CommonBehavior;
    using Uml.CommonStructure;
    using Uml.Packages;
    using Uml.SimpleClassifiers;
    using Uml.StructuredClassifiers;
    using Uml.UseCases;
    using Uml.Values;

    /// <summary>
    /// An <see cref="Activity"/> is the specification of parameterized Behavior as the coordinated sequencing of subordinate units.
    /// </summary>
    internal class Activity : Implementation.CommonStructure.Element //, Uml.Activities.Activity
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Activity"/>
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the <see cref="Activity"/>
        /// </param>
        public Activity(string id) : base(id)
        {
        }
    }
}