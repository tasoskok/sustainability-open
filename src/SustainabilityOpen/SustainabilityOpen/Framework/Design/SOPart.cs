﻿/// Copyright 2012-2013 Delft University of Technology, BEMNext Lab and contributors
/// 
///    Licensed under the Apache License, Version 2.0 (the "License");
///    you may not use this file except in compliance with the License.
///    You may obtain a copy of the License at
/// 
///        http://www.apache.org/licenses/LICENSE-2.0
/// 
///    Unless required by applicable law or agreed to in writing, software
///    distributed under the License is distributed on an "AS IS" BASIS,
///    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
///    See the License for the specific language governing permissions and
///    limitations under the License.
/// 

using SustainabilityOpen.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SustainabilityOpen.Framework.Design
{
    /// <summary>
    /// Part of a component
    /// A part consists of a single material
    /// </summary>
    public class SOPart : SOPhysicalObject
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of the part</param>
        /// <param name="material">Material</param>
        /// <param name="quantity">Quantity of the material</param>
        /// <param name="unit">Unit to measure the quantity</param>
        public SOPart(string name, SOMaterial material, double quantity, string unit)
            : base(name, material, quantity, unit)
        {
        }
    }
}
