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
namespace Xbim.Ifc2x3.TimeSeriesResource
{
	public partial class @IfcIrregularTimeSeriesValue : IIfcIrregularTimeSeriesValue
	{
		Ifc4.DateTimeResource.IfcDateTime IIfcIrregularTimeSeriesValue.TimeStamp 
		{ 
			get
			{
				//## Handle return of TimeStamp for which no match was found
			    return TimeStamp != null
			        ? new Ifc4.DateTimeResource.IfcDateTime(TimeStamp.ToISODateTimeString())
                    : new Ifc4.DateTimeResource.IfcDateTime();
				//##
			} 
			set
			{
				//## Handle setting of TimeStamp for which no match was found
                System.DateTime d = value;
                TimeStamp = Model.Instances.New<DateTimeResource.IfcDateAndTime>(dt =>
                {
                    dt.DateComponent = Model.Instances.New<DateTimeResource.IfcCalendarDate>(date =>
                    {
                        date.YearComponent = d.Year;
                        date.MonthComponent = d.Month;
                        date.DayComponent = d.Day;
                    });
                    dt.TimeComponent = Model.Instances.New<DateTimeResource.IfcLocalTime>(t =>
                    {
                        t.HourComponent = d.Hour;
                        t.MinuteComponent = d.Minute;
                        t.SecondComponent = d.Second;
                    });
                });
				//##
				
			}
		}
		IItemSet<IIfcValue> IIfcIrregularTimeSeriesValue.ListValues 
		{ 
			get
			{
			
				return _listValuesIfc4 ?? (_listValuesIfc4 = new Common.Collections.ExtendedItemSet<MeasureResource.IfcValue, IIfcValue>(
                    ListValues, 
                    new ItemSet<IIfcValue>(this, 0, 255), 
                    v => v.ToIfc4(), 
                    v => v.ToIfc3()));
			} 
		}

		//private field to hold any extended data
		private IItemSet<IIfcValue> _listValuesIfc4;
	//## Custom code
	//##
	}
}