using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.ProfileResource;
using Xbim.Ifc2x3.ProfilePropertyResource;
using static Xbim.Ifc2x3.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	public partial class IfcAnnotationSymbolOccurrence : IExpressValidatable
	{
		public enum IfcAnnotationSymbolOccurrenceClause
		{
			WR31,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcAnnotationSymbolOccurrenceClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcAnnotationSymbolOccurrenceClause.WR31:
						retVal = !(EXISTS(this/* as IfcStyledItem*/.Item)) || (TYPEOF(this/* as IfcStyledItem*/.Item).Contains("IFC2X3.IFCDEFINEDSYMBOL"));
						break;
				}
			} catch (Exception ex) {
				var Log = LogManager.GetLogger("Xbim.Ifc2x3.PresentationDefinitionResource.IfcAnnotationSymbolOccurrence");
				Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcAnnotationSymbolOccurrence.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcAnnotationSymbolOccurrenceClause.WR31))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcAnnotationSymbolOccurrence.WR31", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}