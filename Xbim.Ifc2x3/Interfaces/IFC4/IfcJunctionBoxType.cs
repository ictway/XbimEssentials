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
	public partial class @IfcJunctionBoxType : IIfcJunctionBoxType
	{
		Ifc4.Interfaces.IfcJunctionBoxTypeEnum IIfcJunctionBoxType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcJunctionBoxTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcJunctionBoxTypeEnum.USERDEFINED;
					
					case IfcJunctionBoxTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcJunctionBoxTypeEnum.NOTDEFINED;
					
					
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
					case Ifc4.Interfaces.IfcJunctionBoxTypeEnum.DATA:
						//## Handle setting of DATA member from IfcJunctionBoxTypeEnum in property PredefinedType
						//TODO: Handle setting of DATA member from IfcJunctionBoxTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcJunctionBoxTypeEnum.POWER:
						//## Handle setting of POWER member from IfcJunctionBoxTypeEnum in property PredefinedType
						//TODO: Handle setting of POWER member from IfcJunctionBoxTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcJunctionBoxTypeEnum.USERDEFINED:
						PredefinedType = IfcJunctionBoxTypeEnum.USERDEFINED;
						return;
					
					case Ifc4.Interfaces.IfcJunctionBoxTypeEnum.NOTDEFINED:
						PredefinedType = IfcJunctionBoxTypeEnum.NOTDEFINED;
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