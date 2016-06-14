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
	public partial class @IfcSwitchingDeviceType : IIfcSwitchingDeviceType
	{
		Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum IIfcSwitchingDeviceType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcSwitchingDeviceTypeEnum.CONTACTOR:
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.CONTACTOR;
					
					case IfcSwitchingDeviceTypeEnum.EMERGENCYSTOP:
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.EMERGENCYSTOP;
					
					case IfcSwitchingDeviceTypeEnum.STARTER:
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.STARTER;
					
					case IfcSwitchingDeviceTypeEnum.SWITCHDISCONNECTOR:
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.SWITCHDISCONNECTOR;
					
					case IfcSwitchingDeviceTypeEnum.TOGGLESWITCH:
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.TOGGLESWITCH;
					
					case IfcSwitchingDeviceTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.USERDEFINED;
					
					case IfcSwitchingDeviceTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.NOTDEFINED;
					
					
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
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.CONTACTOR:
						PredefinedType = IfcSwitchingDeviceTypeEnum.CONTACTOR;
						return;
					
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.DIMMERSWITCH:
						//## Handle setting of DIMMERSWITCH member from IfcSwitchingDeviceTypeEnum in property PredefinedType
						//TODO: Handle setting of DIMMERSWITCH member from IfcSwitchingDeviceTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.EMERGENCYSTOP:
						PredefinedType = IfcSwitchingDeviceTypeEnum.EMERGENCYSTOP;
						return;
					
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.KEYPAD:
						//## Handle setting of KEYPAD member from IfcSwitchingDeviceTypeEnum in property PredefinedType
						//TODO: Handle setting of KEYPAD member from IfcSwitchingDeviceTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.MOMENTARYSWITCH:
						//## Handle setting of MOMENTARYSWITCH member from IfcSwitchingDeviceTypeEnum in property PredefinedType
						//TODO: Handle setting of MOMENTARYSWITCH member from IfcSwitchingDeviceTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.SELECTORSWITCH:
						//## Handle setting of SELECTORSWITCH member from IfcSwitchingDeviceTypeEnum in property PredefinedType
						//TODO: Handle setting of SELECTORSWITCH member from IfcSwitchingDeviceTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
										
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.STARTER:
						PredefinedType = IfcSwitchingDeviceTypeEnum.STARTER;
						return;
					
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.SWITCHDISCONNECTOR:
						PredefinedType = IfcSwitchingDeviceTypeEnum.SWITCHDISCONNECTOR;
						return;
					
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.TOGGLESWITCH:
						PredefinedType = IfcSwitchingDeviceTypeEnum.TOGGLESWITCH;
						return;
					
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.USERDEFINED:
						PredefinedType = IfcSwitchingDeviceTypeEnum.USERDEFINED;
						return;
					
					case Ifc4.Interfaces.IfcSwitchingDeviceTypeEnum.NOTDEFINED:
						PredefinedType = IfcSwitchingDeviceTypeEnum.NOTDEFINED;
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