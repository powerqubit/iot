﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Iot.Device.GrovePiDevice.Models;

namespace Iot.Device.GrovePiDevice.Sensors
{
    public class PotentiometerSensor : AnalogSensor
    {
        /// <summary>
        /// Potentiometer sensor constructor
        /// </summary>
        /// <param name="grovePi">The GrovePi class</param>
        /// <param name="port">The grove Port, need to be in the list of SupportedPorts</param>
        public PotentiometerSensor(GrovePi grovePi, GrovePort port) : base(grovePi, port)
        { }

        /// <summary>
        /// Returns the value as a percent from 0 % to 100 %
        /// </summary>
        /// <returns>Returns the value as a percent from 0 % to 100 %</returns>
        public override string ToString() => $"{ValueAsPercent} %";

        /// <summary>
        /// Get the name Potentiometer Sensor
        /// </summary>
        public new string SensorName => "Potentiometer Sensor";
    }
}
