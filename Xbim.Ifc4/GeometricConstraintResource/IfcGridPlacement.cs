// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricConstraintResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcGridPlacement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcGridPlacement : IIfcObjectPlacement
	{
		IIfcVirtualGridIntersection @PlacementLocation { get; }
		IfcGridPlacementDirectionSelect @PlacementRefDirection { get; }
		
	}
}

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[ExpressType("IFCGRIDPLACEMENT", 698)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGridPlacement : IfcObjectPlacement, IInstantiableEntity, IIfcGridPlacement, IEqualityComparer<@IfcGridPlacement>, IEquatable<@IfcGridPlacement>
	{
		#region IIfcGridPlacement explicit implementation
		IIfcVirtualGridIntersection IIfcGridPlacement.PlacementLocation { get { return @PlacementLocation; } }	
		IfcGridPlacementDirectionSelect IIfcGridPlacement.PlacementRefDirection { get { return @PlacementRefDirection; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGridPlacement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcVirtualGridIntersection _placementLocation;
		private IfcGridPlacementDirectionSelect _placementRefDirection;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcVirtualGridIntersection @PlacementLocation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _placementLocation;
				((IPersistEntity)this).Activate(false);
				return _placementLocation;
			} 
			set
			{
				SetValue( v =>  _placementLocation = v, _placementLocation, value,  "PlacementLocation");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcGridPlacementDirectionSelect @PlacementRefDirection 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _placementRefDirection;
				((IPersistEntity)this).Activate(false);
				return _placementRefDirection;
			} 
			set
			{
				SetValue( v =>  _placementRefDirection = v, _placementRefDirection, value,  "PlacementRefDirection");
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_placementLocation = (IfcVirtualGridIntersection)(value.EntityVal);
					return;
				case 1: 
					_placementRefDirection = (IfcGridPlacementDirectionSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcGridPlacement other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcGridPlacement
            var root = (@IfcGridPlacement)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcGridPlacement left, @IfcGridPlacement right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcGridPlacement left, @IfcGridPlacement right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcGridPlacement x, @IfcGridPlacement y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcGridPlacement obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}