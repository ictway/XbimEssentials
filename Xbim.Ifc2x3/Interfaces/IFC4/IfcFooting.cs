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
namespace Xbim.Ifc2x3.StructuralElementsDomain
{
	public partial class @IfcFooting : IIfcFooting
	{
		Ifc4.Interfaces.IfcFootingTypeEnum? IIfcFooting.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcFootingTypeEnum.FOOTING_BEAM:
						return Ifc4.Interfaces.IfcFootingTypeEnum.FOOTING_BEAM;
					
					case IfcFootingTypeEnum.PAD_FOOTING:
						return Ifc4.Interfaces.IfcFootingTypeEnum.PAD_FOOTING;
					
					case IfcFootingTypeEnum.PILE_CAP:
						return Ifc4.Interfaces.IfcFootingTypeEnum.PILE_CAP;
					
					case IfcFootingTypeEnum.STRIP_FOOTING:
						return Ifc4.Interfaces.IfcFootingTypeEnum.STRIP_FOOTING;
					
					case IfcFootingTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcFootingTypeEnum.USERDEFINED;
					
					case IfcFootingTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcFootingTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcFootingTypeEnum.CAISSON_FOUNDATION:
						//## Handle setting of CAISSON_FOUNDATION member from IfcFootingTypeEnum in property PredefinedType
						//TODO: Handle setting of CAISSON_FOUNDATION member from IfcFootingTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcFootingTypeEnum.FOOTING_BEAM:
						PredefinedType = IfcFootingTypeEnum.FOOTING_BEAM;
						return;
					
					case Ifc4.Interfaces.IfcFootingTypeEnum.PAD_FOOTING:
						PredefinedType = IfcFootingTypeEnum.PAD_FOOTING;
						return;
					
					case Ifc4.Interfaces.IfcFootingTypeEnum.PILE_CAP:
						PredefinedType = IfcFootingTypeEnum.PILE_CAP;
						return;
					
					case Ifc4.Interfaces.IfcFootingTypeEnum.STRIP_FOOTING:
						PredefinedType = IfcFootingTypeEnum.STRIP_FOOTING;
						return;
					
					case Ifc4.Interfaces.IfcFootingTypeEnum.USERDEFINED:
						PredefinedType = IfcFootingTypeEnum.USERDEFINED;
						return;
					
					case Ifc4.Interfaces.IfcFootingTypeEnum.NOTDEFINED:
						PredefinedType = IfcFootingTypeEnum.NOTDEFINED;
						return;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}