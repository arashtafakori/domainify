﻿using System.Globalization;

namespace Domainify.Domain
{
    /// <summary>
    /// Represents a fault that occurs when the start date of an entity is later than the end date during validation.
    /// </summary>
    public class StartDateCanNotBeLaterThanEndDateFault : ValidationFault
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartDateCanNotBeLaterThanEndDateFault"/> class
        /// with the specified entity name and description.
        /// </summary>
        /// <param name="entityName">The name of the entity for which the start date is later than the end date.</param>
        /// <param name="description">A custom description for the invariant fault (optional).</param>
        public StartDateCanNotBeLaterThanEndDateFault(
            string entityName = "", string description = "") :
            base (outerDescription: description,
                innerDescription: string.Format(CultureInfo.CurrentCulture,
                "The start date of the {0} entity can not be later than the end date.",
                entityName))
        {
        }
    }
}
