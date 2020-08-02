namespace Interface_Segregation_Principle_1
{
    interface IEditableRepository : IEmployeeRepository
    {
        void Add();
    }
}