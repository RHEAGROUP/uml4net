﻿// -------------------------------------------------------------------------------------------------
// <copyright file="AssociationClass.cs" company="RHEA System S.A.">
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

namespace Implementation.StructuredClassifiers
{
    using System;
    using System.Collections.Generic;
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
    /// A model element that has both Association and Class properties. An AssociationClass can be seen as an Association that also has Class properties, or as a Class that also has Association properties. It not only connects a set of Classifiers but also defines a set of Features that belong to the Association itself and not to any of the associated Classifiers.
    /// </summary>
    internal class AssociationClass : Implementation.CommonStructure.Element, Uml.StructuredClassifiers.AssociationClass
    {
        /// <summary>
        /// Initializes a new instance of <see cref="AssociationClass"/>
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the <see cref="AssociationClass"/>
        /// </param>        
        public AssociationClass(string id) : base(id)
        {
            this.NameExpression = new OwnerList<StringExpression>(this);
            this.ElementImport = new OwnerList<ElementImport>(this);
            this.OwnedRule = new OwnerList<Constraint>(this);
            this.PackageImport = new OwnerList<PackageImport>(this);
            this.UseCase = new List<UseCase>();
            this.Substitution = new OwnerList<Substitution>(this);
            this.CollaborationUse = new OwnerList<Uml.StructuredClassifiers.CollaborationUse>(this);
            this.Generalization = new OwnerList<Generalization>(this);
            this.OwnedUseCase = new OwnerList<UseCase>(this);
            this.PowertypeExtent = new List<GeneralizationSet>();
            this.RedefinedClassifier = new List<Classifier>();
            this.TemplateBinding = new OwnerList<TemplateBinding>(this);
            this.MemberEnd = new List<Property>();
            this.NavigableOwnedEnd = new List<Property>();
            this.OwnedEnd = new OwnerList<Property>(this);
        }

        public IEnumerable<Dependency> ClientDependency()
        {
            throw new NotImplementedException();
        }

        public string Name { get; set; }
        
        public OwnerList<StringExpression> NameExpression { get; set; }
        
        public Namespace Namespace()
        {
            throw new NotImplementedException();
        }

        public string QualifiedName()
        {
            throw new NotImplementedException();
        }

        public VisibilityKind Visibility { get; set; }
        
        public OwnerList<ElementImport> ElementImport { get; set; }
        
        public IEnumerable<PackageableElement> ImportedMember()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NamedElement> Member()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NamedElement> OwnedMember()
        {
            throw new NotImplementedException();
        }

        public OwnerList<Constraint> OwnedRule { get; set; }
        
        public OwnerList<PackageImport> PackageImport { get; set; }
        
        public TemplateParameter OwningTemplateParameter { get; set; }
        
        public ClassifierTemplateParameter TemplateParameter { get; set; }
        
        public List<UseCase> UseCase { get; set; }
        
        public OwnerList<Substitution> Substitution { get; set; }

        TemplateParameter ParameterableElement.TemplateParameter
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Package Package { get; set; }
        
        public IEnumerable<Property> Attribute()
        {
            throw new NotImplementedException();
        }

        public OwnerList<Uml.StructuredClassifiers.CollaborationUse> CollaborationUse { get; set; }
        
        public IEnumerable<Feature> Feature()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Classifier> General()
        {
            throw new NotImplementedException();
        }

        public OwnerList<Generalization> Generalization { get; set; }
        
        public IEnumerable<NamedElement> InheritedMember()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Extension> Extension()
        {
            throw new NotImplementedException();
        }

        public bool IsAbstract { get; set; }
        
        public bool IsActive { get; set; }
        
        public OwnerList<Classifier> NestedClassifier { get; set; }
        
        public bool IsFinalSpecialization { get; set; }

        OwnerList<RedefinableTemplateSignature> Classifier.OwnedTemplateSignature
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public OwnerList<UseCase> OwnedUseCase { get; set; }
        
        public List<GeneralizationSet> PowertypeExtent { get; set; }
        
        public List<Classifier> RedefinedClassifier { get; set; }
        
        public Uml.StructuredClassifiers.CollaborationUse Representation { get; set; }

        OwnerList<TemplateSignature> TemplateableElement.OwnedTemplateSignature
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public OwnerList<TemplateBinding> TemplateBinding { get; set; }
        
        public bool IsLeaf { get; set; }
        
        public IEnumerable<RedefinableElement> RedefinedElement()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Classifier> RedefinitionContext()
        {
            throw new NotImplementedException();
        }

        public Behavior ClassifierBehavior { get; set; }
        
        public InterfaceRealization InterfaceRealization { get; set; }
        
        public OwnerList<Behavior> OwnedBehavior { get; set; }
        
        public OwnerList<Property> OwnedAttribute { get; set; }
        
        public OwnerList<Operation> OwnedOperation { get; set; }
        
        public OwnerList<Reception> OwnedReception { get; set; }
        
        public IEnumerable<Uml.StructuredClassifiers.Class> SuperClass()
        {
            throw new NotImplementedException();
        }

        public OwnerList<Uml.StructuredClassifiers.Connector> OwnedConnector { get; set; }
        
        public IEnumerable<Property> Part()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ConnectableElement> Role()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Uml.StructuredClassifiers.Port> OwnedPort()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Element> RelatedElement()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Uml.CommonStructure.Type> EndType()
        {
            throw new NotImplementedException();
        }

        public bool IsDerived { get; set; }
        
        public List<Property> MemberEnd { get; set; }
        
        public List<Property> NavigableOwnedEnd { get; set; }
        
        public OwnerList<Property> OwnedEnd { get; set; }
    }
}