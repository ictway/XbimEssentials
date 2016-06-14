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
namespace Xbim.Ifc2x3.Kernel
{
	public partial class @IfcRelDefinesByProperties : IIfcRelDefinesByProperties
	{
		IItemSet<IIfcObjectDefinition> IIfcRelDefinesByProperties.RelatedObjects 
		{ 
			get
			{
			
				return _relatedObjectsIfc4 ?? (_relatedObjectsIfc4 = new Common.Collections.ExtendedItemSet<IfcObject, IIfcObjectDefinition>(
                    RelatedObjects, 
                    new ItemSet<IIfcObjectDefinition>(this, 0, 255), 
                    RelatedObjectsToIfc4, 
                    RelatedObjectsToIfc2x3));
			} 
		}

		//private field to hold any extended data
		private IItemSet<IIfcObjectDefinition> _relatedObjectsIfc4;

		//transformation function to convert/cast IFC2x3 data to appear as IFC4
		private IIfcObjectDefinition RelatedObjectsToIfc4 (IfcObject member)
		{
			return member;
		}

		//transformation function to convert/cast IFC4 data to appear as IFC2x3 if possible
		private IfcObject RelatedObjectsToIfc2x3 (IIfcObjectDefinition member){
			throw new System.NotImplementedException();
		}

		private  IIfcPropertySetDefinitionSelect _relatingPropertyDefinition4;

		IIfcPropertySetDefinitionSelect IIfcRelDefinesByProperties.RelatingPropertyDefinition 
		{ 
			get
			{
				return  _relatingPropertyDefinition4 ?? RelatingPropertyDefinition;
			} 
			set
			{
				if (value == null)
				{
					RelatingPropertyDefinition = null;
					if (_relatingPropertyDefinition4 != null)
						SetValue(v => _relatingPropertyDefinition4 = v, _relatingPropertyDefinition4, null, "RelatingPropertyDefinition", byte.MaxValue);
					return;
				}
				
				var val = value as IfcPropertySetDefinition;
				if (val != null)
				{
					RelatingPropertyDefinition = val;
					if (_relatingPropertyDefinition4 != null)
						SetValue(v => _relatingPropertyDefinition4 = v, _relatingPropertyDefinition4, null, "RelatingPropertyDefinition", byte.MaxValue);
					return;
				} 

				if(RelatingPropertyDefinition != null)
					RelatingPropertyDefinition = null;
				SetValue(v => _relatingPropertyDefinition4 = v, _relatingPropertyDefinition4, value, "RelatingPropertyDefinition", byte.MaxValue);
				
			}
		}
	//## Custom code
	//##
	}
}