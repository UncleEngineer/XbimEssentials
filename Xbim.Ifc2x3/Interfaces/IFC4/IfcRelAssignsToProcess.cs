// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.Kernel
{
	public partial class @IfcRelAssignsToProcess : IIfcRelAssignsToProcess
	{

		private  IIfcProcessSelect _relatingProcess4;

		IIfcProcessSelect IIfcRelAssignsToProcess.RelatingProcess 
		{ 
			get
			{
				return  _relatingProcess4 ?? RelatingProcess;
			} 
			set
			{
				if (value == null)
				{
					RelatingProcess = null;
					if (_relatingProcess4 != null)
						SetValue(v => _relatingProcess4 = v, _relatingProcess4, null, "RelatingProcess", byte.MaxValue);
					return;
				}
				
				var val = value as IfcProcess;
				if (val != null)
				{
					RelatingProcess = val;
					if (_relatingProcess4 != null)
						SetValue(v => _relatingProcess4 = v, _relatingProcess4, null, "RelatingProcess", byte.MaxValue);
					return;
				} 

				if(RelatingProcess != null)
					RelatingProcess = null;
				SetValue(v => _relatingProcess4 = v, _relatingProcess4, value, "RelatingProcess", byte.MaxValue);
				
			}
		}
		IIfcMeasureWithUnit IIfcRelAssignsToProcess.QuantityInProcess 
		{ 
			get
			{
				return QuantityInProcess;
			} 
			set
			{
				QuantityInProcess = value as MeasureResource.IfcMeasureWithUnit;
				
			}
		}
	//## Custom code
	//##
	}
}