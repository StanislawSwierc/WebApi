﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.Edm;

namespace System.Web.OData.Formatter.Serialization
{
    /// <summary>
    /// Represents an <see cref="IEdmEntityObject"/> backed by a CLR object with a one-to-one mapping.
    /// </summary>
    internal class TypedEdmEntityObject : TypedEdmStructuredObject, IEdmEntityObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypedEdmEntityObject"/> class.
        /// </summary>
        /// <param name="instance">The backing CLR instance.</param>
        /// <param name="edmType">The <see cref="IEdmEntityTypeReference"/> of this object.</param>
        /// <param name="edmModel">The <see cref="IEdmModel"/>.</param>
        public TypedEdmEntityObject(object instance, IEdmEntityTypeReference edmType, IEdmModel edmModel)
            : base(instance, edmType, edmModel)
        {
        }
    }

    internal class GeneratedEdmObject : IEdmEntityObject
    {
        private IEdmGeneratedObject _instance;

        public GeneratedEdmObject(IEdmGeneratedObject instance)
        {

            this._instance = instance;
        }

        public IEdmTypeReference GetEdmType()
        {
            return this._instance.GetEdmType();
        }

        public bool TryGetPropertyValue(string propertyName, out object value)
        {
            return this._instance.TryGetPropertyValue(propertyName, out value);
        }
    }
}