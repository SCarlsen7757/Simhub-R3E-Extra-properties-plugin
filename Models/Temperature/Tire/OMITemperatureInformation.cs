﻿using SimHub.Plugins;
using Simhub_R3E_Tyre_and_brake_color_plugin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simhub_R3E_Tyre_and_brake_color_plugin.Models
{
    public class OMITemperatureInformation : Prefix, ISimhubProperty
    {
        public OMITemperatureInformation()
            : base()
        {
            this.Outer = new R3ETemperatureColor(this._prefix, nameof(this.Outer));
            this.Middle = new R3ETemperatureColor(this._prefix, nameof(this.Middle));
            this.Inner = new R3ETemperatureColor(this._prefix, nameof(this.Inner));
        }
        public OMITemperatureInformation(List<string> prefixList)
            : base(prefixList)
        {
            this.Outer = new R3ETemperatureColor(this._prefix, nameof(this.Outer));
            this.Middle = new R3ETemperatureColor(this._prefix, nameof(this.Middle));
            this.Inner = new R3ETemperatureColor(this._prefix, nameof(this.Inner));
        }
        public R3ETemperatureColor Outer { get; set; }
        public R3ETemperatureColor Middle { get; set; }
        public R3ETemperatureColor Inner { get; set;}

        public void AddProperty(PluginManager pluginManager)
        {
            Outer.AddColorProperty(pluginManager);
            Middle.AddColorProperty(pluginManager);
            Inner.AddColorProperty(pluginManager);
        }
        public void SetProperty(PluginManager pluginManager)
        {
            Outer.SetColorProperty(pluginManager);
            Middle.SetColorProperty(pluginManager);
            Inner.SetColorProperty(pluginManager);
        }
    }
}
