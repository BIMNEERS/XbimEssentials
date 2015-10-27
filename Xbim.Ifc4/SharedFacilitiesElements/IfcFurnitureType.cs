// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProductExtension;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.SharedFacilitiesElements;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcFurnitureType
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcFurnitureType : IIfcFurnishingElementType
	{
		IfcAssemblyPlaceEnum @AssemblyPlace { get; }
		IfcFurnitureTypeEnum? @PredefinedType { get; }
		
	}
}

namespace Xbim.Ifc4.SharedFacilitiesElements
{
	[ExpressType("IFCFURNITURETYPE", 688)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFurnitureType : IfcFurnishingElementType, IInstantiableEntity, IIfcFurnitureType, IEqualityComparer<@IfcFurnitureType>, IEquatable<@IfcFurnitureType>
	{
		#region IIfcFurnitureType explicit implementation
		IfcAssemblyPlaceEnum IIfcFurnitureType.AssemblyPlace { get { return @AssemblyPlace; } }	
		IfcFurnitureTypeEnum? IIfcFurnitureType.PredefinedType { get { return @PredefinedType; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFurnitureType(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAssemblyPlaceEnum _assemblyPlace;
		private IfcFurnitureTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcAssemblyPlaceEnum @AssemblyPlace 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _assemblyPlace;
				((IPersistEntity)this).Activate(false);
				return _assemblyPlace;
			} 
			set
			{
				SetValue( v =>  _assemblyPlace = v, _assemblyPlace, value,  "AssemblyPlace");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcFurnitureTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
                    _assemblyPlace = (IfcAssemblyPlaceEnum) System.Enum.Parse(typeof (IfcAssemblyPlaceEnum), value.EnumVal, true);
					return;
				case 10: 
                    _predefinedType = (IfcFurnitureTypeEnum) System.Enum.Parse(typeof (IfcFurnitureTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:                              ((PredefinedType = IfcFurnitureTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcElementType.ElementType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcFurnitureType other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcFurnitureType
            var root = (@IfcFurnitureType)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcFurnitureType left, @IfcFurnitureType right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcFurnitureType left, @IfcFurnitureType right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcFurnitureType x, @IfcFurnitureType y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcFurnitureType obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}