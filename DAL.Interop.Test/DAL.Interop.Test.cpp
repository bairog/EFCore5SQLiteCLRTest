#include <iostream>
#include <DAL.Interop.h>

int main()
{
    auto ret = DALInterop::StorageSystem::GetPlaneBoardsCount();
    std::cout << ret;
}
