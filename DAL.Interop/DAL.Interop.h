#pragma once

#include <cstdint>


#ifdef CREATE_EXPORT_LIB
#ifndef EXPORT_LIB
#define EXPORT_LIB __declspec( dllexport)
#endif
#else
#ifndef EXPORT_LIB
#define EXPORT_LIB __declspec( dllimport)
#endif
#endif


namespace DALInterop 
{

	class EXPORT_LIB StorageSystem
	{
	public:
		static std::int32_t GetPlaneBoardsCount();
	};
}
