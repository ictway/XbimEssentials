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
namespace Xbim.Ifc2x3.ElectricalDomain
{
	public partial class @IfcCableSegmentType : IIfcCableSegmentType
	{
		Ifc4.Interfaces.IfcCableSegmentTypeEnum IIfcCableSegmentType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcCableSegmentTypeEnum.CABLESEGMENT:
						return Ifc4.Interfaces.IfcCableSegmentTypeEnum.CABLESEGMENT;
					
					case IfcCableSegmentTypeEnum.CONDUCTORSEGMENT:
						return Ifc4.Interfaces.IfcCableSegmentTypeEnum.CONDUCTORSEGMENT;
					
					case IfcCableSegmentTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcCableSegmentTypeEnum.USERDEFINED;
					
					case IfcCableSegmentTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcCableSegmentTypeEnum.NOTDEFINED;
					
					
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
					case Ifc4.Interfaces.IfcCableSegmentTypeEnum.BUSBARSEGMENT:
						//## Handle setting of BUSBARSEGMENT member from IfcCableSegmentTypeEnum in property PredefinedType
						//TODO: Handle setting of BUSBARSEGMENT member from IfcCableSegmentTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcCableSegmentTypeEnum.CABLESEGMENT:
						PredefinedType = IfcCableSegmentTypeEnum.CABLESEGMENT;
						return;
					
					case Ifc4.Interfaces.IfcCableSegmentTypeEnum.CONDUCTORSEGMENT:
						PredefinedType = IfcCableSegmentTypeEnum.CONDUCTORSEGMENT;
						return;
					
					case Ifc4.Interfaces.IfcCableSegmentTypeEnum.CORESEGMENT:
						//## Handle setting of CORESEGMENT member from IfcCableSegmentTypeEnum in property PredefinedType
						//TODO: Handle setting of CORESEGMENT member from IfcCableSegmentTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcCableSegmentTypeEnum.USERDEFINED:
						PredefinedType = IfcCableSegmentTypeEnum.USERDEFINED;
						return;
					
					case Ifc4.Interfaces.IfcCableSegmentTypeEnum.NOTDEFINED:
						PredefinedType = IfcCableSegmentTypeEnum.NOTDEFINED;
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