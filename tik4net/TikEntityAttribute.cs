﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tik4Net
{
    /// <summary>
    /// Attribute that should decorates <see cref="ITikEntity"/> implementor class.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class TikEntityAttribute: Attribute
    {
        /// <summary>
        /// Gets the entity path in API notation (/ip/firewall/mangle).
        /// </summary>
        /// <value>The entity path.</value>
        public string EntityPath { get; private set; }

        /// <summary>
        /// Gets the entity edit mode.
        /// </summary>
        /// <value>The edit mode.</value>
        public TikEntityEditMode EditMode { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TikEntityAttribute"/> class.
        /// </summary>
        /// <param name="entityPath">The entity path in API notation (/ip/firewall/mangle).</param>
        /// <param name="editMode">The entity edit mode.</param>
        public TikEntityAttribute(string entityPath, TikEntityEditMode editMode)
        {
            Guard.ArgumentNotNullOrEmptyString(entityPath, "entityPath");
            EntityPath = entityPath;
            EditMode = editMode;
        }
    }
}
