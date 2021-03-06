﻿// -------------------------------------------------------------------------------------------------
// <copyright file="LinkEndCreationData.cs" company="RHEA System S.A.">
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
    /// <see cref="LinkEndCreationData"/> is <see cref="LinkEndData"/> used to provide values for one end of a link to be created by a <see cref="CreateLinkAction"/>.
    /// </summary>
    internal class LinkEndCreationData : Implementation.CommonStructure.Element //, Uml.Actions.LinkEndCreationData
    {
        public LinkEndCreationData(string id) : base(id)
        {
        }
    }
}