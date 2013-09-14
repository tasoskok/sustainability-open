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

// This file implements a steel HE200A beam

// Note the inclusion of the framework in the reference
using SustainabilityOpen.Framework;
using SustainabilityOpen.Framework.Design;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// The namespace can be whatever you want it to be
namespace SimpleComponentsExample
{
    /// <summary>
    /// Class overrides the SOPart class
    /// </summary>
    public class Beam_HE200A : SOPart
    {
        /// <summary>
        /// Constructor
        /// Note the name of the part you will need to pass to the base class.
        ///  Also note the material quantity of the beam of 1 m3 of the material steel.
        /// </summary>
        public Beam_HE200A()
            : base("HE200A", new SOMaterial("steel"), 1, "m3")
        {
        }

    }
}