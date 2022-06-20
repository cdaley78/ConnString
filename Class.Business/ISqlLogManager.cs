namespace Class.SqlLogger
{
    public interface ISqlLogManager
    {
        public string ConnectionStringName { get; }
        bool InitDb();
    }
}
