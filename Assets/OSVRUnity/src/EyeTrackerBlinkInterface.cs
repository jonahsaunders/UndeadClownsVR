/// OSVR-Unity Connection
///
/// http://sensics.com/osvr
///
/// <copyright>
/// Copyright 2014 Sensics, Inc.
///
/// Licensed under the Apache License, Version 2.0 (the "License");
/// you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at
///
///     http://www.apache.org/licenses/LICENSE-2.0
///
/// Unless required by applicable law or agreed to in writing, software
/// distributed under the License is distributed on an "AS IS" BASIS,
/// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
/// See the License for the specific language governing permissions and
/// limitations under the License.
/// </copyright>

using UnityEngine;
using System;

namespace OSVR
{
    namespace Unity
    {
        /// <summary>
        /// Eye tracker blink Interface - exposes an OSVR eye blink interface to other scene objects.
        ///
        /// Attach to a GameObject that is interested in eye blink state or events.
        /// </summary>
        public class EyeTrackerBlinkInterface : InterfaceGameObjectBase
        {
            private OSVR.ClientKit.EyeTrackerBlinkInterface iface;
            public OSVR.ClientKit.EyeTrackerBlinkInterface Interface
            {
                get
                {
                    this.Start();
                    return iface;
                }
            }

            override protected void Start()
            {
                base.Start();
                if (iface == null && !String.IsNullOrEmpty(usedPath))
                {
                    iface = OSVR.ClientKit.EyeTrackerBlinkInterface.GetInterface(
                        ClientKit.instance.context, usedPath);
                }
            }

            protected override void Stop()
            {
                base.Stop();
                if (iface != null)
                {
                    iface.Dispose();
                    iface = null;
                }
            }
        }
    }
}
