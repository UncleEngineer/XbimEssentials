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
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcRelCoversSpaces : IIfcRelCoversSpaces
	{
		IIfcSpace IIfcRelCoversSpaces.RelatingSpace 
		{ 
			get
			{
				return RelatedSpace;
			} 
			set
			{
				RelatedSpace = value as IfcSpace;
				
			}
		}
		IItemSet<IIfcCovering> IIfcRelCoversSpaces.RelatedCoverings 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcCovering, IIfcCovering>(RelatedCoverings);
			} 
		}
	//## Custom code
	//##
	}
}