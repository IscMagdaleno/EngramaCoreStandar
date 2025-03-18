namespace EngramaCoreStandar.Dapper.Results
{
	internal class GenericResponse
	{
		public bool bResult { get; set; } = false;
		public string vchMessage { get; set; } = "Sin Resultado";

		public GenericResponse()
		{

		}

		public GenericResponse(bool bResult, string vchMessage)
		{
			this.bResult = bResult;

			this.vchMessage = vchMessage;


		}
	}
}

