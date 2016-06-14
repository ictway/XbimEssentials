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
namespace Xbim.Ifc2x3.GeometryResource
{
	public partial class @IfcTrimmedCurve : IIfcTrimmedCurve
	{
		IIfcCurve IIfcTrimmedCurve.BasisCurve 
		{ 
			get
			{
				return BasisCurve;
			} 
			set
			{
				BasisCurve = value as IfcCurve;
				
			}
		}
		IItemSet<IIfcTrimmingSelect> IIfcTrimmedCurve.Trim1 
		{ 
			get
			{
			
				return _trim1Ifc4 ?? (_trim1Ifc4 = new Common.Collections.ExtendedItemSet<IfcTrimmingSelect, IIfcTrimmingSelect>(
                    Trim1, 
                    new ItemSet<IIfcTrimmingSelect>(this, 0, 255), 
                    Trim1ToIfc4, 
                    Trim1ToIfc2x3));
			} 
		}

		//private field to hold any extended data
		private IItemSet<IIfcTrimmingSelect> _trim1Ifc4;

		//transformation function to convert/cast IFC2x3 data to appear as IFC4
		private IIfcTrimmingSelect Trim1ToIfc4 (IfcTrimmingSelect member)
		{
			var ifccartesianpoint = member as IfcCartesianPoint;
			if (ifccartesianpoint != null) 
				return ifccartesianpoint;
			if (member is MeasureResource.IfcParameterValue) 
				return new Ifc4.MeasureResource.IfcParameterValue((MeasureResource.IfcParameterValue)member);
			throw new System.NotSupportedException();
		}

		//transformation function to convert/cast IFC4 data to appear as IFC2x3 if possible
		private IfcTrimmingSelect Trim1ToIfc2x3 (IIfcTrimmingSelect member){
			throw new System.NotImplementedException();
		}
		IItemSet<IIfcTrimmingSelect> IIfcTrimmedCurve.Trim2 
		{ 
			get
			{
			
				return _trim2Ifc4 ?? (_trim2Ifc4 = new Common.Collections.ExtendedItemSet<IfcTrimmingSelect, IIfcTrimmingSelect>(
                    Trim2, 
                    new ItemSet<IIfcTrimmingSelect>(this, 0, 255), 
                    Trim2ToIfc4, 
                    Trim2ToIfc2x3));
			} 
		}

		//private field to hold any extended data
		private IItemSet<IIfcTrimmingSelect> _trim2Ifc4;

		//transformation function to convert/cast IFC2x3 data to appear as IFC4
		private IIfcTrimmingSelect Trim2ToIfc4 (IfcTrimmingSelect member)
		{
			var ifccartesianpoint = member as IfcCartesianPoint;
			if (ifccartesianpoint != null) 
				return ifccartesianpoint;
			if (member is MeasureResource.IfcParameterValue) 
				return new Ifc4.MeasureResource.IfcParameterValue((MeasureResource.IfcParameterValue)member);
			throw new System.NotSupportedException();
		}

		//transformation function to convert/cast IFC4 data to appear as IFC2x3 if possible
		private IfcTrimmingSelect Trim2ToIfc2x3 (IIfcTrimmingSelect member){
			throw new System.NotImplementedException();
		}
		Ifc4.MeasureResource.IfcBoolean IIfcTrimmedCurve.SenseAgreement 
		{ 
			get
			{
				//## Handle return of SenseAgreement for which no match was found
			    return new Ifc4.MeasureResource.IfcBoolean(SenseAgreement);
			    //##
			} 
			set
			{
				SenseAgreement = value;
				
			}
		}
		Ifc4.Interfaces.IfcTrimmingPreference IIfcTrimmedCurve.MasterRepresentation 
		{ 
			get
			{
				//## Custom code to handle enumeration of MasterRepresentation
				//##
				switch (MasterRepresentation)
				{
					case IfcTrimmingPreference.CARTESIAN:
						return Ifc4.Interfaces.IfcTrimmingPreference.CARTESIAN;
					
					case IfcTrimmingPreference.PARAMETER:
						return Ifc4.Interfaces.IfcTrimmingPreference.PARAMETER;
					
					case IfcTrimmingPreference.UNSPECIFIED:
						return Ifc4.Interfaces.IfcTrimmingPreference.UNSPECIFIED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of MasterRepresentation
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcTrimmingPreference.CARTESIAN:
						MasterRepresentation = IfcTrimmingPreference.CARTESIAN;
						return;
					
					case Ifc4.Interfaces.IfcTrimmingPreference.PARAMETER:
						MasterRepresentation = IfcTrimmingPreference.PARAMETER;
						return;
					
					case Ifc4.Interfaces.IfcTrimmingPreference.UNSPECIFIED:
						MasterRepresentation = IfcTrimmingPreference.UNSPECIFIED;
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