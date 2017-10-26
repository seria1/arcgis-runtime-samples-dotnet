﻿// Copyright 2017 Esri.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License.
// You may obtain a copy of the License at: http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an 
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific 
// language governing permissions and limitations under the License.

using Esri.ArcGISRuntime.Mapping;
using System;
using System.Linq;
using Windows.UI.Xaml.Controls;

namespace ArcGISRuntime.UWP.Samples.DynamicWorkspaceShapefile
{
    public partial class DynamicWorkspaceShapefile
    {
        public DynamicWorkspaceShapefile()
        {
            InitializeComponent();

            // Setup the control references and execute initialization 
            Initialize();
        }

        private void Initialize()
        {
        }
    }
}