﻿// -------------------------------------------------------------------------------------------------
// <copyright file="LinkEndData.cs" company="RHEA System S.A.">
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

namespace Implementation.Actions
{
    using Uml.CommonStructure;

    /// <summary>
    /// <see cref="LinkEndData"/> is an <see cref="Element"/> that identifies on end of a link to be read or written by a <see cref="LinkAction"/>. As a link (that is not a link object) cannot be passed as a runtime value to or from an <see cref="Action"/>, it is instead identified by its end objects and qualifier values, if any. A <see cref="LinkEndData"/> instance provides these values for a single <see cref="Association"/> end.
    /// </summary>
    internal class LinkEndData : Implementation.CommonStructure.Element //, Uml.Actions.LinkEndData
    {
        public LinkEndData(string id) : base(id)
        {
        }
    }
}