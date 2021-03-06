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

using Grasshopper.Kernel.Types;
using SustainabilityOpen.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SustainabilityOpen.Grasshopper
{
    public class SOAssessment_GHData : GH_Goo<SOAssessment>
    {
        public SOAssessment_GHData() { }
        public SOAssessment_GHData(SOAssessment assessment)
            : base(assessment)
        {
        }
        public override IGH_Goo Duplicate()
        {
            SOAssessment assessment = new SOAssessment("");
            return new SOAssessment_GHData(assessment);
        }
        public override bool IsValid
        {
            get { return true; }
        }
        public override string ToString()
        {
            return "SustainabilityOpen Assessment parameter";
        }
        public override string TypeDescription
        {
            get { return "Holds the information of an assessment"; }
        }
        public override string TypeName
        {
            get { return "Assessment"; }
        }
    }
}
