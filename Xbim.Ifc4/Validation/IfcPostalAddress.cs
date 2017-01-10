using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc4.Interfaces;
using static Xbim.Ifc4.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.ActorResource
{
	public partial class IfcPostalAddress : IExpressValidatable
	{
		public enum IfcPostalAddressClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcPostalAddressClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcPostalAddressClause.WR1:
						retVal = EXISTS(InternalLocation) || EXISTS(AddressLines) || EXISTS(PostalBox) || EXISTS(PostalCode) || EXISTS(Town) || EXISTS(Region) || EXISTS(Country);
						break;
				}
			} catch (Exception ex) {
				var Log = LogManager.GetLogger("Xbim.Ifc4.ActorResource.IfcPostalAddress");
				Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcPostalAddress.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcPostalAddressClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPostalAddress.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}