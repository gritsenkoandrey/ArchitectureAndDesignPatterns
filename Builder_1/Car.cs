namespace Builder_1
{
    public class Car
    {
        private string _body = "";
        private string _chasiss = "";
        private string _engine = "";

        public void SetBody(string body) => _body = body;
        public void SetChasiss(string chasiss) => _chasiss = chasiss;
        public void SetEngine(string engine) => _engine = engine;

        public override string ToString()
        {
            return $"{_body} {_chasiss} {_engine}";
        }
    }
}