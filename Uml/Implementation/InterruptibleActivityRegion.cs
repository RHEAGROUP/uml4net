﻿// -------------------------------------------------------------------------------------------------
// <copyright file="InterruptibleActivityRegion.cs" company="RHEA System S.A.">
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
    using Uml.CommonStructure;

    /// <summary>
    /// An <see cref="InterruptibleActivityRegion"/> is an <see cref="ActivityGroup"/> that supports the termination of tokens flowing in the portions of an activity within it.
    /// </summary>
    internal class InterruptibleActivityRegion : Implementation.CommonStructure.Element //, Uml.Activities.InterruptibleActivityRegion
    {
        public InterruptibleActivityRegion(string id) : base(id)
        {
        }
    }
}
