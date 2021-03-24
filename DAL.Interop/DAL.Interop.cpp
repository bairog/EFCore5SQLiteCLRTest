#include "DAL.Interop.h"


using namespace DAL;


namespace DALInterop
{
	std::int32_t StorageSystem::GetPlaneBoardsCount()
	{
		try
		{
			auto ret_managed = CRUD::GetPlaneBoardsCount();

			return static_cast<std::int32_t>(ret_managed);
		}
		catch (System::Exception^ managed_ex)
		{
			return -1;
		}
	}
}

