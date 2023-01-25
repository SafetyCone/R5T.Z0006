using System;

using R5T.T0131;


namespace R5T.Z0006
{
	[ValuesMarker]
	public interface INamespacedTypeNames : IValuesMarker
	{
		#region Attributes

		/// Attribute namespaced type names are needed for both type survey (by type name across assemblies in R5T.S0041) and Athenos (R5T.S0042) instance code file creation.

		public string ConstantsMarkerAttribute => "R5T.T0131.ConstantsMarkerAttribute";
		public string ContextDefinitionMarkerAttribute => "R5T.T0137.ContextDefinitionMarkerAttribute";
		public string ContextImplementationMarkerAttribute => "R5T.T0137.ContextImplementationMarkerAttribute";
		public string ContextTypeMarkerAttribute => "R5T.T0137.ContextTypeMarkerAttribute";
		public string DataTypeMarkerAttribute => "R5T.T0142.DataTypeMarkerAttribute";
		public string DemonstrationsMarkerAttribute => "R5T.T0141.DemonstrationsMarkerAttribute";
		public string ExperimentsMarkerAttribute => "R5T.T0141.ExperimentsMarkerAttribute";
		public string ExplorationsMarkerAttribute => "R5T.T0141.ExplorationsMarkerAttribute";
		public string FunctionalityMarkerAttribute => "R5T.T0132.FunctionalityMarkerAttribute";
		public string RazorComponentMarkerAttribute => "R5T.T0154.RazorComponentMarkerAttribute";
        public string ServiceDefinitionMarkerAttribute => "R5T.T0064.ServiceDefinitionMarkerAttribute";
		public string ServiceImplementationMarkerAttribute => "R5T.T0064.ServiceImplementationMarkerAttribute";
		public string StrongTypeMarkerAttribute => "R5T.T0150.StrongTypeMarkerAttribute";
		public string TriesMarkerAttribute => "R5T.T0141.TriesMarkerAttribute";
		public string TypeMarkerAttribute => "R5T.T0142.TypeMarkerAttribute";
		public string UtilityTypeMarkerAttribute => "R5T.T0142.UtilityTypeMarkerAttribute";
		public string ValuesMarkerAttribute => "R5T.T0131.ValuesMarkerAttribute";

		public string DraftsConstantsMarkerAttribute => "R5T.T0131.DraftConstantsMarkerAttribute";
		public string DraftContextTypeMarkerAttribute => "R5T.T0137.DraftContextTypeMarkerAttribute";
		public string DraftFunctionalityMarkerAttribute => "R5T.T0132.DraftFunctionalityMarkerAttribute";
		public string DraftDemonstrationsMarkerAttribute => "R5T.T0141.DraftDemonstrationsMarkerAttribute";
		public string DraftExperimentsMarkerAttribute => "R5T.T0141.DraftExperimentsMarkerAttribute";
		public string DraftExplorationsMarkerAttribute => "R5T.T0141.DraftExplorationsMarkerAttribute";
		public string DraftDataTypeMarkerAttribute => "R5T.T0142.DraftDataTypeMarkerAttribute";
		public string DraftRazorComponentMarkerAttribute => "R5T.T0154.DraftRazorComponentMarkerAttribute";
        public string DraftServiceDefinitionMarkerAttribute => "R5T.T0064.DraftServiceDefinitionMarkerAttribute";
		public string DraftServiceImplementationMarkerAttribute => "R5T.T0064.DraftServiceImplementationMarkerAttribute";
		public string DraftStrongTypeMarkerAttribute => "R5T.T0150.DraftStrongTypeMarkerAttribute";
		public string DraftTypeMarkerAttribute => "R5T.T0142.DraftTypeMarkerAttribute";
		public string DraftUtilityTypeMarkerAttribute => "R5T.T0142.DraftUtilityTypeMarkerAttribute";
		public string DraftValuesMarkerAttribute => "R5T.T0131.DraftValuesMarkerAttribute";

		#endregion

		#region Interfaces

		/// Interface namespaced type names are needed for 

		public string ContextTypeMarkerInterface => "R5T.T0137.IContextTypeMarker";
		public string DemonstrationsMarkerInterface => "R5T.T0141.IDemonstrationsMarker";
        public string ExperimentsMarkerInterface => "R5T.T0141.IExperimentsMarker";
        public string ExplorationsMarkerInterface => "R5T.T0141.IExplorationsMarker";
        public string FunctionalityMarkerInterface => "R5T.T0132.IFunctionalityMarker";
		public string TriesMarkerInterface => "R5T.T0141.ITriesMarker";
		public string ValuesMarkerInterface => "R5T.T0131.IValuesMarker";

		public string DraftContextTypeMarkerInterface => "R5T.T0137.IDraftContextTypeMarker";
		public string DraftDemonstrationsMarkerInterface => "R5T.T0141.IDraftDemonstrationsMarker";
        public string DraftExperimentsMarkerInterface => "R5T.T0141.IDraftExperimentsMarker";
        public string DraftExplorationsMarkerInterface => "R5T.T0141.IDraftExplorationsMarker";
        public string DraftFunctionalityMarkerInterface => "R5T.T0132.IDraftFunctionalityMarker";
        public string DraftValuesMarkerInterface => "R5T.T0131.IDraftValuesMarker";

        #endregion
    }
}