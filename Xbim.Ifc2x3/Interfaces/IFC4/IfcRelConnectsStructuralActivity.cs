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
namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	public partial class @IfcRelConnectsStructuralActivity : IIfcRelConnectsStructuralActivity
	{
		IIfcStructuralActivityAssignmentSelect IIfcRelConnectsStructuralActivity.RelatingElement 
		{ 
			get
			{
				if (RelatingElement == null) return null;
				var ifcstructuralitem = RelatingElement as IfcStructuralItem;
				if (ifcstructuralitem != null) 
					return ifcstructuralitem;
				var ifcelement = RelatingElement as ProductExtension.IfcElement;
				if (ifcelement != null) 
					return ifcelement;
				return null;
			} 
			set
			{
				if (value == null)
				{
					RelatingElement = null;
					return;
				}	
				var ifcelement = value as ProductExtension.IfcElement;
				if (ifcelement != null) 
				{
					RelatingElement = ifcelement;
					return;
				}
				var ifcstructuralitem = value as IfcStructuralItem;
				if (ifcstructuralitem != null) 
				{
					RelatingElement = ifcstructuralitem;
					return;
				}
				
			}
		}
		IIfcStructuralActivity IIfcRelConnectsStructuralActivity.RelatedStructuralActivity 
		{ 
			get
			{
				return RelatedStructuralActivity;
			} 
			set
			{
				RelatedStructuralActivity = value as IfcStructuralActivity;
				
			}
		}
	//## Custom code
	//##
	}
}