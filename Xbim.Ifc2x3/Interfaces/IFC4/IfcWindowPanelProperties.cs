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

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class @IfcWindowPanelProperties : IIfcWindowPanelProperties
	{
		Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelOperationEnum IIfcWindowPanelProperties.OperationType 
		{ 
			get
			{
				switch (OperationType)
				{
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelOperationEnum.SIDEHUNGRIGHTHAND:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelOperationEnum.SIDEHUNGRIGHTHAND;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelOperationEnum.SIDEHUNGLEFTHAND:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelOperationEnum.SIDEHUNGLEFTHAND;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelOperationEnum.TILTANDTURNRIGHTHAND:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelOperationEnum.TILTANDTURNRIGHTHAND;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelOperationEnum.TILTANDTURNLEFTHAND:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelOperationEnum.TILTANDTURNLEFTHAND;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelOperationEnum.TOPHUNG:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelOperationEnum.TOPHUNG;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelOperationEnum.BOTTOMHUNG:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelOperationEnum.BOTTOMHUNG;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelOperationEnum.PIVOTHORIZONTAL:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelOperationEnum.PIVOTHORIZONTAL;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelOperationEnum.PIVOTVERTICAL:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelOperationEnum.PIVOTVERTICAL;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelOperationEnum.SLIDINGHORIZONTAL:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelOperationEnum.SLIDINGHORIZONTAL;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelOperationEnum.SLIDINGVERTICAL:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelOperationEnum.SLIDINGVERTICAL;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelOperationEnum.REMOVABLECASEMENT:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelOperationEnum.REMOVABLECASEMENT;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelOperationEnum.FIXEDCASEMENT:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelOperationEnum.FIXEDCASEMENT;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelOperationEnum.OTHEROPERATION:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelOperationEnum.OTHEROPERATION;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelOperationEnum.NOTDEFINED:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelOperationEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelPositionEnum IIfcWindowPanelProperties.PanelPosition 
		{ 
			get
			{
				switch (PanelPosition)
				{
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelPositionEnum.LEFT:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelPositionEnum.LEFT;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelPositionEnum.MIDDLE:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelPositionEnum.MIDDLE;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelPositionEnum.RIGHT:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelPositionEnum.RIGHT;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelPositionEnum.BOTTOM:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelPositionEnum.BOTTOM;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelPositionEnum.TOP:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelPositionEnum.TOP;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcWindowPanelPositionEnum.NOTDEFINED:
						return Xbim.Ifc4.ArchitectureDomain.IfcWindowPanelPositionEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcWindowPanelProperties.FrameDepth 
		{ 
			get
			{
				if (FrameDepth == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)FrameDepth);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcWindowPanelProperties.FrameThickness 
		{ 
			get
			{
				if (FrameThickness == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)FrameThickness);
			} 
		}
		IIfcShapeAspect IIfcWindowPanelProperties.ShapeAspectStyle 
		{ 
			get
			{
				return ShapeAspectStyle as IIfcShapeAspect;
			} 
		}
	}
}