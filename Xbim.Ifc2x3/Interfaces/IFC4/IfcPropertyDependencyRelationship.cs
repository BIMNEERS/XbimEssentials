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
namespace Xbim.Ifc2x3.PropertyResource
{
	public partial class @IfcPropertyDependencyRelationship : IIfcPropertyDependencyRelationship
	{
		IIfcProperty IIfcPropertyDependencyRelationship.DependingProperty 
		{ 
			get
			{
				return DependingProperty as IIfcProperty;
			} 
		}
		IIfcProperty IIfcPropertyDependencyRelationship.DependantProperty 
		{ 
			get
			{
				return DependantProperty as IIfcProperty;
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcText? IIfcPropertyDependencyRelationship.Expression 
		{ 
			get
			{
				if (Expression == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcText((string)Expression);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLabel? IIfcResourceLevelRelationship.Name 
		{ 
			get
			{
				//TODO: Handle return of Name for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcText? IIfcResourceLevelRelationship.Description 
		{ 
			get
			{
				//TODO: Handle return of Description for which no match was found
				throw new System.NotImplementedException();
			} 
		}
	}
}