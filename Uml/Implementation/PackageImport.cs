﻿// -------------------------------------------------------------------------------------------------
// <copyright file="PackageImport.cs" company="RHEA System S.A.">
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
//   along with Foobar.  If not, see<http://www.gnu.org/licenses/>.
// </copyright>
// -------------------------------------------------------------------------------------------------

namespace Implementation.CommonStructure
{
    using Uml.CommonStructure;

    /// <summary>
    /// A <see cref="PackageImport"/> is a <see cref="Relationship"/> that imports all the non-private members of a <see cref="Package"/> into the Namespace owning the <see cref="PackageImport"/>, so that those <see cref="Element"/>s may be referred to by their unqualified names in the importingNamespace.
    /// </summary>
    internal class PackageImport : Element, Uml.CommonStructure.PackageImport
    {
    }
}