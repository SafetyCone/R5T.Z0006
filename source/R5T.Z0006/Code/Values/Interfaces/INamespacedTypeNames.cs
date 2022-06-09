using System;

using R5T.T0131;


namespace R5T.Z0006
{
	[ValuesMarker]
	public interface INamespacedTypeNames : IValuesMarker
	{
		public string DraftFunctionalityMarkerAttribute => "R5T.T0132.DraftFunctionalityMarkerAttribute";
		public string DraftFunctionalityMarkerInterface => "R5T.T0132.IDraftFunctionalityMarker";
		public string DraftValuesMarkerAttribute => "R5T.T0131.DraftValuesMarkerAttribute";
		public string DraftValuesMarkerInterface => "R5T.T0131.IDraftValuesMarker";

		public string DemonstrationsMarkerAttribute => "R5T.T0141.DemonstrationsMarkerAttribute";
		public string ExperimentsMarkerAttribute => "R5T.T0141.ExperimentsMarkerAttribute";
		public string ExplorationsMarkerAttribute => "R5T.T0141.ExplorationsMarkerAttribute";

		public string DraftDemonstrationsMarkerAttribute => "R5T.T0141.DraftDemonstrationsMarkerAttribute";
		public string DraftExperimentsMarkerAttribute => "R5T.T0141.DraftExperimentsMarkerAttribute";
		public string DraftExplorationsMarkerAttribute => "R5T.T0141.DraftExplorationsMarkerAttribute";

		public string DemonstrationsMarkerInterface => "R5T.T0141.IDemonstrationsMarker";
		public string ExperimentsMarkerInterface => "R5T.T0141.IExperimentsMarker";
		public string ExplorationsMarkerInterface => "R5T.T0141.IExplorationsMarker";

		public string DraftDemonstrationsMarkerInterface => "R5T.T0141.IDraftDemonstrationsMarker";
		public string DraftExperimentsMarkerInterface => "R5T.T0141.IDraftExperimentsMarker";
		public string DraftExplorationsMarkerInterface => "R5T.T0141.IDraftExplorationsMarker";

		public string FunctionalityMarkerAttribute => "R5T.T0132.FunctionalityMarkerAttribute";
		public string FunctionalityMarkerInterface => "R5T.T0132.IFunctionalityMarker";
		public string ValuesMarkerAttribute => "R5T.T0131.ValuesMarkerAttribute";
		public string ValuesMarkerInterface => "R5T.T0131.IValuesMarker";
	}
}