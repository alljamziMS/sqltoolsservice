namespace Microsoft.InsightsGenerator
{
    class SignatureGenerator
    {
        private DataArray table;
        private SignatureGeneratorResult results;
        public SignatureGenerator(DataArray table)
        {
            this.table = table;
        }

        public SignatureGeneratorResult Learn()
        {

        }
    }
}


public class SignatureGeneratorResult
{
    public Dictionary<string, string[]> results;
}