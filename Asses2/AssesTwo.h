#pragma once

#ifdef ASSES_TWO_EXPORTS
#define ASSES_TWO_API __declspec(dllexport)
#else
#define ASSES_TWO_API __declspec(dllimport)
#endif

extern "C"  ASSES_TWO_API double* cppSinCos(double rad);

extern "C" ASSES_TWO_API int releaseMemory(double* array);

extern "C" ASSES_TWO_API int returnFive();