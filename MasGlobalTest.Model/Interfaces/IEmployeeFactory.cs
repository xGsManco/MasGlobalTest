using MasGlobalTest.Model.Enums;

namespace MasGlobalTest.Model.Interfaces
{
    public interface IEmployeeFactory
    {
        IEmployee GetEmployee(ContractTypeName contractTypeName);
    }
}
