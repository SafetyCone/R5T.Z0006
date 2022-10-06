using System;


namespace R5T.Z0006
{
	public class NamespacedTypeNames : INamespacedTypeNames
	{
		#region Infrastructure

	    public static INamespacedTypeNames Instance { get; } = new NamespacedTypeNames();

	    private NamespacedTypeNames()
	    {
	    }

	    #endregion
	}
}