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
namespace Xbim.Ifc2x3.TopologyResource
{
	public partial class @IfcEdgeLoop : IIfcEdgeLoop
	{
		IItemSet<IIfcOrientedEdge> IIfcEdgeLoop.EdgeList 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcOrientedEdge, IIfcOrientedEdge>(EdgeList);
			} 
		}
		Ifc4.MeasureResource.IfcInteger IIfcEdgeLoop.Ne 
		{
			get 
			{
				return new Ifc4.MeasureResource.IfcInteger(Ne);
			}
		}

	//## Custom code
	//##
	}
}