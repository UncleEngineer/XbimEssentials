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
namespace Xbim.Ifc2x3.PropertyResource
{
	public partial class @IfcPropertyDependencyRelationship : IIfcPropertyDependencyRelationship
	{
		IIfcProperty IIfcPropertyDependencyRelationship.DependingProperty 
		{ 
			get
			{
				return DependingProperty;
			} 
			set
			{
				DependingProperty = value as IfcProperty;
				
			}
		}
		IIfcProperty IIfcPropertyDependencyRelationship.DependantProperty 
		{ 
			get
			{
				return DependantProperty;
			} 
			set
			{
				DependantProperty = value as IfcProperty;
				
			}
		}
		Ifc4.MeasureResource.IfcText? IIfcPropertyDependencyRelationship.Expression 
		{ 
			get
			{
				if (!Expression.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Expression.Value);
			} 
			set
			{
				Expression = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcResourceLevelRelationship.Name 
		{ 
			get
			{
				if (!Name.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Name.Value);
			} 
			set
			{
				Name = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcText? IIfcResourceLevelRelationship.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
			set
			{
				Description = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}
	//## Custom code
	//##
	}
}